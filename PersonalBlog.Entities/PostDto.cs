using System.IO;
using LinqToDB.Mapping;

namespace PersonalBlog.Entities
{ 
	[Table(Name = "Post")]
	public class PostDto : PostBaseDto
	{
		[Column("Source")]
        public string Source { get; set; }

        [Column("PreviewEndIndex")]
        public int PreviewEndIndex { get; set; }

	    public string SourcePreview
        {
	        get
	        {
	            if (PreviewEndIndex > Source.Length)
                    throw new InvalidDataException("PreviewEndIndex can't be bigger the Source letters count");

	            return Source.Substring(0, PreviewEndIndex);
	        }
	    }
	}
}
