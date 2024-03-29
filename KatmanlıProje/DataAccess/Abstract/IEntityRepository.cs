﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T: class,IEntity,new()  //referans tip ve IEntityden new lenecek olur sadece
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //filtre vemeyebilirsin

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
