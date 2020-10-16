using System;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    public partial class DatabaseManager {
        private void InitOAuth(
            int majorNumber,
            int minorNumber
            ) {
            int sequence = 0;

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = scriptNumber++,
                Name = "OAuthDropTables",
                Description = "OAuth Drop Tables",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
if object_id (N'AspNetUserClaims') is not null
    drop table AspNetUserClaims
if object_id (N'AspNetUserLogins') is not null
    drop table AspNetUserLogins
if object_id (N'AspNetUserRoles') is not null
    drop table AspNetUserRoles
if object_id (N'AspNetUsers') is not null
    drop table AspNetUsers
if object_id (N'AspNetRoles') is not null
    drop table AspNetRoles
if object_id (N'__MigrationHistory') is not null
    drop table __MigrationHistory
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = scriptNumber++,
                Name = "OAuthCreateTables",
                Description = "OAuth Create Tables",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId]    NVARCHAR (150)  NOT NULL,
    [ContextKey]     NVARCHAR (300)  NOT NULL,
    [Model]          VARBINARY (MAX) NOT NULL,
    [ProductVersion] NVARCHAR (32)   NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC, [ContextKey] ASC)
);
go
CREATE TABLE [dbo].[AspNetRoles] (
    [Id]   NVARCHAR (128) NOT NULL,
    [Name] NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED ([Id] ASC)
);
go
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex]
    ON [dbo].[AspNetRoles]([Name] ASC);
go
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [UserId]     NVARCHAR (128) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED ([Id] ASC)
);
go
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[AspNetUserClaims]([UserId] ASC);
go
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] NVARCHAR (128) NOT NULL,
    [ProviderKey]   NVARCHAR (128) NOT NULL,
    [UserId]        NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED ([LoginProvider] ASC, [ProviderKey] ASC, [UserId] ASC)
);
go
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[AspNetUserLogins]([UserId] ASC);
go
CREATE TABLE [dbo].[AspNetUserRoles] (
    [UserId] NVARCHAR (128) NOT NULL,
    [RoleId] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC)
);
go
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[AspNetUserRoles]([UserId] ASC);
go
CREATE NONCLUSTERED INDEX [IX_RoleId]
    ON [dbo].[AspNetUserRoles]([RoleId] ASC);
go
CREATE TABLE [dbo].[AspNetUsers] (
    [Id]                   NVARCHAR (128) NOT NULL,
    [Email]                NVARCHAR (256) NULL,
    [EmailConfirmed]       BIT            NOT NULL,
    [PasswordHash]         NVARCHAR (MAX) NULL,
    [SecurityStamp]        NVARCHAR (MAX) NULL,
    [PhoneNumber]          NVARCHAR (MAX) NULL,
    [PhoneNumberConfirmed] BIT            NOT NULL,
    [TwoFactorEnabled]     BIT            NOT NULL,
    [LockoutEndDateUtc]    DATETIME       NULL,
    [LockoutEnabled]       BIT            NOT NULL,
    [AccessFailedCount]    INT            NOT NULL,
    [UserName]             NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
);
go
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[AspNetUsers]([UserName] ASC);
go
ALTER TABLE [dbo].[AspNetUserClaims] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE;
go
ALTER TABLE [dbo].[AspNetUserLogins] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE;
go
ALTER TABLE [dbo].[AspNetUserRoles] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE;
go
ALTER TABLE [dbo].[AspNetUserRoles] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE;
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = scriptNumber++,
                Name = "OAuthTestData",
                Description = "OAuth Test Data",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
set nocount on
go
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }
    }
}
