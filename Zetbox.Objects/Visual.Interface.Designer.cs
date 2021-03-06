// <autogenerated/>

namespace Zetbox.App.GUI
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// 
    /// </summary>
    [Zetbox.API.DefinitionGuid("98790e5d-808f-4e0b-8a1a-b304839f07ab")]
    public interface Visual : IDataObject 
    {

        /// <summary>
        /// if this is a container, here are the visually contained/controlled children of this Visual
        /// </summary>

        [Zetbox.API.DefinitionGuid("9f69c3bd-e274-4639-b30c-8d2a9599917b")]
        ICollection<Zetbox.App.GUI.Visual> Children { get; }

        /// <summary>
        /// The context menu for this Visual
        /// </summary>

        [Zetbox.API.DefinitionGuid("7b18f26e-0f3f-4554-b469-1029bd4ca10b")]
        ICollection<Zetbox.App.GUI.Visual> ContextMenu { get; }

        /// <summary>
        /// A short description of the utility of this visual
        /// </summary>
        [Zetbox.API.DefinitionGuid("8d3b7c91-2bbf-4dcf-bc37-318dc0fda92d")]
        string Description {
            get;
            set;
        }

        /// <summary>
        /// The Method whose return value shoud be displayed
        /// </summary>
        [Zetbox.API.DefinitionGuid("0b55b2ba-3ac0-4631-8a73-1e8846c8e9b1")]
        Zetbox.App.Base.Method Method {
            get;
            set;
        }

        /// <summary>
        /// The Property to display
        /// </summary>
        [Zetbox.API.DefinitionGuid("a432e3ff-61ed-4726-8559-f34516181065")]
        Zetbox.App.Base.Property Property {
            get;
            set;
        }
    }
}
