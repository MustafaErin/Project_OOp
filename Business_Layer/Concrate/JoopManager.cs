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
    public class JoopManager : IJoopService
    {
        IJoopDal _joopDal;

        public JoopManager(IJoopDal joopDal)
        {
            _joopDal = joopDal;
        }

        public Joop GetById(int id)
        {
            return _joopDal.GetById(id);
        }

        public void TDelete(Joop t)
        {
            _joopDal.Delete(t);
        }

        public List<Joop> TGetList()
        {
            return _joopDal.GetAll();
        }

        public void TInsert(Joop t)
        {
            _joopDal.Insert(t);
        }

        public void TUpdate(Joop t)
        {
           _joopDal.Update(t);
        }
    }
}
