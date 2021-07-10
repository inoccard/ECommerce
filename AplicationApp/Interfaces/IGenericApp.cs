using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AplicationApp.Interfaces
{
    public interface IGenericApp<T> where T : class
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> Get(int id);
        Task<List<T>> GetAll();
    }
}
