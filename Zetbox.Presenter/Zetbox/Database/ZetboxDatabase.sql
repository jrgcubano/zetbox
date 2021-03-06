CREATE TABLE [IntProperties](
	[ID] [int] NOT NULL PRIMARY KEY
)
GO
CREATE TABLE [DoubleProperties](
	[ID] [int] NOT NULL PRIMARY KEY
)
GO
INSERT [DoubleProperties] ([ID]) VALUES (18);
INSERT [DoubleProperties] ([ID]) VALUES (23);
INSERT [DoubleProperties] ([ID]) VALUES (57);
INSERT [DoubleProperties] ([ID]) VALUES (65);
GO
CREATE TABLE [BoolProperties](
	[ID] [int] NOT NULL PRIMARY KEY
)
GO
INSERT [BoolProperties] ([ID]) VALUES (11);
INSERT [BoolProperties] ([ID]) VALUES (26);
GO
CREATE TABLE [ObjectReferenceProperties](
	[ID] [int] NOT NULL PRIMARY KEY,
	[ReferenceObjectClassName] [nvarchar](200)  NULL,
	[fk_ReferenceObjectClass] [int] NULL
)
GO
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (8, N'Kistl.App.Base.ObjectClass', 2);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (19, N'Kistl.App.Projekte.Projekt', 3);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (22, N'Kistl.App.Projekte.Mitarbeiter', 6);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (25, N'Kistl.App.Base.ObjectClass', 2);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (29, N'Kistl.App.Base.ObjectClass', 2);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (45, N'Kistl.App.Base.Module', 18);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (46, N'Kistl.App.Base.ObjectClass', 2);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (47, NULL, 14);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (49, NULL, 6);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (51, NULL, 3);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (53, NULL, 3);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (54, NULL, 6);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (55, NULL, 20);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (64, NULL, 26);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (69, NULL, 27);
INSERT [ObjectReferenceProperties] ([ID], [ReferenceObjectClassName], [fk_ReferenceObjectClass]) VALUES (70, NULL, 18);
GO
CREATE TABLE [DateTimeProperties](
	[ID] [int] NOT NULL PRIMARY KEY
)
GO
INSERT [DateTimeProperties] ([ID]) VALUES (16);
INSERT [DateTimeProperties] ([ID]) VALUES (17);
INSERT [DateTimeProperties] ([ID]) VALUES (38);
INSERT [DateTimeProperties] ([ID]) VALUES (56);
CREATE TABLE [ObjectClasses](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ClassName] [nvarchar](51)  NOT NULL,
	[TableName] [nvarchar](100)  NOT NULL,
	[fk_BaseObjectClass] [int] NULL,
	[fk_Module] [int] NOT NULL,
	[BaseObjectClass] [int] NULL,
	[fk_DefaultIcon] [int] NULL
)
GO
SET IDENTITY_INSERT [ObjectClasses] ON;
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (2, N'ObjectClass', N'ObjectClasses', NULL, 1, NULL, 11);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (3, N'Projekt', N'Projekte', NULL, 2, NULL, 3);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (4, N'Task', N'Tasks', NULL, 2, NULL, 7);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (5, N'BaseProperty', N'BaseProperties', NULL, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (6, N'Mitarbeiter', N'Mitarbeiter', NULL, 2, NULL, 5);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (7, N'Property', N'Properties', 5, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (8, N'ValueTypeProperty', N'ValueTypeProperties', 7, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (9, N'StringProperty', N'StringProperties', 8, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (10, N'Method', N'Methods', NULL, 1, NULL, 2);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (11, N'IntProperty', N'IntProperties', 8, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (12, N'BoolProperty', N'BoolProperties', 8, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (13, N'DoubleProperty', N'DoubleProperties', 8, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (14, N'ObjectReferenceProperty', N'ObjectReferenceProperties', 7, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (15, N'DateTimeProperty', N'DateTimeProperties', 8, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (16, N'BackReferenceProperty', N'BackReferenceProperties', 5, 1, NULL, 9);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (18, N'Module', N'Modules', NULL, 1, NULL, 1);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (19, N'Auftrag', N'Auftraege', NULL, 2, NULL, 8);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (20, N'Zeitkonto', N'Zeitkonten', NULL, 3, NULL, 12);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (21, N'Kostenstelle', N'Kostenstellen', 20, 3, NULL, 10);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (23, N'Kostentraeger', N'Kostentraeger', 20, 3, NULL, 3);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (25, N'Taetigkeit', N'Taetigkeiten', NULL, 3, NULL, 7);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (26, N'Kunde', N'Kunden', NULL, 2, NULL, 6);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (27, N'Icon', N'Icons', NULL, 4, NULL, 4);
INSERT [ObjectClasses] ([ID], [ClassName], [TableName], [fk_BaseObjectClass], [fk_Module], [BaseObjectClass], [fk_DefaultIcon]) VALUES (29, N'Assembly', N'Assemblies', NULL, 1, NULL, 13);
SET IDENTITY_INSERT [ObjectClasses] OFF;
GO
CREATE TABLE [BackReferenceProperties](
	[ID] [int] NOT NULL PRIMARY KEY,
	[ReferenceObjectClassName] [nvarchar](200)  NULL,
	[ReferencePropertyName] [nvarchar](200)  NULL,
	[fk_ReferenceProperty] [int] NULL
)
GO
INSERT [BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty]) VALUES (7, N'Kistl.App.Base.BaseProperty', N'ObjectClass', 8);
INSERT [BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty]) VALUES (14, N'Kistl.App.Projekte.Task', N'Projekt', 19);
INSERT [BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty]) VALUES (21, N'Kistl.App.Projekte.Projekt', N'Mitarbeiter', 22);
INSERT [BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty]) VALUES (27, N'Kistl.App.Base.ObjectClass', N'BaseObjectClass', 25);
INSERT [BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty]) VALUES (31, N'Kistl.App.Base.Method', N'ObjectClass', 29);
INSERT [BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty]) VALUES (44, N'Kistl.App.Base.ObjectClass', N'Module', 45);
INSERT [BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty]) VALUES (58, NULL, NULL, 55);
INSERT [BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty]) VALUES (66, NULL, NULL, 53);
INSERT [BackReferenceProperties] ([ID], [ReferenceObjectClassName], [ReferencePropertyName], [fk_ReferenceProperty]) VALUES (67, NULL, NULL, 51);
GO
CREATE TABLE [Modules](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Namespace] [nvarchar](200)  NOT NULL,
	[ModuleName] [nvarchar](200)  NOT NULL
)
GO
SET IDENTITY_INSERT [Modules] ON;
INSERT [Modules] ([ID], [Namespace], [ModuleName]) VALUES (1, N'Kistl.App.Base', N'KistlBase');
INSERT [Modules] ([ID], [Namespace], [ModuleName]) VALUES (2, N'Kistl.App.Projekte', N'Projekte');
INSERT [Modules] ([ID], [Namespace], [ModuleName]) VALUES (3, N'Kistl.App.Zeiterfassung', N'Zeiterfassung');
INSERT [Modules] ([ID], [Namespace], [ModuleName]) VALUES (4, N'Kistl.App.GUI', N'GUI');
SET IDENTITY_INSERT [Modules] OFF;
GO
CREATE TABLE [Auftraege](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[fk_Mitarbeiter] [int] NULL,
	[Auftragsname] [nvarchar](200)  NULL,
	[fk_Projekt] [int] NULL,
	[fk_Kunde] [int] NULL,
	[Auftragswert] [float] NULL
)
GO
SET IDENTITY_INSERT [Auftraege] ON;
INSERT [Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert]) VALUES (1, 1, N'Auftrag für den Businessplan', 1, 1, NULL);
INSERT [Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert]) VALUES (2, 2, N'Auftrag für Marketingunterlagen', 1, NULL, NULL);
INSERT [Auftraege] ([ID], [fk_Mitarbeiter], [Auftragsname], [fk_Projekt], [fk_Kunde], [Auftragswert]) VALUES (3, 2, N'Kistl Implementierungsprojekt', 1, 1, 100000);
SET IDENTITY_INSERT [Auftraege] OFF;
GO
CREATE TABLE [Zeitkonten](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Kontoname] [nvarchar](200)  NOT NULL
)
GO
SET IDENTITY_INSERT [Zeitkonten] ON;
INSERT [Zeitkonten] ([ID], [Kontoname]) VALUES (1, N'Kistlkostenträger - Entwicklung');
INSERT [Zeitkonten] ([ID], [Kontoname]) VALUES (2, N'Kistlkostenträger - Meeting');
SET IDENTITY_INSERT [Zeitkonten] OFF;
GO
CREATE TABLE [Kostenstellen](
	[ID] [int] NOT NULL PRIMARY KEY
)
GO
CREATE TABLE [Kostentraeger](
	[ID] [int] NOT NULL PRIMARY KEY,
	[fk_Projekt] [int] NOT NULL
)
GO
INSERT [Kostentraeger] ([ID], [fk_Projekt]) VALUES (1, 1);
INSERT [Kostentraeger] ([ID], [fk_Projekt]) VALUES (2, 1);
GO
CREATE TABLE [Taetigkeiten](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[fk_Mitarbeiter] [int] NOT NULL,
	[fk_Zeitkonto] [int] NOT NULL,
	[Datum] [datetime] NOT NULL,
	[Dauer] [float] NOT NULL
)
GO
SET IDENTITY_INSERT [Taetigkeiten] ON;
INSERT [Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (1, 2, 1, getdate(), 6.5);
INSERT [Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (2, 1, 1, getdate(), 4);
INSERT [Taetigkeiten] ([ID], [fk_Mitarbeiter], [fk_Zeitkonto], [Datum], [Dauer]) VALUES (4, 1, 2, getdate(), 1);
SET IDENTITY_INSERT [Taetigkeiten] OFF;
GO
CREATE TABLE [Kunden](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Kundenname] [nvarchar](200)  NOT NULL,
	[Adresse] [nvarchar](200)  NULL,
	[PLZ] [nvarchar](10)  NOT NULL,
	[Ort] [nvarchar](100)  NULL,
	[Land] [nvarchar](50)  NULL
)
GO
SET IDENTITY_INSERT [Kunden] ON;
INSERT [Kunden] ([ID], [Kundenname], [Adresse], [PLZ], [Ort], [Land]) VALUES (1, N'Accent', N'Kremserstraße 1', N'2000', N'Krems', N'AT');
INSERT [Kunden] ([ID], [Kundenname], [Adresse], [PLZ], [Ort], [Land]) VALUES (2, N'Susanne Dobler', N'Leopoldgasse', N'3400', N'Klosterneuburg', N'AT');
INSERT [Kunden] ([ID], [Kundenname], [Adresse], [PLZ], [Ort], [Land]) VALUES (3, N'Bernhard', N'Bernhardstraße 1', N'1190', N'Wien', N'AT');
SET IDENTITY_INSERT [Kunden] OFF;
GO
CREATE TABLE [Icons](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[IconFile] [nvarchar](200)  NOT NULL
)
GO
SET IDENTITY_INSERT [Icons] ON;
INSERT [Icons] ([ID], [IconFile]) VALUES (1, N'app.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (2, N'Code_ClassCS.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (3, N'VSProject_genericproject.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (4, N'Resource_Bitmap.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (5, N'user.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (6, N'users.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (7, N'propertiesORoptions.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (8, N'UtilityText.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (9, N'otheroptions.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (10, N'cab.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (11, N'Code_Component.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (12, N'document.ico');
INSERT [Icons] ([ID], [IconFile]) VALUES (13, N'idr_dll.ico');
SET IDENTITY_INSERT [Icons] OFF;
GO
CREATE TABLE [Assemblies](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[fk_Module] [int] NOT NULL,
	[AssemblyName] [nvarchar](200)  NOT NULL
)
GO
SET IDENTITY_INSERT [Assemblies] ON;
INSERT [Assemblies] ([ID], [fk_Module], [AssemblyName]) VALUES (1, 1, N'Kistl.App.Projekte.Client');
INSERT [Assemblies] ([ID], [fk_Module], [AssemblyName]) VALUES (2, 1, N'Kistl.App.Projekte.Server');
SET IDENTITY_INSERT [Assemblies] OFF;
GO
CREATE TABLE [Mitarbeiter](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](100)  NULL,
	[Geburtstag] [datetime] NULL,
	[SVNr] [nvarchar](20)  NULL,
	[TelefonNummer] [nvarchar](50)  NULL
)
GO
SET IDENTITY_INSERT [Mitarbeiter] ON;
INSERT [Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (1, N'DI David Schmitt', NULL, NULL, NULL);
INSERT [Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (2, N'Arthur Zaczek', NULL, NULL, NULL);
INSERT [Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (3, N'Susanne Dobler', NULL, NULL, NULL);
INSERT [Mitarbeiter] ([ID], [Name], [Geburtstag], [SVNr], [TelefonNummer]) VALUES (4, N'Josef Pfleger', NULL, NULL, NULL);
SET IDENTITY_INSERT [Mitarbeiter] OFF;
GO
CREATE TABLE [Projekte](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](100)  NULL,
	[fk_Mitarbeiter] [int] NULL,
	[AufwandGes] [float] NULL,
	[Kundenname] [nvarchar](100)  NULL
)
GO
SET IDENTITY_INSERT [Projekte] ON;
INSERT [Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes], [Kundenname]) VALUES (1, N'Kistl', 1, 20, N'Wir selbst');
INSERT [Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes], [Kundenname]) VALUES (2, N'Ziviltechniker', 3, 235, NULL);
INSERT [Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes], [Kundenname]) VALUES (3, N'WebCMS.net V1.0', 4, 0, NULL);
INSERT [Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes], [Kundenname]) VALUES (4, N'Rechnungswesen', 2, 100, NULL);
INSERT [Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes], [Kundenname]) VALUES (5, N'Neues Projekt', 1, 100, NULL);
INSERT [Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes], [Kundenname]) VALUES (6, N'test_abc', 1, 100, NULL);
INSERT [Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes], [Kundenname]) VALUES (7, N'Neues Objekt', 2, 100, NULL);
INSERT [Projekte] ([ID], [Name], [fk_Mitarbeiter], [AufwandGes], [Kundenname]) VALUES (12, N'Neues Projekt im Context', NULL, 103, NULL);
SET IDENTITY_INSERT [Projekte] OFF;
GO
CREATE TABLE [Properties](
	[ID] [int] NOT NULL PRIMARY KEY,
	[IsNullable] [bit] NULL,
	[IsList] [bit] NULL
)
GO
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (1, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (3, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (8, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (9, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (11, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (13, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (15, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (16, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (17, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (18, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (19, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (20, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (22, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (23, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (25, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (26, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (28, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (29, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (30, 1, NULL);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (38, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (39, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (40, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (41, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (42, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (43, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (45, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (46, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (47, 1, 1);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (48, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (49, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (50, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (51, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (52, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (53, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (54, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (55, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (56, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (57, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (59, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (60, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (61, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (62, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (63, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (64, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (65, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (68, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (69, 1, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (70, 0, 0);
INSERT [Properties] ([ID], [IsNullable], [IsList]) VALUES (71, 0, 0);
GO
CREATE TABLE [ValueTypeProperties](
	[ID] [int] NOT NULL PRIMARY KEY
)
GO
INSERT [ValueTypeProperties] ([ID]) VALUES (1);
INSERT [ValueTypeProperties] ([ID]) VALUES (3);
INSERT [ValueTypeProperties] ([ID]) VALUES (9);
INSERT [ValueTypeProperties] ([ID]) VALUES (11);
INSERT [ValueTypeProperties] ([ID]) VALUES (13);
INSERT [ValueTypeProperties] ([ID]) VALUES (15);
INSERT [ValueTypeProperties] ([ID]) VALUES (16);
INSERT [ValueTypeProperties] ([ID]) VALUES (17);
INSERT [ValueTypeProperties] ([ID]) VALUES (18);
INSERT [ValueTypeProperties] ([ID]) VALUES (20);
INSERT [ValueTypeProperties] ([ID]) VALUES (23);
INSERT [ValueTypeProperties] ([ID]) VALUES (26);
INSERT [ValueTypeProperties] ([ID]) VALUES (28);
INSERT [ValueTypeProperties] ([ID]) VALUES (30);
INSERT [ValueTypeProperties] ([ID]) VALUES (35);
INSERT [ValueTypeProperties] ([ID]) VALUES (38);
INSERT [ValueTypeProperties] ([ID]) VALUES (39);
INSERT [ValueTypeProperties] ([ID]) VALUES (40);
INSERT [ValueTypeProperties] ([ID]) VALUES (41);
INSERT [ValueTypeProperties] ([ID]) VALUES (42);
INSERT [ValueTypeProperties] ([ID]) VALUES (43);
INSERT [ValueTypeProperties] ([ID]) VALUES (48);
INSERT [ValueTypeProperties] ([ID]) VALUES (50);
INSERT [ValueTypeProperties] ([ID]) VALUES (52);
INSERT [ValueTypeProperties] ([ID]) VALUES (56);
INSERT [ValueTypeProperties] ([ID]) VALUES (57);
INSERT [ValueTypeProperties] ([ID]) VALUES (59);
INSERT [ValueTypeProperties] ([ID]) VALUES (60);
INSERT [ValueTypeProperties] ([ID]) VALUES (61);
INSERT [ValueTypeProperties] ([ID]) VALUES (62);
INSERT [ValueTypeProperties] ([ID]) VALUES (63);
INSERT [ValueTypeProperties] ([ID]) VALUES (65);
INSERT [ValueTypeProperties] ([ID]) VALUES (68);
INSERT [ValueTypeProperties] ([ID]) VALUES (71);
GO
CREATE TABLE [StringProperties](
	[ID] [int] NOT NULL PRIMARY KEY,
	[Length] [int] NULL
)
GO
INSERT [StringProperties] ([ID], [Length]) VALUES (1, 51);
INSERT [StringProperties] ([ID], [Length]) VALUES (3, 100);
INSERT [StringProperties] ([ID], [Length]) VALUES (9, 100);
INSERT [StringProperties] ([ID], [Length]) VALUES (13, 100);
INSERT [StringProperties] ([ID], [Length]) VALUES (15, 100);
INSERT [StringProperties] ([ID], [Length]) VALUES (20, 100);
INSERT [StringProperties] ([ID], [Length]) VALUES (30, 100);
INSERT [StringProperties] ([ID], [Length]) VALUES (39, 20);
INSERT [StringProperties] ([ID], [Length]) VALUES (40, 50);
INSERT [StringProperties] ([ID], [Length]) VALUES (41, 200);
INSERT [StringProperties] ([ID], [Length]) VALUES (42, 200);
INSERT [StringProperties] ([ID], [Length]) VALUES (43, 200);
INSERT [StringProperties] ([ID], [Length]) VALUES (48, 100);
INSERT [StringProperties] ([ID], [Length]) VALUES (50, 200);
INSERT [StringProperties] ([ID], [Length]) VALUES (52, 200);
INSERT [StringProperties] ([ID], [Length]) VALUES (59, 200);
INSERT [StringProperties] ([ID], [Length]) VALUES (60, 200);
INSERT [StringProperties] ([ID], [Length]) VALUES (61, 10);
INSERT [StringProperties] ([ID], [Length]) VALUES (62, 100);
INSERT [StringProperties] ([ID], [Length]) VALUES (63, 50);
INSERT [StringProperties] ([ID], [Length]) VALUES (68, 200);
INSERT [StringProperties] ([ID], [Length]) VALUES (71, 200);
GO
CREATE TABLE [Methods](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[fk_ObjectClass] [int] NULL,
	[MethodName] [nvarchar](100)  NULL
)
GO
SET IDENTITY_INSERT [Methods] ON;
INSERT [Methods] ([ID], [fk_ObjectClass], [MethodName]) VALUES (1, 5, N'GetDataType');
INSERT [Methods] ([ID], [fk_ObjectClass], [MethodName]) VALUES (3, 19, N'RechnungErstellen');
SET IDENTITY_INSERT [Methods] OFF;
GO
CREATE TABLE [BaseProperties](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[fk_ObjectClass] [int] NULL,
	[PropertyName] [nvarchar](100)  NULL,
	[AltText] [nvarchar](200)  NULL
)
GO
SET IDENTITY_INSERT [BaseProperties] ON;
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (1, 2, N'ClassName', N'Der Name der Objektklasse');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (3, 2, N'TableName', N'Tabellenname in der Datenbank');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (7, 2, N'Properties', N'Eigenschaften der Objektklasse');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (8, 5, N'ObjectClass', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (9, 5, N'PropertyName', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (11, 7, N'IsList', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (13, 3, N'Name', N'Projektname');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (14, 3, N'Tasks', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (15, 4, N'Name', N'Taskname');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (16, 4, N'DatumVon', N'Start Datum');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (17, 4, N'DatumBis', N'Enddatum');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (18, 4, N'Aufwand', N'Aufwand in Stunden');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (19, 4, N'Projekt', N'Verknüpfung zum Projekt');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (20, 6, N'Name', N'Vorname Nachname');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (21, 6, N'Projekte', N'Projekte des Mitarbeiters für die er Verantwortlich ist');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (22, 3, N'Mitarbeiter', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (23, 3, N'AufwandGes', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (25, 2, N'BaseObjectClass', N'Pointer auf die Basisklasse');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (26, 7, N'IsNullable', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (27, 2, N'SubClasses', N'Liste der vererbten Klassen');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (28, 9, N'Length', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (29, 10, N'ObjectClass', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (30, 10, N'MethodName', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (31, 2, N'Methods', N'Liste aller Methoden der Objektklasse.');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (38, 6, N'Geburtstag', N'Herzlichen Glückwunsch zum Geburtstag');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (39, 6, N'SVNr', N'NNNN TTMMYY');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (40, 6, N'TelefonNummer', N'+43 123 12345678');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (41, 5, N'AltText', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (42, 18, N'Namespace', N'CLR Namespace des Moduls');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (43, 18, N'ModuleName', N'Name des Moduls');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (44, 18, N'ObjectClasses', N'Ojektklassen des Modules');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (45, 2, N'Module', N'Modul der Objektklasse');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (46, 14, N'ReferenceObjectClass', N'Pointer zur Objektklasse');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (47, 16, N'ReferenceProperty', N'Das Property, welches auf diese Klasse zeigt');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (48, 3, N'Kundenname', N'Bitte geben Sie den Kundennamen ein');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (49, 19, N'Mitarbeiter', NULL);
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (50, 19, N'Auftragsname', N'Bitte füllen Sie einen sprechenden Auftragsnamen aus');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (51, 19, N'Projekt', N'Projekt zum Auftrag');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (52, 20, N'Kontoname', N'Name des Zeiterfassungskontos');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (53, 23, N'Projekt', N'Projekt des Kostenträgers');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (54, 25, N'Mitarbeiter', N'Mitarbeiter');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (55, 25, N'Zeitkonto', N'Zeitkonto');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (56, 25, N'Datum', N'Datum');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (57, 25, N'Dauer', N'Dauer in Stunden');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (58, 20, N'Taetigkeiten', N'Tätigkeiten');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (59, 26, N'Kundenname', N'Name des Kunden');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (60, 26, N'Adresse', N'Adresse & Hausnummer');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (61, 26, N'PLZ', N'Postleitzahl');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (62, 26, N'Ort', N'Ort');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (63, 26, N'Land', N'Land');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (64, 19, N'Kunde', N'Kunde des Projektes');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (65, 19, N'Auftragswert', N'Wert in EUR des Auftrages');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (66, 3, N'Kostentraeger', N'Kostenträger');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (67, 3, N'Auftraege', N'Aufträge');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (68, 27, N'IconFile', N'Filename of the Icon');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (69, 2, N'DefaultIcon', N'Standard Icon wenn IIcon nicht implementiert ist');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (70, 29, N'Module', N'Module');
INSERT [BaseProperties] ([ID], [fk_ObjectClass], [PropertyName], [AltText]) VALUES (71, 29, N'AssemblyName', N'Full Assemblyname eg. MyActions, Version=1.0.0.0');
SET IDENTITY_INSERT [BaseProperties] OFF;
GO
CREATE TABLE [Tasks](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](100)  NULL,
	[DatumVon] [datetime] NULL,
	[DatumBis] [datetime] NULL,
	[Aufwand] [float] NULL,
	[fk_Projekt] [int] NULL
)
GO
SET IDENTITY_INSERT [Tasks] ON;
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (1, N'Planung Ziviltechniker', NULL, NULL, 10, 2);
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (2, N'Umsetzung Ziviltechniker', NULL, NULL, 10, 2);
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (3, N'Planung Kistl', NULL, NULL, 10, 1);
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (5, N'Ein Test2', NULL, NULL, 10, 1);
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (7, N'Neue Aufgabe', NULL, NULL, 10, 6);
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (8, N'Zweite Aufgabe', NULL, NULL, 10, 6);
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (9, N'Buchhaltungsprogramm schreiben', NULL, NULL, 10, 4);
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (10, N'Neuer Task', NULL, NULL, 1, 12);
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (11, N'test', NULL, NULL, 1, 12);
INSERT [Tasks] ([ID], [Name], [DatumVon], [DatumBis], [Aufwand], [fk_Projekt]) VALUES (12, N'test2', NULL, NULL, 101, 12);
SET IDENTITY_INSERT [Tasks] OFF;
GO
