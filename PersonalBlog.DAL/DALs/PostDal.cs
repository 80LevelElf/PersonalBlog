using System;
using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using PersonalBlog.DAL.DalManagers;
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

	            post.ViewCount++;
				blogDb.Update(post);

				return new ResultOrProblem<PostDto>(post);
            }
        }

		public static PageResult<PostDto> GetList(int currentPage)
        {
			int pageCount;
			List<PostDto> resultList;

            using (var blogDb = new BlogDb())
            {
				pageCount = PageManager.GetPageCount(blogDb.Posts.Count());
				resultList = blogDb.Posts.OrderByDescending(i => i.CreationDate).GetPageResult(currentPage).ToList();
            }

			return new PageResult<PostDto>(currentPage, pageCount, resultList);
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
					throw new ArgumentOutOfRangeException("postId", "Can't find post with specified post id");

                blogDb.Delete(postToDelete);
            }
        }
    }
}
