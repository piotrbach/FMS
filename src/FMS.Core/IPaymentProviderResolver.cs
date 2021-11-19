namespace FMS.Core
{
    public interface IPaymentProviderResolver
    {
        IPaymentProvider Resolve(string obj);
    }
}