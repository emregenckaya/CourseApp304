﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp304.Data.Abstract
{
    public interface IGenericRepository<Tentity> where Tentity:class
    {
        Tentity Get(int id);
        IEnumerable<Tentity> GetAll();

        void Delete(int id);
        void Update(Tentity entity);
        void insert(Tentity entity);

    }
}
