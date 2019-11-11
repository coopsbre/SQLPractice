USE [WorkOrderLog]
GO
/****** Object:  Table [dbo].[ActivityCategory]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityCategory](
	[CategoryID] [nvarchar](10) NOT NULL,
	[ShortDescription] [nvarchar](50) NOT NULL,
	[LongDescription] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_ActivityCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FileFieldType]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileFieldType](
	[UniqueFileFieldTypeId] [int] IDENTITY(1,1) NOT NULL,
	[FileFieldlTypeId] [nvarchar](10) NOT NULL,
	[FileFieldDescription] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_FileFieldType] PRIMARY KEY CLUSTERED 
(
	[FileFieldlTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FileDelimiter]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileDelimiter](
	[UnqFileDelimiterID] [int] IDENTITY(1,1) NOT NULL,
	[FileDelimiterID] [nvarchar](5) NOT NULL,
	[DelimiterChar] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_Delimiter] PRIMARY KEY CLUSTERED 
(
	[FileDelimiterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommonFolder]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommonFolder](
	[CommonFolderID] [int] IDENTITY(1,1) NOT NULL,
	[FolderPath] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_CommonFolder] PRIMARY KEY CLUSTERED 
(
	[CommonFolderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 11/11/2019 20:13:32 ******/
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
/****** Object:  Table [dbo].[ScriptFile]    Script Date: 11/11/2019 20:13:32 ******/
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
/****** Object:  Table [dbo].[ScriptAction]    Script Date: 11/11/2019 20:13:32 ******/
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
/****** Object:  Table [dbo].[FileProduceType]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileProduceType](
	[UnqFileProduceTypeID] [int] IDENTITY(1,1) NOT NULL,
	[FileProduceTypeID] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_FileProduceType] PRIMARY KEY CLUSTERED 
(
	[FileProduceTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestPlanFile]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestPlanFile](
	[TestPlanFileID] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_TestPlanFile] PRIMARY KEY CLUSTERED 
(
	[TestPlanFileID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SourceScriptDtl]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SourceScriptDtl](
	[SourceScriptDtlID] [int] IDENTITY(1,1) NOT NULL,
	[SourceScriptHdrID] [int] NOT NULL,
	[SourceFile] [nvarchar](250) NOT NULL,
	[CommonFolderID] [int] NOT NULL,
 CONSTRAINT [PK_SourceScriptDtl] PRIMARY KEY CLUSTERED 
(
	[SourceScriptDtlID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkOrderHeader]    Script Date: 11/11/2019 20:13:32 ******/
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
 CONSTRAINT [PK_WorkOrderHeader] PRIMARY KEY CLUSTERED 
(
	[WOHdrID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestPlanDtl]    Script Date: 11/11/2019 20:13:32 ******/
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
/****** Object:  Table [dbo].[ActivityType]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityType](
	[ActivityTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ShortDescription] [nvarchar](20) NOT NULL,
	[LongDescription] [nvarchar](150) NOT NULL,
	[CategoryID] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_ActivityType] PRIMARY KEY CLUSTERED 
(
	[ActivityTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FileField]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileField](
	[FileFieldID] [int] IDENTITY(1,1) NOT NULL,
	[FileFieldTypeID] [nvarchar](10) NOT NULL,
	[FileFieldName] [nvarchar](200) NOT NULL,
	[FieldFieldValue] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_UniqueFdDtl] PRIMARY KEY CLUSTERED 
(
	[FileFieldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Activity]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[ActivityID] [int] IDENTITY(1,1) NOT NULL,
	[ActivityDescription] [nvarchar](100) NOT NULL,
	[ActivityTypeID] [int] NOT NULL,
 CONSTRAINT [PK_Activity] PRIMARY KEY CLUSTERED 
(
	[ActivityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SourceScriptHdr]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SourceScriptHdr](
	[SourceScriptHdrID] [int] IDENTITY(1,1) NOT NULL,
	[ActivityTypeID] [int] NOT NULL,
 CONSTRAINT [PK_SourceScriptHdr] PRIMARY KEY CLUSTERED 
(
	[SourceScriptHdrID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FileHdr]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileHdr](
	[FileHdrId] [int] IDENTITY(1,1) NOT NULL,
	[WOHdrID] [int] NOT NULL,
	[FileProduceTypeId] [nvarchar](10) NOT NULL,
	[FileDelimiterID] [nvarchar](5) NOT NULL,
	[ActivityID] [int] NOT NULL,
	[HeaderFieldCount] [smallint] NOT NULL,
	[PostingFieldCount] [smallint] NOT NULL,
	[TaxFieldCount] [smallint] NOT NULL,
	[ClearingFieldCount] [smallint] NOT NULL,
	[InterCompanyFieldCount] [smallint] NOT NULL,
 CONSTRAINT [PK_FDHdr] PRIMARY KEY CLUSTERED 
(
	[FileHdrId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkOrderDetail]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkOrderDetail](
	[WODtlId] [int] IDENTITY(1,1) NOT NULL,
	[WOHdrID] [int] NOT NULL,
	[ItemNumber] [int] NOT NULL,
	[ActivityID] [int] NOT NULL,
 CONSTRAINT [PK_WorkOrderDetail] PRIMARY KEY CLUSTERED 
(
	[WODtlId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkOrderScriptHdr]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkOrderScriptHdr](
	[WOScriptHdrID] [int] IDENTITY(1,1) NOT NULL,
	[WODtlID] [int] NOT NULL,
	[ScriptFileID] [int] NOT NULL,
	[TestPlanFileID] [int] NOT NULL,
 CONSTRAINT [PK_WorkOrderScriptHdr] PRIMARY KEY CLUSTERED 
(
	[WOScriptHdrID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FileDtl]    Script Date: 11/11/2019 20:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileDtl](
	[FileDtlId] [int] IDENTITY(1,1) NOT NULL,
	[FileHdrId] [int] NOT NULL,
	[FileFieldNo] [smallint] NOT NULL,
	[FileFieldId] [int] NOT NULL,
 CONSTRAINT [PK_FdDtl] PRIMARY KEY CLUSTERED 
(
	[FileDtlId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_WorkOrderHeader_CreatedDate]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[WorkOrderHeader] ADD  CONSTRAINT [DF_WorkOrderHeader_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_WorkOrderHeader_ModifiedDate]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[WorkOrderHeader] ADD  CONSTRAINT [DF_WorkOrderHeader_ModifiedDate]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
/****** Object:  ForeignKey [FK_SourceScriptDtl_CommonFolder]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[SourceScriptDtl]  WITH CHECK ADD  CONSTRAINT [FK_SourceScriptDtl_CommonFolder] FOREIGN KEY([CommonFolderID])
REFERENCES [dbo].[CommonFolder] ([CommonFolderID])
GO
ALTER TABLE [dbo].[SourceScriptDtl] CHECK CONSTRAINT [FK_SourceScriptDtl_CommonFolder]
GO
/****** Object:  ForeignKey [FK_WorkOrderHeader_Client]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[WorkOrderHeader]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderHeader_Client] FOREIGN KEY([ClientCode])
REFERENCES [dbo].[Client] ([ClientCode])
GO
ALTER TABLE [dbo].[WorkOrderHeader] CHECK CONSTRAINT [FK_WorkOrderHeader_Client]
GO
/****** Object:  ForeignKey [FK_TestPlanDtl_TestPlanFile]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[TestPlanDtl]  WITH CHECK ADD  CONSTRAINT [FK_TestPlanDtl_TestPlanFile] FOREIGN KEY([TestPlanFileID])
REFERENCES [dbo].[TestPlanFile] ([TestPlanFileID])
GO
ALTER TABLE [dbo].[TestPlanDtl] CHECK CONSTRAINT [FK_TestPlanDtl_TestPlanFile]
GO
/****** Object:  ForeignKey [FK_ActivityType_ActivityCategory]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[ActivityType]  WITH CHECK ADD  CONSTRAINT [FK_ActivityType_ActivityCategory] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[ActivityCategory] ([CategoryID])
GO
ALTER TABLE [dbo].[ActivityType] CHECK CONSTRAINT [FK_ActivityType_ActivityCategory]
GO
/****** Object:  ForeignKey [FK_FileField_FileFieldType]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[FileField]  WITH CHECK ADD  CONSTRAINT [FK_FileField_FileFieldType] FOREIGN KEY([FileFieldTypeID])
REFERENCES [dbo].[FileFieldType] ([FileFieldlTypeId])
GO
ALTER TABLE [dbo].[FileField] CHECK CONSTRAINT [FK_FileField_FileFieldType]
GO
/****** Object:  ForeignKey [FK_Activity_ActivityType]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_ActivityType] FOREIGN KEY([ActivityTypeID])
REFERENCES [dbo].[ActivityType] ([ActivityTypeID])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_ActivityType]
GO
/****** Object:  ForeignKey [FK_SourceScriptHdr_ActivityType]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[SourceScriptHdr]  WITH CHECK ADD  CONSTRAINT [FK_SourceScriptHdr_ActivityType] FOREIGN KEY([ActivityTypeID])
REFERENCES [dbo].[ActivityType] ([ActivityTypeID])
GO
ALTER TABLE [dbo].[SourceScriptHdr] CHECK CONSTRAINT [FK_SourceScriptHdr_ActivityType]
GO
/****** Object:  ForeignKey [FK_FileHdr_Activity]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[FileHdr]  WITH CHECK ADD  CONSTRAINT [FK_FileHdr_Activity] FOREIGN KEY([ActivityID])
REFERENCES [dbo].[Activity] ([ActivityID])
GO
ALTER TABLE [dbo].[FileHdr] CHECK CONSTRAINT [FK_FileHdr_Activity]
GO
/****** Object:  ForeignKey [FK_FileHdr_FileDelimiter]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[FileHdr]  WITH CHECK ADD  CONSTRAINT [FK_FileHdr_FileDelimiter] FOREIGN KEY([FileDelimiterID])
REFERENCES [dbo].[FileDelimiter] ([FileDelimiterID])
GO
ALTER TABLE [dbo].[FileHdr] CHECK CONSTRAINT [FK_FileHdr_FileDelimiter]
GO
/****** Object:  ForeignKey [FK_FileHdr_FileProduceType]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[FileHdr]  WITH CHECK ADD  CONSTRAINT [FK_FileHdr_FileProduceType] FOREIGN KEY([FileProduceTypeId])
REFERENCES [dbo].[FileProduceType] ([FileProduceTypeID])
GO
ALTER TABLE [dbo].[FileHdr] CHECK CONSTRAINT [FK_FileHdr_FileProduceType]
GO
/****** Object:  ForeignKey [FK_WorkOrderDetail_Activity]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[WorkOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderDetail_Activity] FOREIGN KEY([ActivityID])
REFERENCES [dbo].[Activity] ([ActivityID])
GO
ALTER TABLE [dbo].[WorkOrderDetail] CHECK CONSTRAINT [FK_WorkOrderDetail_Activity]
GO
/****** Object:  ForeignKey [FK_WorkOrderDetail_WorkOrderHeader]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[WorkOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderDetail_WorkOrderHeader] FOREIGN KEY([WOHdrID])
REFERENCES [dbo].[WorkOrderHeader] ([WOHdrID])
GO
ALTER TABLE [dbo].[WorkOrderDetail] CHECK CONSTRAINT [FK_WorkOrderDetail_WorkOrderHeader]
GO
/****** Object:  ForeignKey [FK_WorkOrderScriptHdr_TestPlanFile]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[WorkOrderScriptHdr]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderScriptHdr_TestPlanFile] FOREIGN KEY([TestPlanFileID])
REFERENCES [dbo].[TestPlanFile] ([TestPlanFileID])
GO
ALTER TABLE [dbo].[WorkOrderScriptHdr] CHECK CONSTRAINT [FK_WorkOrderScriptHdr_TestPlanFile]
GO
/****** Object:  ForeignKey [FK_WorkOrderScriptHdr_WorkOrderDetail]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[WorkOrderScriptHdr]  WITH CHECK ADD  CONSTRAINT [FK_WorkOrderScriptHdr_WorkOrderDetail] FOREIGN KEY([WODtlID])
REFERENCES [dbo].[WorkOrderDetail] ([WODtlId])
GO
ALTER TABLE [dbo].[WorkOrderScriptHdr] CHECK CONSTRAINT [FK_WorkOrderScriptHdr_WorkOrderDetail]
GO
/****** Object:  ForeignKey [FK_FileDtl_FileDtl]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[FileDtl]  WITH CHECK ADD  CONSTRAINT [FK_FileDtl_FileDtl] FOREIGN KEY([FileHdrId])
REFERENCES [dbo].[FileHdr] ([FileHdrId])
GO
ALTER TABLE [dbo].[FileDtl] CHECK CONSTRAINT [FK_FileDtl_FileDtl]
GO
/****** Object:  ForeignKey [FK_FileDtl_FileField]    Script Date: 11/11/2019 20:13:32 ******/
ALTER TABLE [dbo].[FileDtl]  WITH CHECK ADD  CONSTRAINT [FK_FileDtl_FileField] FOREIGN KEY([FileFieldId])
REFERENCES [dbo].[FileField] ([FileFieldID])
GO
ALTER TABLE [dbo].[FileDtl] CHECK CONSTRAINT [FK_FileDtl_FileField]
GO
