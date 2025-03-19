using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WelcomeExtended.Model
{
    public class LogEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Message { get; set; }

        
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public LogEntry() { }

        public LogEntry(string message)
        {
            Message = message;
        }
    }
}
