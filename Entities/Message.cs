namespace ClickMe.Entities
{
    public record Message
    {
        public Guid Id {get; init;}
        public string Content {get; init;}  = string.Empty;
    }
}