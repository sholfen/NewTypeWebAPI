namespace NewTypeWebAPI.Utilities.Models
{
    public class SessionInfo
    {
        public string SessionId { get; set; } = string.Empty;
        public Dictionary<string, object> Items { get; set; } = new Dictionary<string, object>();
    }
}
