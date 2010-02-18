
namespace Kistl.API.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;

    using NUnit.Framework;

    public abstract class GenericCollectionTests<TCollection, TItem>
        where TCollection : ICollection<TItem>
    {
        private static int itemNumber = 0;

        protected readonly int items;

        protected GenericCollectionTests(int items)
        {
            this.items = items;
        }

        protected int NewItemNumber()
        {
            return itemNumber++;
        }

        /// <summary>
        /// initialise a list of items that shall be passed to the collection
        /// </summary>
        /// <returns></returns>
        protected virtual List<TItem> InitialItems()
        {
            var result = new List<TItem>(items);
            for (int i = 0; i < items; i++)
            {
                result.Add(NewItem());
            }
            return result;
        }

        /// <summary>
        /// creates a new item, which is not currently in the list
        /// </summary>
        /// <returns></returns>
        protected abstract TItem NewItem();

        protected List<TItem> initialItems;
        protected TCollection collection;

        /// <summary>
        /// Create the actual collection from the specified items
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        protected virtual TCollection CreateCollection(List<TItem> items)
        {
            // die here, if inheritors didn't care to overwrite this
            // but have changed the TCollection argument
            // TODO: consider making this abstract; baseline can be established elsewhere
            return (TCollection)(ICollection)new List<TItem>(items);
        }

        /// <summary>
        /// Assert conditions specific to the implementation which must hold always.
        /// </summary>
        /// <param name="expectedItems">holds the items the test is expecting to be contained in the collection</param>
        protected virtual void AssertInvariants(List<TItem> expectedItems)
        {
            Assert.That(collection.Cast<object>().OrderBy(o => o.GetHashCode()).ToArray(),
                Is.EquivalentTo(expectedItems.OrderBy(o => o.GetHashCode()).ToArray()));
        }


        /// <summary>
        /// Asserts that the collection has changed. Can be called multiple times in a test. Use this to test notifications and similiar things.
        /// </summary>
        protected virtual void AssertCollectionIsChanged()
        {
        }

        /// <summary>
        /// Asserts that the collection has not changed. Can be called multiple times in a test. Use this to test notifications and similiar things.
        /// </summary>
        protected virtual void AssertCollectionIsUnchanged()
        {
        }

        [SetUp]
        public void SetUp()
        {
            PreSetup();
            initialItems = InitialItems();
            collection = CreateCollection(initialItems);
            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        [TearDown]
        public void TearDown()
        {
            PostTeardown();
        }

        /// <summary>
        /// Called before anything else in a Test.
        /// </summary>
        protected virtual void PreSetup() { }

        /// <summary>
        /// Called as the last thing in a Test.
        /// </summary>
        protected virtual void PostTeardown() { }

        #region ICollection tests

        [Test]
        public void count_should_have_initial_number_of_items()
        {
            Assert.That(collection.Count, Is.EqualTo(initialItems.Count));
            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        [Test]
        public void isreadonly_should_not_be_set()
        {
            Assert.That(collection.IsReadOnly, Is.False);
            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        [Test]
        public void add_should_insert_items_at_the_end([Range(1, 100, 10)]int numItems)
        {
            var expectedItems = new List<TItem>(initialItems);
            for (int i = 0; i < numItems; i++)
            {
                var newItem = NewItem();

                collection.Add(newItem);
                expectedItems.Add(newItem);

                Assert.That(collection, Has.Member(newItem));
                AssertCollectionIsChanged();
            }
            AssertInvariants(expectedItems);
        }

        [Test]
        public void clear_should_remove_all_items()
        {
            var count = collection.Count;
            collection.Clear();
            Assert.That(collection, Is.Empty);
            // The ObservableCollection does fire a notification 
            // even if the collection is empty; Since we don't 
            // actually want this, but need to properly test it,
            // we special case it here:
            if (count == 0 && !IsObservableCollection(typeof(TCollection)))
            {
                AssertCollectionIsUnchanged();
            }
            else
            {
                AssertCollectionIsChanged();
            }
            AssertInvariants(new List<TItem>(0));
        }

        private static bool IsObservableCollection(Type t)
        {
            while (t != null)
            {
                if (t.IsGenericType && typeof(ObservableCollection<>).IsAssignableFrom(t.GetGenericTypeDefinition()))
                {
                    return true;
                }
                t = t.BaseType;
            }
            return false;
        }

        [Test]
        public void contains_should_return_true_on_contained_item()
        {
            foreach (var item in initialItems)
            {
                Assert.That(collection.Contains(item), Is.True);
                AssertCollectionIsUnchanged();
            }
            AssertInvariants(initialItems);
        }

        [Test]
        public void contains_should_return_false_on_other_item()
        {
            var otherItem = NewItem();
            Assert.That(collection.Contains(otherItem), Is.False);
            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        [Test]
        public void copyto_should_check_array_for_null()
        {
            Assert.That(() => collection.CopyTo(null, 0), Throws.InstanceOf<ArgumentNullException>());
            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        [Test]
        public void copyto_should_check_index_nonnegative()
        {
            Assert.That(() => collection.CopyTo(new TItem[10], -1), Throws.InstanceOf<ArgumentOutOfRangeException>());
            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        [Test]
        public void copyto_should_check_index_not_greater_than_or_equal_array_length(
            [Range(-10, 10)] int offset)
        {
            var destination = new TItem[initialItems.Count + 5];
            var destinationIndex = destination.Length - offset;

            // avoid different error conditions
            Assume.That(initialItems.Count, Is.GreaterThan(0));
            Assume.That(destinationIndex, Is.GreaterThanOrEqualTo(destination.Length));

            var msg = String.Format("Copying {0} items into {1} elements, starting at {2}",
                initialItems.Count,
                destination.Length,
                destinationIndex);

            // index is equal to or greater than the length of array
            Assert.That(() => { collection.CopyTo(destination, destinationIndex); return null; }, Throws.ArgumentException, msg);
            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        [Test]
        public void copyto_should_check_enough_available_space(
            [Range(-10, 10)] int offset)
        {
            var destination = new TItem[initialItems.Count + 5];
            var destinationIndex = destination.Length - initialItems.Count - offset + 1;

            // only test with initialItems where there is enough items available
            // to cause an overflow and we do not run in any other error condition
            Assume.That(destinationIndex, Is.GreaterThan(0));
            Assume.That(destinationIndex, Is.LessThan(destination.Length));
            Assume.That(destinationIndex + initialItems.Count, Is.GreaterThan(destination.Length));//, "not enough items to create overflow");

            // The number of elements in the source System.Collections.ICollection
            // is greater than the available space from index to the end of the
            // destination array
            Assert.That(() => collection.CopyTo(destination, destinationIndex),
                Throws.ArgumentException);

            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        [Test]
        public void copyto_should_copy_items(
            [Range(0, 10)] int offset)
        {
            // create big enough array
            var destination = new TItem[initialItems.Count + 20];

            // The number of elements in the source System.Collections.ICollection
            // is greater than the available space from index to the end of the
            // destination array
            Assert.That(() => collection.CopyTo(destination, offset),
                Throws.Nothing);

            Assert.That(destination.Skip(offset).Take(initialItems.Count).OrderBy(o => o.GetHashCode()),
                Is.EquivalentTo(initialItems.OrderBy(o => o.GetHashCode())));

            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        [Test]
        public void should_return_true_on_remove_contained_item([Range(0, 5)]int index)
        {
            Assume.That(index, Is.GreaterThanOrEqualTo(0));
            Assume.That(index, Is.LessThan(initialItems.Count));

            var item = initialItems[index];
            Assert.That(collection.Remove(item), Is.True);

            AssertCollectionIsChanged();

            var expectedItems = new List<TItem>(initialItems);
            expectedItems.Remove(item);
            AssertInvariants(expectedItems);
        }

        [Test]
        public void should_return_true_on_remove_contained_item_from_end(
             [Range(0, 5)]int offset)
        {
            should_return_true_on_remove_contained_item(initialItems.Count - offset);
        }

        [Test]
        public void should_return_false_on_remove_other_item()
        {
            var otherItem = NewItem();
            Assert.That(collection.Remove(otherItem), Is.False);
            AssertCollectionIsUnchanged();
            AssertInvariants(initialItems);
        }

        #endregion

        #region IEnumerator tests

        [Test]
        public void enumerator_should_yield_all_items()
        {
            var test = new List<TItem>();
            foreach (var item in (IEnumerable)collection)
            {
                test.Add((TItem)item);
                AssertCollectionIsUnchanged();
            }

            Assert.That(test.OrderBy(o => o.GetHashCode()),
                Is.EquivalentTo(initialItems.OrderBy(o => o.GetHashCode())));

            AssertInvariants(initialItems);
        }

        #endregion
    }
}
