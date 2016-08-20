using LinqToDB.Mapping;

namespace PersonalBlog.Entities
{
	[Table(Name = "Post")]
	public class PostPreviewDto : PostBaseDto
	{
		[Column("Source")]
		public string Source { get; set; }
	}
}
