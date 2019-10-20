USE [WorkOrderLog]
GO

/****** Object:  Table [dbo].[WorkOrderScriptHdr]    Script Date: 10/20/2019 18:41:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WorkOrderScriptHdr](
	[WOScriptHdrID] [int] IDENTITY(1,1) NOT NULL,
	[WODtlID] [int] NOT NULL,
	[ScriptFileID] [int] NOT NULL,
 CONSTRAINT [PK_WorkOrderScriptHdr] PRIMARY KEY CLUSTERED 
(
	[WOScriptHdrID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[WorkOrderScriptHdr]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderScriptHdr_ScriptFile] FOREIGN KEY([ScriptFileID])
REFERENCES [dbo].[ScriptFile] ([ScriptFileID])
GO

ALTER TABLE [dbo].[WorkOrderScriptHdr] CHECK CONSTRAINT [FK_WorkOrderScriptHdr_ScriptFile]
GO

ALTER TABLE [dbo].[WorkOrderScriptHdr]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderScriptHdr_WorkOrderDetail] FOREIGN KEY([WODtlID])
REFERENCES [dbo].[WorkOrderDetail] ([WODtlId])
GO

ALTER TABLE [dbo].[WorkOrderScriptHdr] CHECK CONSTRAINT [FK_WorkOrderScriptHdr_WorkOrderDetail]
GO

