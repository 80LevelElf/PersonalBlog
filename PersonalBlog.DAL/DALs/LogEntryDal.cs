using System.Collections.Generic;
using System.Linq;
using LinqToDB;
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

        public static List<LogEntryDto> GetList(int currentPage, int pageSize)
        {
            using (var blogDb = new BlogDb())
            {
                return blogDb.LogEntries.OrderByDescending(i => i.Date).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            }
        }
    }
}
