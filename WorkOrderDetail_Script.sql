USE [WorkOrderLog]
GO

/****** Object:  Table [dbo].[WorkOrderDetail]    Script Date: 10/20/2019 10:18:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WorkOrderDetail](
	[WODtlId] [int] IDENTITY(1,1) NOT NULL,
	[WOHdrID] [int] NOT NULL,
	[FDNo] [int] NOT NULL,
	[FDDescription] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_WorkOrderDetail] PRIMARY KEY CLUSTERED 
(
	[WODtlId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[WorkOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderDetail_WorkOrderHeader] FOREIGN KEY([WOHdrID])
REFERENCES [dbo].[WorkOrderHeader] ([WOHdrID])
GO

ALTER TABLE [dbo].[WorkOrderDetail] CHECK CONSTRAINT [FK_WorkOrderDetail_WorkOrderHeader]
GO


