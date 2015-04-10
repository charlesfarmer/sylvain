
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