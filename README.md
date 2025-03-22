# LemonSqueezy.Client

A C# client library for the [Lemon Squeezy API](https://docs.lemonsqueezy.com/api).

> ⚠️ **WARNING: Alpha Stage Software**  
> This package is in alpha stage and has not been thoroughly tested in production environments. Use with caution and expect potential breaking changes in future releases.

## Installation

```bash
dotnet add package LemonSqueezy.Client
```

For ASP.NET Core webhook support:
```bash
dotnet add package LemonSqueezy.Client.AspNetCore
```

## Usage

### Configuration

```csharp
services.AddLemonSqueezy(options =>
{
    options.ApiKey = "your_api_key";
});
```

### Basic Usage

```csharp
public class StoreService
{
    private readonly ILemonSqueezyClient _client;

    public StoreService(ILemonSqueezyClient client)
    {
        _client = client;
    }

    public async Task<Store> GetStoreAsync(string storeId)
    {
        return await _client.Stores.GetStoreAsync(storeId);
    }
}
```

### Webhook Handling

First, configure webhook handling in your `Program.cs` or `Startup.cs`:

```csharp
services.AddLemonSqueezyWebhooks("your_webhook_signing_secret");
```

Then handle webhooks in your controller:

```csharp
[ApiController]
[Route("api/[controller]")]
public class WebhooksController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> HandleWebhook()
    {
        var webhookEvent = await Request.ReadWebhookAsync("your_webhook_signing_secret");

        if (webhookEvent.IsEventType(WebhookEventNames.OrderCreated))
        {
            if (webhookEvent.Data.TryGetOrder(out var order))
            {
                // Handle new order
            }
        }

        return Ok();
    }
}
```

## Available Clients

- `Users` - User management
- `Stores` - Store management
- `Customers` - Customer management
- `Products` - Product management
- `Variants` - Variant management
- `Files` - File management
- `Orders` - Order management and refunds
- `OrderItems` - Order item management
- `Subscriptions` - Subscription management
- `Prices` - Price management
- `LicenseKeys` - License key management and validation
- `LicenseKeyInstances` - License key instance management

## License

MIT


## nuget build

dotnet pack -c Release