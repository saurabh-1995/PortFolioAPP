USE [Company]
GO

/****** Object:  Table [dbo].[tblCompanyDetails]    Script Date: 19-Sep-18 1:36:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCompanyDetails](
	[CompanyName] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[EmailID] [nvarchar](100) NOT NULL,
	[PhoneNo] [bigint] NOT NULL,
	[ContactPerson] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tblCompanyDetails] PRIMARY KEY CLUSTERED 
(
	[CompanyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


