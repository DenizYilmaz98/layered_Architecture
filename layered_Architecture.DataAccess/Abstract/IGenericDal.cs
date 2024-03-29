﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class,new()
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetListAll();
        T GetById(int Id);
        List<T> GetListAll(Expression<Func<T,bool>>filter);
    }
}
