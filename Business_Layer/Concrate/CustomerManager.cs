using Business_Layer.Abstract;
using DataAccess_Layer.Abstract;
using Entity_Layer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrate
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public Customer GetById(int id)
        {
          return  _customerDal.GetById(id);
        }

        public List<Customer> GetCustomersListWithJoop()
        {
            return _customerDal.GetCustomerListWithJoop();
        }

        public void TDelete(Customer t)
        {
           _customerDal.Delete(t);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetAll();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
           _customerDal.Update(t);
        }
    }
}
