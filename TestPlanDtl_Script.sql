USE [WorkOrderLog]
GO

/****** Object:  Table [dbo].[TestPlanDtl]    Script Date: 10/24/2019 20:47:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestPlanDtl](
	[TestPlanDtlID] [int] IDENTITY(1,1) NOT NULL,
	[TestPlanFileID] [int] NOT NULL,
	[Description] [nvarchar](150) NULL,
	[LongDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_TestPlanDtl] PRIMARY KEY CLUSTERED 
(
	[TestPlanDtlID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[TestPlanDtl]  WITH CHECK ADD  CONSTRAINT [FK_TestPlanDtl_TestPlanFile] FOREIGN KEY([TestPlanFileID])
REFERENCES [dbo].[TestPlanFile] ([TestPlanFileID])
GO

ALTER TABLE [dbo].[TestPlanDtl] CHECK CONSTRAINT [FK_TestPlanDtl_TestPlanFile]
GO

