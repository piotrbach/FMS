using System.Collections.Generic;
using System.Linq;

namespace FMS.Services
{
    public class CustomerService: ICustomerService
    {
        public IList<string> GetAll()
        {
            return Enumerable.Range(1, 10).Select(x => $"Customer {x}").ToList();
        }
    }

    public interface ICustomerService
    {
        IList<string> GetAll();
    }
}