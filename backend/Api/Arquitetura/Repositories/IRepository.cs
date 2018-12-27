using FluentNHibernate.Data;
using System.Collections.Generic;

namespace Api.Arquitetura.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        List<T> GetAll();
        T GetById(long id);
        void Insert(T entity);
        void Delete(T entity);
        void Delete(long id);
        void Update(T entity);
        void SaveOrUpdate(T entity);
    }
}
