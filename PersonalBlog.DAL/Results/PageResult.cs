using System.Collections.Generic;

namespace PersonalBlog.DAL.Results
{
	public class PageResult<T>
	{
		public PageResult(int currentPage, int pageCount, List<T> resultList)
		{
			CurrentPage = currentPage;
			PageCount = pageCount;
			ResultList = resultList;
		}

		public int PageCount { get; set; }

		public int CurrentPage { get; set; }

		public List<T> ResultList { get; set; } 
	}
}
