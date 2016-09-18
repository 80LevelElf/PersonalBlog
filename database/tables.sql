-- Post
CREATE TABLE [dbo].[Post](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Source] [nvarchar](max) NOT NULL,
	[PreviewEndIndex] [int] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[UpdationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PostData] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

-- User
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--Logs
CREATE TABLE [dbo].[LogEntry](
	[LogEntryId] [int] IDENTITY(1,1) NOT NULL,
	[Source] [nvarchar](200) NOT NULL,
	[LogEntryType] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_LogEntry] PRIMARY KEY CLUSTERED 
(
	[LogEntryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
