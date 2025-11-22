using System;
namespace ZTAM.Api.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AppId { get; set; }
        public string Action { get; set; } = "deny"; // allow/deny
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}