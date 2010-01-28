
namespace Kistl.DalProvider.EF.Tests.EntityListWrappers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.App.Base;

    using NUnit.Framework;

    [TestFixture]
    public class when_empty
        : Kistl.DalProvider.EF.Tests.EntityCollectionWrappers.when_empty<EntityListWrapper<Property, Property__Implementation__>>
    {
        protected override EntityListWrapper<Property, Property__Implementation__> CreateWrapper()
        {
            return new EntityListWrapper<Property, Property__Implementation__>(null, underlyingCollection, "ObjectClass");
        }
    }
}
