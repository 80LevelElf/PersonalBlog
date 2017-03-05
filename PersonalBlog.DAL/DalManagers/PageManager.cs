using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalBlog.DAL.DalManagers
{
	internal static class PageManager
	{
		public static IEnumerable<T> GetPageResult<T>(this IEnumerable<T> source, int currentPage)
		{
			return source
				.Skip((currentPage - 1) * DefaulSizeManager.PostPageSize)
				.Take(DefaulSizeManager.PostPageSize);
		}

		public static int GetPageCount(int allResults)
		{
			int size = DefaulSizeManager.PostPageSize;
			return allResults/size + ((allResults%size != 0) ? 1 : 0);
		}
	}
}
