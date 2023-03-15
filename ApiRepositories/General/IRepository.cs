using System;
using System.Collections.Generic;

namespace ApiRepositories.General
{
    public interface IRepository<T> where T : class
    {
        bool Delete(T entity);
        bool Update(T entity);
        int Insert(T entity);
        IEnumerable<T> GetList();
        T GetById(Int64 id);
    }
}
