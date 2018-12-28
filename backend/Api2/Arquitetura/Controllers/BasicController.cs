using Api.Arquitetura.Repositories;
using FluentNHibernate.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Arquitetura.Controllers
{
    [Produces("application/json")]
    public abstract class BasicController<T> : ControllerBase where T : Entity
    {
        protected IRepository<T> repository;

        protected BasicController(IRepository<T> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        protected IEnumerable<T> Get()
        {
            return repository.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        protected T Get(int id)
        {
            return repository.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        protected void Post([FromBody]T entity)
        {
            repository.Insert(entity);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        protected void Put(int id, [FromBody]T entity)
        {
            repository.SaveOrUpdate(entity);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        protected void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
