using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using PersonalBlog.DAL.DalManagers;
using PersonalBlog.DAL.Results;
using PersonalBlog.Entities;

namespace PersonalBlog.DAL.DALs
{
    public static class LogEntryDal
    {
        public static int Insert(LogEntryDto newLogEntry)
        {
            using (var blogDb = new BlogDb())
            {
                return blogDb.Insert(newLogEntry);
            }
        }

		public static PageResult<LogEntryDto> GetList(int currentPage)
        {
			int pageCount;
			List<LogEntryDto> resultList;

            using (var blogDb = new BlogDb())
            {
				pageCount = PageManager.GetPageCount(blogDb.LogEntries.Count());
				resultList = blogDb.LogEntries.OrderByDescending(i => i.Date).GetPageResult(currentPage).ToList();
            }

			return new PageResult<LogEntryDto>(currentPage, pageCount, resultList);
        }
    }
}
