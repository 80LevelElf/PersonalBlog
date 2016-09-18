using System.Collections.Generic;
using System.Linq;
using PersonalBlog.DAL.DalManagers;
using PersonalBlog.DAL.Results;
using PersonalBlog.Entities;

namespace PersonalBlog.DAL.DALs
{
    public static class PostBaseDal
    {
		public static PageResult<PostBaseDto> GetList(int currentPage)
		{
			int pageCount;
			List<PostBaseDto> resultList;

            using (var blogDb = new BlogDb())
            {
				pageCount = PageManager.GetPageCount(blogDb.PostBases.Count());
				resultList = blogDb.PostBases.GetPageResult(currentPage).ToList();
            }

			return new PageResult<PostBaseDto>(currentPage, pageCount, resultList);
        }
    }
}
