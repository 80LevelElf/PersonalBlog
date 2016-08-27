using LinqToDB.Mapping;

namespace PersonalBlog.Entities
{
	[Table(Name = "Post")]
	public class PostDto : PostBaseDto
	{
		[Column("Source")]
        public string Source { get; set; }
	}
}
