using System;
using LinqToDB.Mapping;

namespace PersonalBlog.Entities
{
	[Table(Name = "Post")]
	public class PostBaseDto
	{
		[PrimaryKey, Identity]
		[Column("PostId")]
		public int PostId { get; set; }

		[Column("Title")]
		public string Title { get; set; }

		[Column("CreationDate")]
		public DateTime CreationDate { get; set; }

		[Column("UpdationDate")]
		public DateTime UpdationDate { get; set; }
	}
}
