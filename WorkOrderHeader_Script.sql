USE [WorkOrderLog]
GO

/****** Object:  Table [dbo].[WorkOrderHeader]    Script Date: 10/22/2019 20:22:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WorkOrderHeader](
	[WOUniqueID] [int] IDENTITY(1,1) NOT NULL,
	[WOHdrID] [int] NOT NULL,
	[ClientCode] [nvarchar](4) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[TestPlanFileID] [int] NOT NULL,
 CONSTRAINT [PK_WorkOrderHeader] PRIMARY KEY CLUSTERED 
(
	[WOHdrID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[WorkOrderHeader]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderHeader_Client] FOREIGN KEY([ClientCode])
REFERENCES [dbo].[Client] ([ClientCode])
GO

ALTER TABLE [dbo].[WorkOrderHeader] CHECK CONSTRAINT [FK_WorkOrderHeader_Client]
GO

ALTER TABLE [dbo].[WorkOrderHeader]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderHeader_TestPlanFile] FOREIGN KEY([TestPlanFileID])
REFERENCES [dbo].[TestPlanFile] ([TestPlanFileID])
GO

ALTER TABLE [dbo].[WorkOrderHeader] CHECK CONSTRAINT [FK_WorkOrderHeader_TestPlanFile]
GO

ALTER TABLE [dbo].[WorkOrderHeader] ADD  CONSTRAINT [DF_WorkOrderHeader_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[WorkOrderHeader] ADD  CONSTRAINT [DF_WorkOrderHeader_ModifiedDate]  DEFAULT (getdate()) FOR [ModifiedDate]
GO

