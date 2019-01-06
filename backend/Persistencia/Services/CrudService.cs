using Entidades.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistencia.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistencia.Services
{
    public class CrudService<T> : ICrudService<T> where T : class, IEntity, new()
    {
        private readonly DataBaseContext dbService;

        public CrudService()
        {
            dbService = new DataBaseContext();
            this.dbService.Set<T>();
        }

        public void Atualizar(T entidade)
        {
            this.dbService.Update(entidade);
            this.dbService.SaveChanges();
        }

        public void Atualizar(List<T> entidades)
        {
            this.dbService.Update(entidades);
            this.dbService.SaveChanges();
        }

        public List<T> Buscar()
        {
            return this.dbService.Set<T>().ToList();
        }

        public T Buscar(long id)
        {
            return this.dbService.Set<T>().Find(id);
        }

        public void Deletar(T entidade)
        {
            EntityEntry<T> retorno = this.dbService.Set<T>().Remove(entidade);
            dbService.SaveChanges();
        }

        public void Deletar(long id)
        {
            IEntity obj = new T() { Id = id };

            this.dbService.Attach(obj);
            this.dbService.Remove(obj);
            this.dbService.SaveChanges();
        }

        public T Salvar(T entidade)
        {
            this.dbService.Add(entidade);
            this.dbService.SaveChanges();
            return entidade;
        }

        public async Task AtualizarAsync(T entidade)
        {
            this.dbService.Update(entidade);
            await this.dbService.SaveChangesAsync();
        }

        public async Task AtualizarAsync(List<T> entidades)
        {
            this.dbService.Update(entidades);
            await this.dbService.SaveChangesAsync();
        }

        public async Task<List<T>> BuscarAsync()
        {
            return await this.dbService.Set<T>().ToListAsync();
        }

        public async Task<T> BuscarAsync(long id)
        {
            return await this.dbService.FindAsync<T>(id);
        }

        public async Task DeletarAsync(T entidade)
        {
            EntityEntry<T> retorno = this.dbService.Remove(entidade);
            await dbService.SaveChangesAsync();
        }

        public async Task DeletarAsync(long id)
        {
            IEntity obj = new T() { Id = id };

            this.dbService.Attach(obj);
            this.dbService.Remove(obj);
            await this.dbService.SaveChangesAsync();
        }

        public async Task<T> SalvarAsync(T entidade)
        {
            this.dbService.Add(entidade);
            await this.dbService.SaveChangesAsync();
            return entidade;
        }
    }
}
