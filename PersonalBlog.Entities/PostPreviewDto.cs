using LinqToDB.Mapping;

namespace PersonalBlog.Entities
{
	[Table(Name = "Post")]
	public class PostPreviewDto : PostBaseDto
	{
		[Column("Preview")]
		public string Preview { get; set; }
	}
}
