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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int id)
        {
           return _productDal.GetById(id);
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
            
        }

        public List<Product> TGetList()
        {
            return _productDal.GetAll();
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
