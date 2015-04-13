
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/09/2015 13:57:51
-- Generated from EDMX file: C:\Users\Felix\Sylvaine\ProjetSylvain\Backend\EntitySchema.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [sylvain];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EtudiantCoordonnees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EtudiantSet] DROP CONSTRAINT [FK_EtudiantCoordonnees];
GO
IF OBJECT_ID(N'[dbo].[FK_LoginEtudiant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EtudiantSet] DROP CONSTRAINT [FK_LoginEtudiant];
GO
IF OBJECT_ID(N'[dbo].[FK_InscriptionEtudiant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscriptionSet] DROP CONSTRAINT [FK_InscriptionEtudiant];
GO
IF OBJECT_ID(N'[dbo].[FK_CoursProfesseur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CoursSet] DROP CONSTRAINT [FK_CoursProfesseur];
GO
IF OBJECT_ID(N'[dbo].[FK_CoursSujet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CoursSet] DROP CONSTRAINT [FK_CoursSujet];
GO
IF OBJECT_ID(N'[dbo].[FK_CoordonneesProfesseur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesseurSet] DROP CONSTRAINT [FK_CoordonneesProfesseur];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesseurSujet_Professeur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesseurSujet] DROP CONSTRAINT [FK_ProfesseurSujet_Professeur];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesseurSujet_Sujet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesseurSujet] DROP CONSTRAINT [FK_ProfesseurSujet_Sujet];
GO
IF OBJECT_ID(N'[dbo].[FK_CoursCoursHoraire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CoursHoraireSet] DROP CONSTRAINT [FK_CoursCoursHoraire];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesseurProfesseurHoraire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesseurHoraireSet] DROP CONSTRAINT [FK_ProfesseurProfesseurHoraire];
GO
IF OBJECT_ID(N'[dbo].[FK_CoursHoraireJour]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CoursHoraireSet] DROP CONSTRAINT [FK_CoursHoraireJour];
GO
IF OBJECT_ID(N'[dbo].[FK_CoursHoraireHeure]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CoursHoraireSet] DROP CONSTRAINT [FK_CoursHoraireHeure];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesseurHoraireHeure]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesseurHoraireSet] DROP CONSTRAINT [FK_ProfesseurHoraireHeure];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesseurHoraireJour]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesseurHoraireSet] DROP CONSTRAINT [FK_ProfesseurHoraireJour];
GO
IF OBJECT_ID(N'[dbo].[FK_CoursInscription]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscriptionSet] DROP CONSTRAINT [FK_CoursInscription];
GO
IF OBJECT_ID(N'[dbo].[FK_PaiementInscription]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PaiementSet] DROP CONSTRAINT [FK_PaiementInscription];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EtudiantSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EtudiantSet];
GO
IF OBJECT_ID(N'[dbo].[LoginSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoginSet];
GO
IF OBJECT_ID(N'[dbo].[PaiementSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PaiementSet];
GO
IF OBJECT_ID(N'[dbo].[InscriptionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscriptionSet];
GO
IF OBJECT_ID(N'[dbo].[ProfesseurSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfesseurSet];
GO
IF OBJECT_ID(N'[dbo].[SujetSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SujetSet];
GO
IF OBJECT_ID(N'[dbo].[CoursSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CoursSet];
GO
IF OBJECT_ID(N'[dbo].[CoordonneesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CoordonneesSet];
GO
IF OBJECT_ID(N'[dbo].[ProfesseurHoraireSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfesseurHoraireSet];
GO
IF OBJECT_ID(N'[dbo].[CoursHoraireSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CoursHoraireSet];
GO
IF OBJECT_ID(N'[dbo].[HeureSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HeureSet];
GO
IF OBJECT_ID(N'[dbo].[JourSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JourSet];
GO
IF OBJECT_ID(N'[dbo].[ProfesseurSujet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfesseurSujet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EtudiantSet'
CREATE TABLE [dbo].[EtudiantSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Coordonnees_Id] int  NOT NULL,
    [Login_Id] int  NOT NULL
);
GO

-- Creating table 'LoginSet'
CREATE TABLE [dbo].[LoginSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Mot_de_Passe] nvarchar(max)  NOT NULL,
    [IsAdmin] bit  NOT NULL
);
GO

-- Creating table 'PaiementSet'
CREATE TABLE [dbo].[PaiementSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TimeStamp] datetime  NOT NULL,
    [Montant] decimal(18,6)  NOT NULL,
    [Rembourse] bit  NOT NULL,
    [Inscription_Id] int  NOT NULL
);
GO

-- Creating table 'InscriptionSet'
CREATE TABLE [dbo].[InscriptionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Annule] bit  NOT NULL,
    [Etudiant_Id] int  NOT NULL,
    [Cours_Id] int  NOT NULL
);
GO

-- Creating table 'ProfesseurSet'
CREATE TABLE [dbo].[ProfesseurSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Anciennete] int  NOT NULL,
    [Coordonnees_Id] int  NOT NULL
);
GO

-- Creating table 'SujetSet'
CREATE TABLE [dbo].[SujetSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CoursSet'
CREATE TABLE [dbo].[CoursSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ouvert] bit  NOT NULL,
    [Cout] decimal(18,6)  NOT NULL,
    [DateLimite] datetime  NOT NULL,
    [Professeur_Id] int  NULL,
    [Sujet_Id] int  NOT NULL
);
GO

-- Creating table 'CoordonneesSet'
CREATE TABLE [dbo].[CoordonneesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Telephone] nvarchar(max)  NOT NULL,
    [Adresse] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProfesseurHoraireSet'
CREATE TABLE [dbo].[ProfesseurHoraireSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Actif] bit  NOT NULL,
    [Professeur_Id] int  NOT NULL,
    [Heure_Id] int  NOT NULL,
    [Jour_Id] int  NOT NULL
);
GO

-- Creating table 'CoursHoraireSet'
CREATE TABLE [dbo].[CoursHoraireSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Actif] bit  NOT NULL,
    [Cours_Id] int  NOT NULL,
    [Jour_Id] int  NOT NULL,
    [Heure_Id] int  NOT NULL
);
GO

-- Creating table 'HeureSet'
CREATE TABLE [dbo].[HeureSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Num] int  NOT NULL
);
GO

-- Creating table 'JourSet'
CREATE TABLE [dbo].[JourSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Num] int  NOT NULL,
    [NomLong] nvarchar(max)  NOT NULL,
    [NomCourt] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProfesseurSujet'
CREATE TABLE [dbo].[ProfesseurSujet] (
    [Professeur_Id] int  NOT NULL,
    [Sujet_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EtudiantSet'
ALTER TABLE [dbo].[EtudiantSet]
ADD CONSTRAINT [PK_EtudiantSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LoginSet'
ALTER TABLE [dbo].[LoginSet]
ADD CONSTRAINT [PK_LoginSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PaiementSet'
ALTER TABLE [dbo].[PaiementSet]
ADD CONSTRAINT [PK_PaiementSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InscriptionSet'
ALTER TABLE [dbo].[InscriptionSet]
ADD CONSTRAINT [PK_InscriptionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProfesseurSet'
ALTER TABLE [dbo].[ProfesseurSet]
ADD CONSTRAINT [PK_ProfesseurSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SujetSet'
ALTER TABLE [dbo].[SujetSet]
ADD CONSTRAINT [PK_SujetSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CoursSet'
ALTER TABLE [dbo].[CoursSet]
ADD CONSTRAINT [PK_CoursSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CoordonneesSet'
ALTER TABLE [dbo].[CoordonneesSet]
ADD CONSTRAINT [PK_CoordonneesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProfesseurHoraireSet'
ALTER TABLE [dbo].[ProfesseurHoraireSet]
ADD CONSTRAINT [PK_ProfesseurHoraireSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CoursHoraireSet'
ALTER TABLE [dbo].[CoursHoraireSet]
ADD CONSTRAINT [PK_CoursHoraireSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HeureSet'
ALTER TABLE [dbo].[HeureSet]
ADD CONSTRAINT [PK_HeureSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JourSet'
ALTER TABLE [dbo].[JourSet]
ADD CONSTRAINT [PK_JourSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Professeur_Id], [Sujet_Id] in table 'ProfesseurSujet'
ALTER TABLE [dbo].[ProfesseurSujet]
ADD CONSTRAINT [PK_ProfesseurSujet]
    PRIMARY KEY CLUSTERED ([Professeur_Id], [Sujet_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Coordonnees_Id] in table 'EtudiantSet'
ALTER TABLE [dbo].[EtudiantSet]
ADD CONSTRAINT [FK_EtudiantCoordonnees]
    FOREIGN KEY ([Coordonnees_Id])
    REFERENCES [dbo].[CoordonneesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EtudiantCoordonnees'
CREATE INDEX [IX_FK_EtudiantCoordonnees]
ON [dbo].[EtudiantSet]
    ([Coordonnees_Id]);
GO

-- Creating foreign key on [Login_Id] in table 'EtudiantSet'
ALTER TABLE [dbo].[EtudiantSet]
ADD CONSTRAINT [FK_LoginEtudiant]
    FOREIGN KEY ([Login_Id])
    REFERENCES [dbo].[LoginSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginEtudiant'
CREATE INDEX [IX_FK_LoginEtudiant]
ON [dbo].[EtudiantSet]
    ([Login_Id]);
GO

-- Creating foreign key on [Etudiant_Id] in table 'InscriptionSet'
ALTER TABLE [dbo].[InscriptionSet]
ADD CONSTRAINT [FK_InscriptionEtudiant]
    FOREIGN KEY ([Etudiant_Id])
    REFERENCES [dbo].[EtudiantSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscriptionEtudiant'
CREATE INDEX [IX_FK_InscriptionEtudiant]
ON [dbo].[InscriptionSet]
    ([Etudiant_Id]);
GO

-- Creating foreign key on [Professeur_Id] in table 'CoursSet'
ALTER TABLE [dbo].[CoursSet]
ADD CONSTRAINT [FK_CoursProfesseur]
    FOREIGN KEY ([Professeur_Id])
    REFERENCES [dbo].[ProfesseurSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoursProfesseur'
CREATE INDEX [IX_FK_CoursProfesseur]
ON [dbo].[CoursSet]
    ([Professeur_Id]);
GO

-- Creating foreign key on [Sujet_Id] in table 'CoursSet'
ALTER TABLE [dbo].[CoursSet]
ADD CONSTRAINT [FK_CoursSujet]
    FOREIGN KEY ([Sujet_Id])
    REFERENCES [dbo].[SujetSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoursSujet'
CREATE INDEX [IX_FK_CoursSujet]
ON [dbo].[CoursSet]
    ([Sujet_Id]);
GO

-- Creating foreign key on [Coordonnees_Id] in table 'ProfesseurSet'
ALTER TABLE [dbo].[ProfesseurSet]
ADD CONSTRAINT [FK_CoordonneesProfesseur]
    FOREIGN KEY ([Coordonnees_Id])
    REFERENCES [dbo].[CoordonneesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoordonneesProfesseur'
CREATE INDEX [IX_FK_CoordonneesProfesseur]
ON [dbo].[ProfesseurSet]
    ([Coordonnees_Id]);
GO

-- Creating foreign key on [Professeur_Id] in table 'ProfesseurSujet'
ALTER TABLE [dbo].[ProfesseurSujet]
ADD CONSTRAINT [FK_ProfesseurSujet_Professeur]
    FOREIGN KEY ([Professeur_Id])
    REFERENCES [dbo].[ProfesseurSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Sujet_Id] in table 'ProfesseurSujet'
ALTER TABLE [dbo].[ProfesseurSujet]
ADD CONSTRAINT [FK_ProfesseurSujet_Sujet]
    FOREIGN KEY ([Sujet_Id])
    REFERENCES [dbo].[SujetSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfesseurSujet_Sujet'
CREATE INDEX [IX_FK_ProfesseurSujet_Sujet]
ON [dbo].[ProfesseurSujet]
    ([Sujet_Id]);
GO

-- Creating foreign key on [Cours_Id] in table 'CoursHoraireSet'
ALTER TABLE [dbo].[CoursHoraireSet]
ADD CONSTRAINT [FK_CoursCoursHoraire]
    FOREIGN KEY ([Cours_Id])
    REFERENCES [dbo].[CoursSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoursCoursHoraire'
CREATE INDEX [IX_FK_CoursCoursHoraire]
ON [dbo].[CoursHoraireSet]
    ([Cours_Id]);
GO

-- Creating foreign key on [Professeur_Id] in table 'ProfesseurHoraireSet'
ALTER TABLE [dbo].[ProfesseurHoraireSet]
ADD CONSTRAINT [FK_ProfesseurProfesseurHoraire]
    FOREIGN KEY ([Professeur_Id])
    REFERENCES [dbo].[ProfesseurSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfesseurProfesseurHoraire'
CREATE INDEX [IX_FK_ProfesseurProfesseurHoraire]
ON [dbo].[ProfesseurHoraireSet]
    ([Professeur_Id]);
GO

-- Creating foreign key on [Jour_Id] in table 'CoursHoraireSet'
ALTER TABLE [dbo].[CoursHoraireSet]
ADD CONSTRAINT [FK_CoursHoraireJour]
    FOREIGN KEY ([Jour_Id])
    REFERENCES [dbo].[JourSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoursHoraireJour'
CREATE INDEX [IX_FK_CoursHoraireJour]
ON [dbo].[CoursHoraireSet]
    ([Jour_Id]);
GO

-- Creating foreign key on [Heure_Id] in table 'CoursHoraireSet'
ALTER TABLE [dbo].[CoursHoraireSet]
ADD CONSTRAINT [FK_CoursHoraireHeure]
    FOREIGN KEY ([Heure_Id])
    REFERENCES [dbo].[HeureSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoursHoraireHeure'
CREATE INDEX [IX_FK_CoursHoraireHeure]
ON [dbo].[CoursHoraireSet]
    ([Heure_Id]);
GO

-- Creating foreign key on [Heure_Id] in table 'ProfesseurHoraireSet'
ALTER TABLE [dbo].[ProfesseurHoraireSet]
ADD CONSTRAINT [FK_ProfesseurHoraireHeure]
    FOREIGN KEY ([Heure_Id])
    REFERENCES [dbo].[HeureSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfesseurHoraireHeure'
CREATE INDEX [IX_FK_ProfesseurHoraireHeure]
ON [dbo].[ProfesseurHoraireSet]
    ([Heure_Id]);
GO

-- Creating foreign key on [Jour_Id] in table 'ProfesseurHoraireSet'
ALTER TABLE [dbo].[ProfesseurHoraireSet]
ADD CONSTRAINT [FK_ProfesseurHoraireJour]
    FOREIGN KEY ([Jour_Id])
    REFERENCES [dbo].[JourSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfesseurHoraireJour'
CREATE INDEX [IX_FK_ProfesseurHoraireJour]
ON [dbo].[ProfesseurHoraireSet]
    ([Jour_Id]);
GO

-- Creating foreign key on [Cours_Id] in table 'InscriptionSet'
ALTER TABLE [dbo].[InscriptionSet]
ADD CONSTRAINT [FK_CoursInscription]
    FOREIGN KEY ([Cours_Id])
    REFERENCES [dbo].[CoursSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoursInscription'
CREATE INDEX [IX_FK_CoursInscription]
ON [dbo].[InscriptionSet]
    ([Cours_Id]);
GO

-- Creating foreign key on [Inscription_Id] in table 'PaiementSet'
ALTER TABLE [dbo].[PaiementSet]
ADD CONSTRAINT [FK_PaiementInscription]
    FOREIGN KEY ([Inscription_Id])
    REFERENCES [dbo].[InscriptionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaiementInscription'
CREATE INDEX [IX_FK_PaiementInscription]
ON [dbo].[PaiementSet]
    ([Inscription_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

USE [sylvain]
GO
SET IDENTITY_INSERT [dbo].[LoginSet] ON 

INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (2, N'Shu', N'Shu', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (3, N'Saumon', N'Saumon', 1)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (4, N'Chuck', N'Chuck', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (5, N'Felix', N'Felix', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (6, N'Karthus', N'Karthus', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (7, N'VoliBear', N'VoliBear', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (8, N'Nidalie', N'Nidalie', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (9, N'Rengar', N'Rengar', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (10, N'Ishtoushe', N'Ishtoushe', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (11, N'Bob', N'Bob', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (12, N'Ginette', N'Ginette', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (13, N'Lilly', N'Lilly', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (14, N'Animals', N'Animals', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (15, N'Maretin', N'Maretin', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (16, N'Dagata', N'Dagata', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (17, N'Ronald', N'Ronald', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (18, N'Graves', N'Graves', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (19, N'Nyan', N'Nyan', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (20, N'Miam', N'Miam', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (22, N'Pu', N'Pu', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (23, N'Soundy', N'Soundy', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (24, N'Kolpolol', N'Kolpolol', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (25, N'Nino', N'Nino', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (26, N'Francoise', N'Francoise', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (27, N'Flora', N'Flora', 0)
INSERT [dbo].[LoginSet] ([Id], [Code], [Mot_de_Passe], [IsAdmin]) VALUES (28, N'Founa', N'Founa', 0)
SET IDENTITY_INSERT [dbo].[LoginSet] OFF
SET IDENTITY_INSERT [dbo].[CoordonneesSet] ON 

INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (1, N'Tremblay', N'Sylvain', N'514-888-4436', N'2058 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (2, N'Nio', N'Anto', N'514-778-5486', N'2504 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (3, N'Blay', N'Stephanie', N'514-789-4568', N'4560 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (4, N'Brunet', N'Dany', N'514-654-8963', N'6548 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (6, N'Boss', N'Tonio', N'514-879-4523', N'6549 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (8, N'Fleur', N'Shu', N'514-666-6666', N'1236 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (9, N'Aumont', N'Saumon', N'514-889-4348', N'2046 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (10, N'Farmer', N'Chuck', N'514-321-1597', N'1236 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (11, N'Jean-Coutu', N'Felix', N'514-988-1536', N'3657 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (12, N'Dufour', N'Karthus', N'514-123-3689', N'1458 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (13, N'Tremblay', N'VoliBear', N'514-785-1548', N'1523 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (14, N'DesChamp', N'Nidalie', N'514-875-6325', N'1470 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (15, N'Sneaky', N'Rengar', N'514-236-6574', N'1489 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (16, N'Lapoche', N'Ishtoushe', N'514-632-4852', N'3584 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (18, N'Robert', N'Bob', N'514-745-568', N'3269 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (19, N'GayTemps', N'Ginette', N'514-548-6541', N'8456 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (20, N'Johnson', N'Lilly', N'514-123-4587', N'9513 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (21, N'AsLeaders', N'Animals', N'514-268-9871', N'6259 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (22, N'Arnolde', N'Maretin', N'450-365-9516', N'3578 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (23, N'Chris', N'Dagata', N'450-621-4789', N'6259 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (24, N'McDonald', N'Ronald', N'514-287-4377', N'7845 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (25, N'Latombe', N'Graves', N'514-896-6666', N'6665 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (26, N'Cat', N'Nyan', N'514-879-6253', N'5183 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (27, N'Dog', N'Miam', N'514-357-8963', N'6542 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (28, N'Didee', N'Pu', N'514-7892-9487', N'3216 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (29, N'Blaster', N'Soundy', N'514-3456-7418', N'3654 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (30, N'lolpolkol', N'kolpolol', N'514-784-3218', N'5162 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (31, N'Guglia', N'Nino', N'514-9876-3264', N'6254 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (32, N'Marceau', N'Francoise', N'514-784-9637', N'1463 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (33, N'Florix', N'Flora', N'514-302-0248', N'1500 St-Hubert')
INSERT [dbo].[CoordonneesSet] ([Id], [Nom], [Prenom], [Telephone], [Adresse]) VALUES (34, N'Faunix', N'Founa', N'514-872-3548', N'1200 St-Hubert')
SET IDENTITY_INSERT [dbo].[CoordonneesSet] OFF
SET IDENTITY_INSERT [dbo].[EtudiantSet] ON 

INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (1, 8, 2)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (2, 9, 3)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (3, 10, 4)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (4, 11, 5)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (5, 12, 6)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (6, 13, 7)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (7, 14, 8)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (8, 15, 9)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (9, 16, 10)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (11, 18, 11)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (12, 19, 12)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (13, 20, 13)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (14, 21, 14)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (15, 22, 15)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (16, 23, 16)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (17, 24, 17)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (18, 25, 18)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (19, 26, 19)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (20, 27, 20)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (21, 28, 22)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (22, 29, 23)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (23, 30, 24)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (24, 31, 25)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (25, 32, 26)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (26, 33, 27)
INSERT [dbo].[EtudiantSet] ([Id], [Coordonnees_Id], [Login_Id]) VALUES (27, 34, 28)
SET IDENTITY_INSERT [dbo].[EtudiantSet] OFF
SET IDENTITY_INSERT [dbo].[ProfesseurSet] ON 

INSERT [dbo].[ProfesseurSet] ([Id], [Anciennete], [Coordonnees_Id]) VALUES (3, 5, 1)
INSERT [dbo].[ProfesseurSet] ([Id], [Anciennete], [Coordonnees_Id]) VALUES (4, 10, 2)
INSERT [dbo].[ProfesseurSet] ([Id], [Anciennete], [Coordonnees_Id]) VALUES (5, 7, 3)
INSERT [dbo].[ProfesseurSet] ([Id], [Anciennete], [Coordonnees_Id]) VALUES (6, 8, 4)
INSERT [dbo].[ProfesseurSet] ([Id], [Anciennete], [Coordonnees_Id]) VALUES (9, 15, 6)
SET IDENTITY_INSERT [dbo].[ProfesseurSet] OFF
SET IDENTITY_INSERT [dbo].[SujetSet] ON 

INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (1, N'Francais')
INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (2, N'Anglais')
INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (3, N'Histoire')
INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (4, N'Gym')
INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (5, N'Science')
INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (6, N'Math')
INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (7, N'Math Pour les Nulls')
INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (8, N'InfoGraphie')
INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (9, N'Yoga')
INSERT [dbo].[SujetSet] ([Id], [Nom]) VALUES (10, N'Conduite sur Chaise roulante')
SET IDENTITY_INSERT [dbo].[SujetSet] OFF
SET IDENTITY_INSERT [dbo].[CoursSet] ON 

INSERT [dbo].[CoursSet] ([Id], [Ouvert], [Cout], [DateLimite], [Professeur_Id], [Sujet_Id]) VALUES (1, 1, CAST(160.000000 AS Decimal(18, 6)), CAST(0x0000A48B00000000 AS DateTime), 3, 1)
INSERT [dbo].[CoursSet] ([Id], [Ouvert], [Cout], [DateLimite], [Professeur_Id], [Sujet_Id]) VALUES (3, 1, CAST(90.000000 AS Decimal(18, 6)), CAST(0x0000A4BC00000000 AS DateTime), 5, 7)
INSERT [dbo].[CoursSet] ([Id], [Ouvert], [Cout], [DateLimite], [Professeur_Id], [Sujet_Id]) VALUES (4, 0, CAST(99.000000 AS Decimal(18, 6)), CAST(0x0000A4CC00000000 AS DateTime), 9, 8)
SET IDENTITY_INSERT [dbo].[CoursSet] OFF
SET IDENTITY_INSERT [dbo].[InscriptionSet] ON 

INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (2, 0, 1, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (3, 0, 2, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (4, 0, 3, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (5, 0, 4, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (6, 0, 5, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (7, 0, 6, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (8, 0, 7, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (9, 0, 8, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (10, 0, 9, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (12, 0, 11, 1)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (14, 0, 12, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (15, 0, 13, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (16, 0, 14, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (17, 0, 15, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (18, 0, 16, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (19, 0, 17, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (20, 0, 18, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (21, 0, 19, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (22, 0, 20, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (23, 0, 21, 3)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (24, 1, 22, 4)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (25, 1, 23, 4)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (26, 1, 24, 4)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (27, 1, 25, 4)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (28, 1, 26, 4)
INSERT [dbo].[InscriptionSet] ([Id], [Annule], [Etudiant_Id], [Cours_Id]) VALUES (29, 1, 27, 4)
SET IDENTITY_INSERT [dbo].[InscriptionSet] OFF
SET IDENTITY_INSERT [dbo].[PaiementSet] ON 

INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (1, CAST(0x0000A43200000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 2)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (3, CAST(0x0000A43300000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 3)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (4, CAST(0x0000A43400000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 4)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (5, CAST(0x0000A43500000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 5)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (6, CAST(0x0000A43600000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 6)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (7, CAST(0x0000A43700000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 7)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (8, CAST(0x0000A43800000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 8)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (9, CAST(0x0000A43900000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 9)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (10, CAST(0x0000A43A00000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 10)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (11, CAST(0x0000A43B00000000 AS DateTime), CAST(16.000000 AS Decimal(18, 6)), 0, 12)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (12, CAST(0x0000A44E00000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 14)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (13, CAST(0x0000A44E00000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 15)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (14, CAST(0x0000A44F00000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 16)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (15, CAST(0x0000A45000000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 17)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (16, CAST(0x0000A45100000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 18)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (17, CAST(0x0000A45200000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 19)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (18, CAST(0x0000A45200000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 20)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (19, CAST(0x0000A45300000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 21)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (20, CAST(0x0000A45400000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 22)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (21, CAST(0x0000A45500000000 AS DateTime), CAST(9.000000 AS Decimal(18, 6)), 0, 23)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (22, CAST(0x0000A46D00000000 AS DateTime), CAST(9.900000 AS Decimal(18, 6)), 1, 24)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (23, CAST(0x0000A46E00000000 AS DateTime), CAST(9.900000 AS Decimal(18, 6)), 1, 25)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (24, CAST(0x0000A46F00000000 AS DateTime), CAST(9.900000 AS Decimal(18, 6)), 1, 26)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (25, CAST(0x0000A47000000000 AS DateTime), CAST(9.900000 AS Decimal(18, 6)), 1, 27)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (26, CAST(0x0000A47100000000 AS DateTime), CAST(9.900000 AS Decimal(18, 6)), 1, 28)
INSERT [dbo].[PaiementSet] ([Id], [TimeStamp], [Montant], [Rembourse], [Inscription_Id]) VALUES (27, CAST(0x0000A47200000000 AS DateTime), CAST(9.900000 AS Decimal(18, 6)), 1, 29)
SET IDENTITY_INSERT [dbo].[PaiementSet] OFF
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (3, 1)
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (3, 2)
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (4, 3)
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (9, 4)
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (5, 5)
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (5, 6)
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (5, 7)
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (9, 8)
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (6, 9)
INSERT [dbo].[ProfesseurSujet] ([Professeur_Id], [Sujet_Id]) VALUES (6, 10)
SET IDENTITY_INSERT [dbo].[HeureSet] ON 

INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (1, 0)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (2, 1)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (3, 2)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (4, 3)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (5, 4)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (6, 5)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (7, 6)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (8, 7)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (9, 8)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (10, 9)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (11, 10)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (12, 11)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (13, 12)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (14, 13)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (15, 14)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (16, 15)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (17, 16)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (18, 17)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (19, 18)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (20, 19)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (21, 20)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (22, 21)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (23, 22)
INSERT [dbo].[HeureSet] ([Id], [Num]) VALUES (24, 23)
SET IDENTITY_INSERT [dbo].[HeureSet] OFF
SET IDENTITY_INSERT [dbo].[JourSet] ON 

INSERT [dbo].[JourSet] ([Id], [Num], [NomLong], [NomCourt]) VALUES (1, 1, N'Lundi', N'Lun')
INSERT [dbo].[JourSet] ([Id], [Num], [NomLong], [NomCourt]) VALUES (2, 2, N'Mardi', N'Mar')
INSERT [dbo].[JourSet] ([Id], [Num], [NomLong], [NomCourt]) VALUES (3, 3, N'Mercredi', N'Mer')
INSERT [dbo].[JourSet] ([Id], [Num], [NomLong], [NomCourt]) VALUES (4, 4, N'Jeudi', N'Jeu')
INSERT [dbo].[JourSet] ([Id], [Num], [NomLong], [NomCourt]) VALUES (5, 5, N'Vendredi', N'Ven')
INSERT [dbo].[JourSet] ([Id], [Num], [NomLong], [NomCourt]) VALUES (6, 6, N'Samedi', N'Sam')
INSERT [dbo].[JourSet] ([Id], [Num], [NomLong], [NomCourt]) VALUES (7, 7, N'Dimanche', N'Dim')
SET IDENTITY_INSERT [dbo].[JourSet] OFF
SET IDENTITY_INSERT [dbo].[ProfesseurHoraireSet] ON 

INSERT [dbo].[ProfesseurHoraireSet] ([Id], [Actif], [Professeur_Id], [Heure_Id], [Jour_Id]) VALUES (1, 1, 3, 4, 1)
INSERT [dbo].[ProfesseurHoraireSet] ([Id], [Actif], [Professeur_Id], [Heure_Id], [Jour_Id]) VALUES (2, 1, 5, 3, 4)
INSERT [dbo].[ProfesseurHoraireSet] ([Id], [Actif], [Professeur_Id], [Heure_Id], [Jour_Id]) VALUES (4, 0, 9, 4, 3)
SET IDENTITY_INSERT [dbo].[ProfesseurHoraireSet] OFF
SET IDENTITY_INSERT [dbo].[CoursHoraireSet] ON 

INSERT [dbo].[CoursHoraireSet] ([Id], [Actif], [Cours_Id], [Jour_Id], [Heure_Id]) VALUES (1, 1, 1, 1, 4)
INSERT [dbo].[CoursHoraireSet] ([Id], [Actif], [Cours_Id], [Jour_Id], [Heure_Id]) VALUES (2, 1, 3, 4, 3)
INSERT [dbo].[CoursHoraireSet] ([Id], [Actif], [Cours_Id], [Jour_Id], [Heure_Id]) VALUES (3, 0, 4, 3, 4)
SET IDENTITY_INSERT [dbo].[CoursHoraireSet] OFF
