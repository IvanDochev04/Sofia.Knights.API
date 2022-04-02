using System.Collections.Generic;

namespace SofiaKnights_API.Data.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        public T GetById(int id);

        public List<T> GetAll();

        public T Create(T model);

        public T Update(T model);

        public void Delete(int id);
    }
}
