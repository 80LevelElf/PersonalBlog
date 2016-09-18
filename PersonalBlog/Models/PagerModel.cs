namespace PersonalBlog.Models
{
	public class PagerModel
	{
		public string Action { get; set; }

		public string Controller { get; set; }

		public int CurrentPageIndex { get; set; }

		public int PageCount { get; set; }
	}
}