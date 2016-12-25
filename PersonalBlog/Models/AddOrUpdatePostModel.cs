using System;
using PersonalBlog.Entities;
using PersonalBlog.Logic.Managers;

namespace PersonalBlog.Models
{
    public class AddOrUpdatePostModel
    {
        public int? PostId { get; set; }

        public string Source { get; set; }

        public string Title { get; set; }

        public PostDto ToPostDto()
        {
            var postProcessResult = PostManager.ProcessSource(Source);
            DateTime nowTime = DateTime.Now;

            var result = new PostDto
            {
                Title = Title,
                CreationDate = nowTime,
                UpdationDate = nowTime,
                PreviewEndIndex = postProcessResult.PreviewEndIndex,
                Source = postProcessResult.CleanedSource
            };

            if (PostId.HasValue)
                result.PostId = PostId.Value;
            
            return result;
        }

	    public void UpdatePostDto(PostDto existentPost)
	    {
		    var postProcessResult = PostManager.ProcessSource(Source);

		    existentPost.Source = postProcessResult.CleanedSource;
		    existentPost.PreviewEndIndex = postProcessResult.PreviewEndIndex;

			existentPost.UpdationDate = DateTime.Now;
		}
    }
}