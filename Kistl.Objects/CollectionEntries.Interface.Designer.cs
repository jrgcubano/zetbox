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
    public interface CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntry : IRelationCollectionEntry<CalculatedObjectReferenceProperty, Property> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.GUI
{
    using Kistl.API;
    using Kistl.App.GUI;
    using Kistl.App.Base;

    /// <summary>
    /// ObjectCollectionEntry for Describes the supported interfaces of a specific class of ControlKinds
    /// </summary>
    public interface ControlKindClass_supports_TypeRef_RelationEntry : IRelationCollectionEntry<ControlKindClass, TypeRef> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.Base
{
    using Kistl.API;
    using Kistl.App.Base;

    /// <summary>
    /// ObjectCollectionEntry for Group can have a parent group
    /// </summary>
    public interface Group_memberOf_Group_RelationEntry : IRelationCollectionEntry<Group, Group> 
    {

    }
}// <autogenerated/>

namespace at.dasz.CourseOrganiser
{
    using Kistl.API;
    using at.dasz.CourseOrganiser;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface GroupExcercise_accomplished_by_Student_RelationEntry : IRelationCollectionEntry<GroupExcercise, Student> 
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
    public interface Identity_memberOf_Group_RelationEntry : IRelationCollectionEntry<Identity, Group> 
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
    public interface Muhblah_has_TestCustomObject_RelationEntry : IRelationCollectionEntry<Muhblah, TestCustomObject> 
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
    public interface ObjectClass_implements_Interface_RelationEntry : IRelationCollectionEntry<ObjectClass, Interface> 
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
    public interface PresentableModelDescriptor_displayedBy_ControlKind_RelationEntry : IRelationCollectionEntry<PresentableModelDescriptor, ControlKind> 
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

namespace at.dasz.CourseOrganiser
{
    using Kistl.API;
    using at.dasz.CourseOrganiser;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface Student_attend_Semester_RelationEntry : IRelationCollectionEntry<Student, Semester> 
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
    public interface Template_hasMenu_Visual_RelationEntry : IRelationCollectionEntry<Template, Visual> 
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
    using Kistl.App.GUI;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface Visual_contains_Visual_RelationEntry : IRelationCollectionEntry<Visual, Visual> 
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
    public interface Visual_hasContextMenu_Visual_RelationEntry : IRelationCollectionEntry<Visual, Visual> 
    {

    }
}// <autogenerated/>

namespace Kistl.App.TimeRecords
{
    using Kistl.API;
    using Kistl.App.TimeRecords;
    using Kistl.App.Projekte;

    /// <summary>
    /// ObjectCollectionEntry for 
    /// </summary>
    public interface WorkEffortAccount_has_Mitarbeiter_RelationEntry : IRelationCollectionEntry<WorkEffortAccount, Mitarbeiter> 
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