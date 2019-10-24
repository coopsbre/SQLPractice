USE [WorkOrderLog]
GO

/****** Object:  Table [dbo].[ScriptFile]    Script Date: 10/24/2019 20:45:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ScriptFile](
	[ScriptFileID] [int] IDENTITY(1,1) NOT NULL,
	[ScriptFileName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_ScriptFile] PRIMARY KEY CLUSTERED 
(
	[ScriptFileID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

