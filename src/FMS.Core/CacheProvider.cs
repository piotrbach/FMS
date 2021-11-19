using System.Dynamic;

namespace FMS.Core
{
    public class RedisCacheProvider: ICacheProvider
    {
        public T Get<T>(string key)
        {
            throw new System.NotImplementedException();
        }
    }
    
    public interface ICacheProvider
    {
        T Get<T>(string key);
    }
}