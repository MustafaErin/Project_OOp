using DataAccess_Layer.Abstract;
using DataAccess_Layer.Concrate;
using DataAccess_Layer.Repositories;
using Entity_Layer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public List<Customer> GetCustomerListWithJoop()
        {
            using (var c = new Context())
            {
                return c.customers.Include(x => x.joop).ToList();
            }
        }
    }
}
