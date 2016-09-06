using LinqToDB;
using PersonalBlog.Entities;

namespace PersonalBlog.DAL
{
	public class BlogDb : LinqToDB.Data.DataConnection
	{
		public BlogDb() : base("MS_SQL") { }

		public ITable<PostDto> Posts { get { return GetTable<PostDto>(); } }

        public ITable<PostBaseDto> PostBases { get { return GetTable<PostBaseDto>(); } }
    }
}
