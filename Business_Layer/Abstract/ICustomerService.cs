using Entity_Layer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Abstract
{
    public interface ICustomerService:IGenericService<Customer>
    {
        List<Customer> GetCustomersListWithJoop();
    }
}
