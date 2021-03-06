/*
   Tuesday, April 3, 20188:41:44 PM
   User: 
   Server: DESKTOP-81BC5EE
   Database: AmberAndGrain
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Batches ADD
	Status int NOT NULL CONSTRAINT DF_Batches_Status DEFAULT 0
GO
ALTER TABLE dbo.Batches SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
