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

