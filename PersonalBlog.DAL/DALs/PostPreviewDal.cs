using System.Collections.Generic;
using System.Linq;
using PersonalBlog.Entities;

namespace PersonalBlog.DAL.DALs
{
	public static class PostPreviewDal
	{
		public static List<PostPreviewDto> GetList(int currentPage, int pageSize)
		{
			using (var blogDb = new BlogDb())
			{
				return blogDb.PostPreviews.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
			}
		}
	}
}
