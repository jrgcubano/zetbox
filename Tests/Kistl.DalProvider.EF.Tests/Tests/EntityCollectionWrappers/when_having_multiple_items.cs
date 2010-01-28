
namespace Kistl.DalProvider.EF.Tests.EntityCollectionWrappers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.App.Projekte;

    using NUnit.Framework;

    [TestFixture]
    public class when_having_multiple_items
        : WrapperFixture
    {
        private Projekt__Implementation__[] items;

        protected override void InitCollection()
        {
            items = new[] { 
                new Projekt__Implementation__(),
                new Projekt__Implementation__(),
                new Projekt__Implementation__(),
                new Projekt__Implementation__(),
                new Projekt__Implementation__() };
            underlyingCollection.AddRange(items);
        }

        protected override void InitWrapper()
        {
        }

        [Test]
        public void should_have_the_items()
        {
            Assert.That(wrapper.OrderBy(o => o.GetHashCode()), Is.EquivalentTo(items.OrderBy(o => o.GetHashCode())));
        }

        [Test]
        public void should_leave_underlyingCollection_in_correct_state()
        {
            Assert.That(underlyingCollection, Is.EquivalentTo(items));
        }

        [Test]
        public void should_have_correct_count()
        {
            Assert.That(wrapper.Count, Is.EqualTo(items.Length));
        }

        [Test]
        public void should_return_true_on_contains_containedItem()
        {
            foreach (var i in items)
            {
                Assert.That(wrapper.Contains(i), Is.True);
            }
        }

        [Test]
        public void should_copyTo_any_length_array()
        {
            foreach (var length in new[] { 0, 1, 10, 100 })
            {
                foreach (var arrayIndex in new[] { 0, 1, 2, 9, 10, 11, 50, 99, 100, 101 })
                {
                    if (arrayIndex + items.Length < length) // only legal calls
                    {
                        var array = new Projekt[length];
                        Assert.That(() => wrapper.CopyTo(array, arrayIndex), Throws.Nothing);
                        var results = new Projekt[items.Length];
                        Array.Copy(array, arrayIndex, results, 0, results.Length);
                        Assert.That(results.OrderBy(o => o.GetHashCode()), Is.EquivalentTo(items.OrderBy(o => o.GetHashCode())));
                    }
                }
            }
        }
    }
}
