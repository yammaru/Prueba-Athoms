using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class Lógica<T> where T : new()
    {
        public Lógica(Repository<T> repository)
        {
            Repository = repository;
        }

        private readonly Repository<T> Repository;

        public int Count()
        {
            return Repository.Count();
        }

        public T Get(int id)
        {
            return Repository.Get(id);
        }

        public List<T> GetAll()
        {
            return Repository.GetAll();
        }

        public int Insert(T t)
        {
            return Repository.Insert(t);
        }

        public int Delete(int id)
        {
            return Repository.Delete(id);
        }

        public void Update(T t, int id)
        {
            Repository.Update(id, t);
        }

        public T GetBy(string nombre, object valor)
        {
            return Repository.GetBy(nombre, valor);
        }
    }
}
