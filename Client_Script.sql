USE [WorkOrderLog]
GO

/****** Object:  Table [dbo].[Client]    Script Date: 10/20/2019 18:38:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Client](
	[UniqueID] [int] IDENTITY(1,1) NOT NULL,
	[ClientCode] [nvarchar](4) NOT NULL,
	[ClientFolder] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

