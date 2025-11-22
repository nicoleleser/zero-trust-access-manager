using System;
namespace ZTAM.Api.Models
{
    public class AccessLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AppId { get; set; }
        public string Result { get; set; } = ""; // allowed/blocked
        public DateTime AttemptTime { get; set; } = DateTime.UtcNow;
    }
}

