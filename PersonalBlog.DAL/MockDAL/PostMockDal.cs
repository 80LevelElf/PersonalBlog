using System;
using PersonalBlog.DAL.Results;
using PersonalBlog.Entities;

namespace PersonalBlog.DAL.MockDAL
{
    public static class PostMockDal
    {
        public static ResultOrProblem<PostDto> Get(long postId)
        {
            return new ResultOrProblem<PostDto>(new PostDto
            {
                PostId = -1,
                CreationDate = DateTime.Now,
                UpdationDate = DateTime.Now,
                Source = @"
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT
						BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT BIG_BIG_TEXT",
                Title = "TITLE",
            });
        }
    }
}
