USE [VacationalAgency]
GO

/****** Object:  Table [dbo].[HolidayHomeOwner]    Script Date: 31/07/2020 14:32:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HolidayHomeOwner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nchar](50) NOT NULL,
	[surname] [nchar](100) NOT NULL,
	[nif] [nchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


