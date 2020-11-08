using System.Collections.Generic;
using AdventureWorks.Common;

namespace AdventureWorks.DataServices.Interfaces
{
    public interface IApiService<T> where T : class
    {
        T GetById(int itemId);

        List<T> GetAllPaged(int pageNumber = 1, int pageSize = DataConsts.PageSize);

        int Create(T item);

        void Update(T item);

        void DeleteById(int itemId);
    }
}