using System;
using LinqToDB.Mapping;
using PersonalBlog.Entities.Enums;

namespace PersonalBlog.Entities
{
    [Table(Name = "LogEntry")]
    public class LogEntryDto
    {
        [PrimaryKey, Identity]
        [Column("LogEntryId")]
        public int LogEntryId { get; set; }

        [Column("Source")]
        public string Source { get; set; }

        [Column("LogEntryType")]
        public LogType Type { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }
    }
}
