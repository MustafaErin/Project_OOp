﻿using DataAccess_Layer.Abstract;
using DataAccess_Layer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Insert(T t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Delete(T t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
