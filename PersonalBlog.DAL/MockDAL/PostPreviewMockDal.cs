﻿using System;
using System.Collections.Generic;
using PersonalBlog.Entities;

namespace PersonalBlog.DAL.MockDAL
{
	public static class PostPreviewMockDal
	{
		public static List<PostPreviewDto> GetList(int currentPage, int pageSize)
		{
			return new List<PostPreviewDto>
			{
				new PostPreviewDto
				{
					PostId = -1,
					CreationDate = DateTime.Now,
					UpdationDate = DateTime.Now,
					SourcePreview = @"
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT",
					Title = "TITLE",
				},
								new PostPreviewDto
				{
					PostId = -1,
					CreationDate = DateTime.Now,
					UpdationDate = DateTime.Now,
					SourcePreview = @"
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT",
					Title = "TITLE",
				},
				new PostPreviewDto
				{
					PostId = -2,
					CreationDate = DateTime.Now,
					UpdationDate = DateTime.Now,
					SourcePreview = @"
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT",
					Title = "TITLE",
				},
				new PostPreviewDto
				{
					PostId = -3,
					CreationDate = DateTime.Now,
					UpdationDate = DateTime.Now,
					SourcePreview = @"
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT",
					Title = "TITLE",
				}
			};
		}
	}
}
