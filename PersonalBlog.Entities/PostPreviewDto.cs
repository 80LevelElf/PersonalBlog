using LinqToDB.Mapping;

namespace PersonalBlog.Entities
{
	[Table(Name = "Post")]
	public class PostPreviewDto : PostBaseDto
	{
		[Column("SourcePreview")]
		public string SourcePreview { get; set; }
	}
}
