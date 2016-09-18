using System;
using PersonalBlog.DAL.DALs;
using PersonalBlog.Entities;
using PersonalBlog.Entities.Enums;

namespace PersonalBlog.Logic.Managers
{
    public static class LogManager
    {
        public static void LogSiteWork(string message)
        {
            LogEntryDal.Insert(new LogEntryDto
            {
                Date = DateTime.Now,
                Source = message,
                Type = LogType.SiteWork
            });
        }

        public static void LogPost(string title, string message)
        {
            LogEntryDal.Insert(new LogEntryDto
            {
                Date = DateTime.Now,
                Source = $"Post[{title}]: {message}",
                Type = LogType.Posts
            });
        }
    }
}
