USE [Bulky]
GO

/****** Object:  Table [dbo].[UserProfiles]    Script Date: 18-11-2022 13:38:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserProfiles](
	[ID] [bigint] NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NULL,
	[Address] [nvarchar](4000) NULL,
	[AddedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[IP] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.UserProfiles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserProfiles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserProfiles_dbo.Users_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Users] ([ID])
GO

ALTER TABLE [dbo].[UserProfiles] CHECK CONSTRAINT [FK_dbo.UserProfiles_dbo.Users_ID]
GO


