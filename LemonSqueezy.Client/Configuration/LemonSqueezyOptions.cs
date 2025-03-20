namespace LemonSqueezy.Client.Configuration
{
    public class LemonSqueezyOptions
    {
        public string ApiKey { get; set; } = default!;
        public string BaseUrl { get; set; } = "https://api.lemonsqueezy.com/v1/";
    }
}
