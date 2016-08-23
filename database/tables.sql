-- Post
CREATE TABLE [dbo].[Post](
	[PostId] [bigint] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Source] [nvarchar](max) NOT NULL,
	[SourcePreview] [nvarchar](max) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[UpdationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PostData] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO