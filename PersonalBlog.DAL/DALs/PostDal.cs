using System.Linq;
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
    }
}
