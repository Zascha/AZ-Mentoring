using System;
using System.Collections.Generic;

namespace AdventureWorks.DataAccess.Interfaces
{
    public interface IQuery<T> where T:class
    {
        T GetById(int itemId);

        List<T> GetAll();

        List<T> GetAllPaged(int pageNumber, int pageSize);

        List<T> GetByPredicate(Func<T, bool> predicate);

        int Create(T item);

        void Update(T item);

        void Delete(T item);

        void DeleteById(int itemId);
    }
}