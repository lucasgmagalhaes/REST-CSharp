using Api.Arquitetura.Connection;
using Api.Arquitetura.Repositories;
using FluentNHibernate.Data;
using System.Collections.Generic;
using System.Linq;

namespace Api.RepositoriesImpl
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        public List<T> GetAll()
        {
            using (var session = SessionBuilder.OpenSession())
            {
                return session.Query<T>().ToList();
            }
        }

        public T GetById(long id)
        {
            using (var session = SessionBuilder.OpenSession())
            {
                return session.Get<T>(id);
            }
        }

        public void Insert(T entity)
        {
            using (var session = SessionBuilder.OpenSession())
            {
                session.Save(entity);
            }
        }


        public void Delete(T entity)
        {
            using (var session = SessionBuilder.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public void Delete(long id)
        {
            using (var session = SessionBuilder.OpenSession())
            {
                var queryString = string.Format("delete {0} where id = :id", typeof(T));
                session.CreateQuery(queryString).SetParameter("id", id).ExecuteUpdate();
            }
        }

        public void Update(T entity)
        {
            using (var session = SessionBuilder.OpenSession())
            {
                session.Update(entity);
                session.Flush();
            }
        }

        public void SaveOrUpdate(T entity)
        {
            using (var session = SessionBuilder.OpenSession())
            {
                session.SaveOrUpdate(entity);
                session.Flush();
            }
        }
    }
}
