USE [WorkOrderLog]
GO

/****** Object:  Table [dbo].[ScriptAction]    Script Date: 10/24/2019 20:45:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ScriptAction](
	[SAUniqueID] [smallint] IDENTITY(1,1) NOT NULL,
	[ScriptActionID] [nvarchar](15) NOT NULL,
	[ScriptActionName] [nchar](50) NULL,
 CONSTRAINT [PK_ScriptAction] PRIMARY KEY CLUSTERED 
(
	[ScriptActionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

