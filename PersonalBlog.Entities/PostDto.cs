using LinqToDB.Mapping;

namespace PersonalBlog.Entities
{
	[Table(Name = "Post")]
	public class PostDto : PostBaseDto
	{
		[Column("SourcePreview")]
		public string SourcePreview { get; set; }
	}
}
