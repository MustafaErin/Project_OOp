﻿using DataAccess_Layer.Abstract;
using DataAccess_Layer.Repositories;
using Entity_Layer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.EntityFramework
{
    public class EfJoopDal:GenericRepository<Joop>,IJoopDal
    {
    }
}
