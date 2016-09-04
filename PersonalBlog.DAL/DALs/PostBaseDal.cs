using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonalBlog.Entities;

namespace PersonalBlog.DAL.DALs
{
    public static class PostBaseDal
    {
        public static List<PostBaseDto> GetList(int currentPage, int pageSize)
        {
            using (var blogDb = new BlogDb())
            {
                return blogDb.PostBases.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            }
        }
    }
}
