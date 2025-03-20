namespace LemonSqueezy.Client.Abstractions
{
    public interface ILemonSqueezyClient
    {
        IUserClient Users { get; }
        IStoreClient Stores { get; }
        ICustomerClient Customers { get; }
        IProductClient Products { get; }
        IVariantClient Variants { get; }
        IPriceClient Prices { get; }
        IFileClient Files { get; }
        IOrderClient Orders { get; }
        IOrderItemClient OrderItems { get; }
        ISubscriptionClient Subscriptions { get; }
        ILicenseKeyClient LicenseKeys { get; }
        ILicenseKeyInstanceClient LicenseKeyInstances { get; }
    }
}
