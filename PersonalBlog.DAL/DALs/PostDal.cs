using System;
using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using PersonalBlog.DAL.Results;
using PersonalBlog.Entities;

namespace PersonalBlog.DAL.DALs
{
    public static class PostDal
    {
        public static ResultOrProblem<PostDto> Get(long postId)
        {
            using (var blogDb = new BlogDb())
            {
                var post = blogDb.Posts.FirstOrDefault(p => p.PostId == postId);

                if (post == null)
                    return new ResultOrProblem<PostDto>(ProblemType.CantFindContent);

                return new ResultOrProblem<PostDto>(post);
            }
        }

        public static List<PostDto> GetList(int currentPage, int pageSize)
        {
            using (var blogDb = new BlogDb())
            {
                return blogDb.Posts.OrderByDescending(i => i.CreationDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public static int Insert(PostDto newPost)
        {
            using (var blogDb = new BlogDb())
            {
                return blogDb.Insert(newPost);
            }
        }

        public static void Update(PostDto postToUpdate)
        {
            using (var blogDb = new BlogDb())
            {
                blogDb.Update(postToUpdate);
            }
        }

        public static void Delete(int postId)
        {
            using (var blogDb = new BlogDb())
            {
                var postToDelete = blogDb.Posts.FirstOrDefault(i => i.PostId == postId);
                if (postToDelete == null)
                    throw new ArgumentOutOfRangeException(nameof(postId), "Can't find post with specified post id");

                blogDb.Delete(postToDelete);
            }
        }
    }
}
