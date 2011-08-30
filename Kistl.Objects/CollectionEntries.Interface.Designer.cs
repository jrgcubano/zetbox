// <autogenerated/>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

using Kistl.API;

// <autogenerated/>

namespace Kistl.App.Base
{
    using Kistl.API;
    using Kistl.App.Base;

    /// <summary>
    /// ObjectCollectionEntry for on which other properties this one depends (used for change notification)
    /// </summary>
    public interface CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntry : IRelationEntry<CalculatedObjectReferenceProperty, Property> 
    {

    }
}// <autogenerated/>

namespace at.dasz.DocumentManagement
{
    using Kistl.API;
    using at.dasz.DocumentManagement;
    using Kistl.App.Base;

    /// <summary>
    /// ObjectCollectionEntry for Document has Revisions
    /// </summary>
    public interface Document_has_Blob_RelationEntry : IRelationListEntry<Document, Blob> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Base
{
    using Kistl.API;
    using Kistl.App.Base;

    /// <summary>
    /// ObjectCollectionEntry for Identites are member of Groups
    /// </summary>
    public interface Identity_memberOf_Group_RelationEntry : IRelationEntry<Identity, Group> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Base
{
    using Kistl.API;
    using Kistl.App.Base;

    /// <summary>
    /// ObjectCollectionEntry for UniqueContraints ensures uniqueness on one or more properties
    /// </summary>
    public interface IndexConstraint_ensures_unique_on_Property_RelationEntry : IRelationEntry<IndexConstraint, Property> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Test
{
    using Kistl.API;
    using Kistl.App.Test;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface Muhblah_has_TestCustomObject_RelationEntry : IRelationEntry<Muhblah, TestCustomObject> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Test
{
    using Kistl.API;
    using Kistl.App.Test;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntry : IRelationEntry<N_to_M_relations_A, N_to_M_relations_B> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.GUI
{
    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.App.GUI;

    /// <summary>
    /// ObjectCollectionEntry for These Groups are allowed to see this Screen
    /// </summary>
    public interface NavigationScreen_accessed_by_Group_RelationEntry : IRelationEntry<NavigationScreen, Group> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Base
{
    using Kistl.API;
    using Kistl.App.Base;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface ObjectClass_implements_Interface_RelationEntry : IRelationEntry<ObjectClass, Interface> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Projekte
{
    using Kistl.API;
    using Kistl.App.Projekte;

    /// <summary>
    /// ObjectCollectionEntry for Projekte werden von Mitarbeitern durchgeführt
    /// </summary>
    public interface Projekt_haben_Mitarbeiter_RelationEntry : IRelationListEntry<Projekt, Mitarbeiter> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Base
{
    using Kistl.API;
    using Kistl.App.Base;

    /// <summary>
    /// ObjectCollectionEntry for RoleMembership needs Relations to resolve Roles
    /// </summary>
    public interface RoleMembership_resolves_Relation_RelationEntry : IRelationListEntry<RoleMembership, Relation> 
    {

    }
}// <autogenerated/>

namespace ZBox.App.SchemaMigration
{
    using Kistl.API;
    using Kistl.App.Base;
    using ZBox.App.SchemaMigration;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface SourceColumn_created_Property_RelationEntry : IRelationListEntry<SourceColumn, Property> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.GUI
{
    using Kistl.API;
    using Kistl.App.GUI;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface Template_hasMenu_Visual_RelationEntry : IRelationEntry<Template, Visual> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Test
{
    using Kistl.API;
    using Kistl.App.Test;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface TestStudent_füllt_aus_Fragebogen_RelationEntry : IRelationEntry<TestStudent, Fragebogen> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Base
{
    using Kistl.API;
    using Kistl.App.Base;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface TypeRef_hasGenericArguments_TypeRef_RelationEntry : IRelationListEntry<TypeRef, TypeRef> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.GUI
{
    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.App.GUI;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface ViewDescriptor_supports_TypeRef_RelationEntry : IRelationEntry<ViewDescriptor, TypeRef> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.GUI
{
    using Kistl.API;
    using Kistl.App.GUI;

    /// <summary>
    /// ObjectCollectionEntry for a list of additional control kinds for displaying this model
    /// </summary>
    public interface ViewModelDescriptor_displayedBy_ControlKind_RelationEntry : IRelationEntry<ViewModelDescriptor, ControlKind> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.GUI
{
    using Kistl.API;
    using Kistl.App.GUI;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface Visual_contains_Visual_RelationEntry : IRelationEntry<Visual, Visual> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.GUI
{
    using Kistl.API;
    using Kistl.App.GUI;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface Visual_hasContextMenu_Visual_RelationEntry : IRelationEntry<Visual, Visual> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Projekte
{
    using Kistl.API;

    /// <summary>
    /// ValueCollectionEntry for EMails des Kunden - können mehrere sein
    /// </summary>
    public interface Kunde_EMails_CollectionEntry : IValueCollectionEntry<Kunde, System.String> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Test
{
    using Kistl.API;

    /// <summary>
    /// ValueCollectionEntry for 
    /// </summary>
    public interface TestCustomObject_PhoneNumbersOther_CollectionEntry : IValueCollectionEntry<TestCustomObject, Kistl.App.Test.TestPhoneCompoundObject> 
    {

    }
}