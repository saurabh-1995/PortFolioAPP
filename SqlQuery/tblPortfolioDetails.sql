USE [Company]
GO

/****** Object:  Table [dbo].[tblPortfolioDetails]    Script Date: 19-Sep-18 1:37:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPortfolioDetails](
	[PortFolioName] [nvarchar](120) NOT NULL,
	[Description] [nvarchar](250) NOT NULL,
	[CoverImage] [varchar](500) NULL,
	[YoutubeVideo] [varchar](500) NULL,
	[CompanyName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__tblPortf__17AFF27F1FAFB017] PRIMARY KEY CLUSTERED 
(
	[PortFolioName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblPortfolioDetails]  WITH CHECK ADD  CONSTRAINT [FK__tblPortfo__Compa__49C3F6B7] FOREIGN KEY([CompanyName])
REFERENCES [dbo].[tblCompanyDetails] ([CompanyName])
GO

ALTER TABLE [dbo].[tblPortfolioDetails] CHECK CONSTRAINT [FK__tblPortfo__Compa__49C3F6B7]
GO


