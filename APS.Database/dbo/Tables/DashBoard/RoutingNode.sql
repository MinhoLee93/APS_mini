﻿CREATE TABLE [dbo].[RoutingNode]
(
	[Id] INT NOT NULL Identity(1,1) PRIMARY KEY,
	[RID] NVarChar(25) NOT NULL,
	[SourceWID] INT NOT NULL,
	[X] INT NULL,
	[Y] INT NULL
)
