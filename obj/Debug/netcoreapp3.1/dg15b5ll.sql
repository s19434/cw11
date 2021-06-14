IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Administrators] (
    [IdAdministrator] int NOT NULL IDENTITY,
    [FirstName] nvarchar(30) NULL,
    [LastName] nvarchar(30) NULL,
    [BirthDate] datetime2 NOT NULL,
    [Plec] nvarchar(1) NOT NULL,
    [Telefon] nvarchar(12) NULL,
    [PESEL] nvarchar(11) NULL,
    [NumerPaszportu] nvarchar(9) NULL,
    [StawkaGodzinowa] float NOT NULL,
    CONSTRAINT [PK_Administrators] PRIMARY KEY ([IdAdministrator])
);

GO

CREATE TABLE [Treners] (
    [IdTrener] int NOT NULL IDENTITY,
    [FirstName] nvarchar(30) NULL,
    [LastName] nvarchar(30) NULL,
    [BirthDate] datetime2 NOT NULL,
    [Plec] nvarchar(1) NOT NULL,
    [Telefon] nvarchar(12) NULL,
    [PESEL] nvarchar(11) NULL,
    [NumerPaszportu] nvarchar(9) NULL,
    [StawkaGodzinowa] float NOT NULL,
    CONSTRAINT [PK_Treners] PRIMARY KEY ([IdTrener])
);

GO

CREATE TABLE [Programs] (
    [IdProgram] int NOT NULL IDENTITY,
    [Dane] nvarchar(1000) NULL,
    [Ocena] int NOT NULL,
    [IdKlient] int NOT NULL,
    [IdTrener] int NOT NULL,
    [IdUwaga] int NOT NULL,
    CONSTRAINT [PK_Programs] PRIMARY KEY ([IdProgram]),
    CONSTRAINT [FK_Programs_Treners_IdTrener] FOREIGN KEY ([IdTrener]) REFERENCES [Treners] ([IdTrener]) ON DELETE CASCADE
);

GO

CREATE TABLE [Klients] (
    [IdKlient] int NOT NULL IDENTITY,
    [FirstName] nvarchar(30) NULL,
    [LastName] nvarchar(30) NULL,
    [BirthDate] datetime2 NOT NULL,
    [Plec] nvarchar(1) NOT NULL,
    [Telefon] nvarchar(12) NULL,
    [PESEL] nvarchar(11) NULL,
    [NumerPaszportu] nvarchar(9) NULL,
    [KontoBankowe] nvarchar(max) NULL,
    CONSTRAINT [PK_Klients] PRIMARY KEY ([IdKlient]),
    CONSTRAINT [FK_Klients_Programs_IdKlient] FOREIGN KEY ([IdKlient]) REFERENCES [Programs] ([IdProgram]) ON DELETE CASCADE
);

GO

CREATE TABLE [Uwagi] (
    [IdUwaga] int NOT NULL IDENTITY,
    [Opis] nvarchar(500) NULL,
    CONSTRAINT [PK_Uwagi] PRIMARY KEY ([IdUwaga]),
    CONSTRAINT [FK_Uwagi_Programs_IdUwaga] FOREIGN KEY ([IdUwaga]) REFERENCES [Programs] ([IdProgram]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Programs_IdTrener] ON [Programs] ([IdTrener]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210614024816_first', N'3.1.4');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdAdministrator', N'BirthDate', N'FirstName', N'LastName', N'NumerPaszportu', N'PESEL', N'Plec', N'StawkaGodzinowa', N'Telefon') AND [object_id] = OBJECT_ID(N'[Administrators]'))
    SET IDENTITY_INSERT [Administrators] ON;
INSERT INTO [Administrators] ([IdAdministrator], [BirthDate], [FirstName], [LastName], [NumerPaszportu], [PESEL], [Plec], [StawkaGodzinowa], [Telefon])
VALUES (1, '1973-07-25T00:00:00.0000000', N'Ayah', N'Mcdonnell', N'ZE0534979', N'00241377251', N'K', 25.0E0, N'904826683'),
(2, '1978-07-25T00:00:00.0000000', N'Sandy', N'Smith', N'ZE5321833', N'62010793329', N'K', 27.5E0, N'904826683');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdAdministrator', N'BirthDate', N'FirstName', N'LastName', N'NumerPaszportu', N'PESEL', N'Plec', N'StawkaGodzinowa', N'Telefon') AND [object_id] = OBJECT_ID(N'[Administrators]'))
    SET IDENTITY_INSERT [Administrators] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdTrener', N'BirthDate', N'FirstName', N'LastName', N'NumerPaszportu', N'PESEL', N'Plec', N'StawkaGodzinowa', N'Telefon') AND [object_id] = OBJECT_ID(N'[Treners]'))
    SET IDENTITY_INSERT [Treners] ON;
INSERT INTO [Treners] ([IdTrener], [BirthDate], [FirstName], [LastName], [NumerPaszportu], [PESEL], [Plec], [StawkaGodzinowa], [Telefon])
VALUES (1, '1973-07-25T00:00:00.0000000', N'Nigel', N'Hodgson', N'ZE9754217', N'87011172711', N'M', 40.0E0, N'628370610'),
(2, '1985-07-20T00:00:00.0000000', N'Anita', N'Monroe', N'ZE1728081', N'89102665995', N'K', 45.5E0, N'979117677'),
(3, '1978-05-13T00:00:00.0000000', N'Maisie', N'Fowler', N'ZE5747434', N'62082369316', N'K', 35.0E0, N'492947624');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdTrener', N'BirthDate', N'FirstName', N'LastName', N'NumerPaszportu', N'PESEL', N'Plec', N'StawkaGodzinowa', N'Telefon') AND [object_id] = OBJECT_ID(N'[Treners]'))
    SET IDENTITY_INSERT [Treners] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdProgram', N'Dane', N'IdKlient', N'IdTrener', N'IdUwaga', N'Ocena') AND [object_id] = OBJECT_ID(N'[Programs]'))
    SET IDENTITY_INSERT [Programs] ON;
INSERT INTO [Programs] ([IdProgram], [Dane], [IdKlient], [IdTrener], [IdUwaga], [Ocena])
VALUES (1, N'1. Wyciskanie sztangi głową w dół – można zastąpić wyciskanie na ławce płaskiej
2. Podciąganie na drążku, chwyt młotkowy – można zastąpić ściąganiem wyciągu górnego
3. Wyciskanie żołnierskie
4. Przysiad
5. Uginanie ramion ze sztangą łamaną
6. Prostowanie ramion przy wyciągu
7. Ściągnie nóg do klatki przy wyciągu – ćwiczenie na brzuch', 1, 1, 0, 5);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdProgram', N'Dane', N'IdKlient', N'IdTrener', N'IdUwaga', N'Ocena') AND [object_id] = OBJECT_ID(N'[Programs]'))
    SET IDENTITY_INSERT [Programs] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdProgram', N'Dane', N'IdKlient', N'IdTrener', N'IdUwaga', N'Ocena') AND [object_id] = OBJECT_ID(N'[Programs]'))
    SET IDENTITY_INSERT [Programs] ON;
INSERT INTO [Programs] ([IdProgram], [Dane], [IdKlient], [IdTrener], [IdUwaga], [Ocena])
VALUES (2, N'1. Pompki na poręczach
2. Wiosłowanie półsztangą – można zastąpić wiosłowaniem sztangą
3. Unoszenie hantli bokiem
4. Martwy ciąg
5. Podciągnie pochwytem – można zastąpić ściąganiem wyciągu górnego
6. Wyciskanie francuskie za głową
7. Rollout – ćwiczenie na brzuch', 2, 1, 0, 4);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdProgram', N'Dane', N'IdKlient', N'IdTrener', N'IdUwaga', N'Ocena') AND [object_id] = OBJECT_ID(N'[Programs]'))
    SET IDENTITY_INSERT [Programs] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdProgram', N'Dane', N'IdKlient', N'IdTrener', N'IdUwaga', N'Ocena') AND [object_id] = OBJECT_ID(N'[Programs]'))
    SET IDENTITY_INSERT [Programs] ON;
INSERT INTO [Programs] ([IdProgram], [Dane], [IdKlient], [IdTrener], [IdUwaga], [Ocena])
VALUES (3, N'1. Wyciskanie hantli głową w górę
2. Podciąganie na drążku, chwyt szeroki – można zastąpić ściąganiem wyciągu górnego
3. Wyciskanie hantli nad głowę
4. Wypychanie nogami na maszynie
6. Uginanie ramion z liną wyciągu
7. Pompki na triceps
8. Crunch', 3, 3, 1, 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdProgram', N'Dane', N'IdKlient', N'IdTrener', N'IdUwaga', N'Ocena') AND [object_id] = OBJECT_ID(N'[Programs]'))
    SET IDENTITY_INSERT [Programs] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdKlient', N'BirthDate', N'FirstName', N'KontoBankowe', N'LastName', N'NumerPaszportu', N'PESEL', N'Plec', N'Telefon') AND [object_id] = OBJECT_ID(N'[Klients]'))
    SET IDENTITY_INSERT [Klients] ON;
INSERT INTO [Klients] ([IdKlient], [BirthDate], [FirstName], [KontoBankowe], [LastName], [NumerPaszportu], [PESEL], [Plec], [Telefon])
VALUES (1, '1984-05-19T00:00:00.0000000', N'Ayah', N'28461889464437738943448551', N'Mcdonnell', N'ZE4267334', N'97072477841', N'K', N'904826683'),
(2, '1991-04-18T00:00:00.0000000', N'Mehmet', N'50439485639173067302973087', N'Doherty', N'ZE1732550', N'75100148497', N'M', N'072277030'),
(3, '2004-09-13T00:00:00.0000000', N'Macsen', N'40198752755832572842834646', N'George', N'ZE3587822', N'66041366424', N'M', N'377531593');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdKlient', N'BirthDate', N'FirstName', N'KontoBankowe', N'LastName', N'NumerPaszportu', N'PESEL', N'Plec', N'Telefon') AND [object_id] = OBJECT_ID(N'[Klients]'))
    SET IDENTITY_INSERT [Klients] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdUwaga', N'Opis') AND [object_id] = OBJECT_ID(N'[Uwagi]'))
    SET IDENTITY_INSERT [Uwagi] ON;
INSERT INTO [Uwagi] ([IdUwaga], [Opis])
VALUES (1, N'Proszę o przepisaniu treningu ze względu na niedawna kontuzje kolana.');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdUwaga', N'Opis') AND [object_id] = OBJECT_ID(N'[Uwagi]'))
    SET IDENTITY_INSERT [Uwagi] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210614024909_second', N'3.1.4');

GO

