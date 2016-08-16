using System.Collections.Generic;
using System.Linq;
using PersonalBlog.Entities;

namespace PersonalBlog.DAL.DALs
{
	public static class PostDal
	{
		public static List<PostDto> GetList(int currentPage, int pageSize)
		{
			using (var blogDb = new BlogDb())
			{
				return blogDb.Posts.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
			}
		}
	}
}
