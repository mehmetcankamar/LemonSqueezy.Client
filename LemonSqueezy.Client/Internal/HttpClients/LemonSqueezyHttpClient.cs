using LemonSqueezy.Client.Abstractions;
using LemonSqueezy.Client.Extensions;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Customers;
using LemonSqueezy.Client.Models.Files;
using LemonSqueezy.Client.Models.LicenseKeys;
using LemonSqueezy.Client.Models.OrderItems;
using LemonSqueezy.Client.Models.Orders;
using LemonSqueezy.Client.Models.Prices;
using LemonSqueezy.Client.Models.Products;
using LemonSqueezy.Client.Models.Stores;
using LemonSqueezy.Client.Models.Subscriptions;
using LemonSqueezy.Client.Models.Users;
using LemonSqueezy.Client.Models.Variants;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace LemonSqueezy.Client.Internal.HttpClients
{
    public class LemonSqueezyHttpClient : ILemonSqueezyClient, IUserClient, IStoreClient, ICustomerClient, IProductClient, IVariantClient, IPriceClient, IFileClient, IOrderClient, IOrderItemClient, ISubscriptionClient, ILicenseKeyClient, ILicenseKeyInstanceClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        public IUserClient Users => this;
        public IStoreClient Stores => this;
        public ICustomerClient Customers => this;
        public IProductClient Products => this;
        public IVariantClient Variants => this;
        public IPriceClient Prices => this;
        public IFileClient Files => this;
        public IOrderClient Orders => this;
        public IOrderItemClient OrderItems => this;
        public ISubscriptionClient Subscriptions => this;
        public ILicenseKeyClient LicenseKeys => this;
        public ILicenseKeyInstanceClient LicenseKeyInstances => this;

        public LemonSqueezyHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<User> GetCurrentUserAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("users/me", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<User>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<User> GetUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"users/{userId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<User>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Store> GetStoreAsync(string storeId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"stores/{storeId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Store>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<Store>> ListStoresAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("stores", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<Store>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Customer> CreateCustomerAsync(string storeId, string name, string email, CancellationToken cancellationToken = default)
        {
            var attributes = new CreateCustomerAttributes(storeId, name, email);
            return await CreateCustomerAsync(attributes, cancellationToken);
        }

        public async Task<Customer> CreateCustomerAsync(CreateCustomerAttributes attributes, CancellationToken cancellationToken = default)
        {
            var request = new CreateCustomerRequest(attributes);

            var response = await _httpClient.PostAsJsonAsync("customers", request, _jsonOptions, cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Customer>>(content, _jsonOptions);

            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Customer> GetCustomerAsync(string customerId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"customers/{customerId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Customer>>(content, _jsonOptions);

            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Customer> UpdateCustomerAsync(string customerId, string name, string email, CancellationToken cancellationToken = default)
        {
            var attributes = new UpdateCustomerAttributes(name, email);
            return await UpdateCustomerAsync(customerId, attributes, cancellationToken);
        }

        public async Task<Customer> UpdateCustomerAsync(string customerId, UpdateCustomerAttributes attributes, CancellationToken cancellationToken = default)
        {
            var request = new UpdateCustomerRequest(customerId, attributes);

            var response = await _httpClient.PatchAsJsonAsync($"customers/{customerId}", request, _jsonOptions, cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Customer>>(content, _jsonOptions);

            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<Customer>> ListCustomersAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("customers", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<Customer>>(content, _jsonOptions);

            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Product> GetProductAsync(string productId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"products/{productId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Product>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<Product>> ListProductsAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("products", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<Product>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Variant> GetVariantAsync(string variantId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"variants/{variantId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Variant>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<Variant>> ListVariantsAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("variants", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<Variant>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Price> GetPriceAsync(string priceId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"prices/{priceId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Price>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<Price>> ListPricesAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("prices", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<Price>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<LemonFile> GetFileAsync(string fileId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"files/{fileId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<LemonFile>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<LemonFile>> ListFilesAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("files", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<LemonFile>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Order> GetOrderAsync(string orderId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"orders/{orderId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Order>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<Order>> ListOrdersAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("orders", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<Order>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<byte[]> GenerateInvoiceAsync(string orderId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.PostAsync($"orders/{orderId}/generate-invoice", null, cancellationToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }

        public async Task<Order> IssueRefundAsync(string orderId, int amount, CancellationToken cancellationToken = default)
        {
            var request = new IssueRefundRequest(orderId, amount);

            var response = await _httpClient.PostAsJsonAsync($"orders/{orderId}/refund", request, _jsonOptions, cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Order>>(content, _jsonOptions);

            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<OrderItem> GetOrderItemAsync(string orderItemId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"order-items/{orderItemId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<OrderItem>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<OrderItem>> ListOrderItemsAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("order-items", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<OrderItem>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Subscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"subscriptions/{subscriptionId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Subscription>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<Subscription>> ListSubscriptionsAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("subscriptions", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<Subscription>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Subscription> UpdateSubscriptionAsync(string subscriptionId, UpdateSubscriptionRequest request, CancellationToken cancellationToken = default)
        {
            var wrapper = new UpdateSubscriptionRequestWrapper(subscriptionId, request);

            var response = await _httpClient.PatchAsJsonAsync($"subscriptions/{subscriptionId}", wrapper, _jsonOptions, cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Subscription>>(content, _jsonOptions);

            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<Subscription> CancelSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.DeleteAsync($"subscriptions/{subscriptionId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<Subscription>>(content, _jsonOptions);

            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<LicenseKey> GetLicenseKeyAsync(string licenseKeyId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"license-keys/{licenseKeyId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<LicenseKey>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<LicenseKey>> ListLicenseKeysAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("license-keys", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<LicenseKey>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ActivateLicenseKeyResponse> ActivateLicenseKeyAsync(string key, string instance, CancellationToken cancellationToken = default)
        {
            var request = new ActivateLicenseKeyRequest(key, instance);

            var response = await _httpClient.PostAsJsonAsync("licenses/activate", request, _jsonOptions, cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ActivateLicenseKeyResponse>(content, _jsonOptions);

            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<DeactivateLicenseKeyResponse> DeactivateLicenseKeyAsync(string key, string instance, CancellationToken cancellationToken = default)
        {
            var request = new DeactivateLicenseKeyRequest(key, instance);

            var response = await _httpClient.PostAsJsonAsync("licenses/deactivate", request, _jsonOptions, cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DeactivateLicenseKeyResponse>(content, _jsonOptions);

            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<bool> ValidateLicenseKeyAsync(string key, string instance, CancellationToken cancellationToken = default)
        {
            var request = new ValidateLicenseKeyRequest(key, instance);

            var response = await _httpClient.PostAsJsonAsync("licenses/validate", request, _jsonOptions, cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ValidateLicenseKeyResponse>(content, _jsonOptions);

            return result?.Valid ?? false;
        }

        public async Task<LicenseKeyInstance> GetLicenseKeyInstanceAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync($"license-key-instances/{instanceId}", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse<LicenseKeyInstance>>(content, _jsonOptions);
            
            return result?.Data ?? throw new InvalidOperationException("Failed to deserialize response");
        }

        public async Task<ApiResponseList<LicenseKeyInstance>> ListLicenseKeyInstancesAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync("license-key-instances", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponseList<LicenseKeyInstance>>(content, _jsonOptions);
            
            return result ?? throw new InvalidOperationException("Failed to deserialize response");
        }
    }
}
