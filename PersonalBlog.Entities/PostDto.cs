using System;
using LinqToDB.Mapping;

namespace PersonalBlog.Entities
{
	[Table(Name = "Post")]
	public class PostDto
	{
		[PrimaryKey, Identity]
		public long PostId { get; set; }

		public string Title { get; set; }

		public string Source { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime UpdationDate { get; set; }
	}
}
