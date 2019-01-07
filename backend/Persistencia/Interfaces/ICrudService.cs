using Entidades.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistencia.Interfaces
{
    public interface ICrudService<T> where T : class, IEntity, new()
    {
        void Atualizar(T entidade);
        void Atualizar(List<T> entidades);
        Task AtualizarAsync(T entidade);
        Task AtualizarAsync(List<T> entidades);
        List<T> Buscar();
        T Buscar(long id);
        Task<List<T>> BuscarAsync();
        Task<T> BuscarAsync(long id);
        void Deletar(T entidade);
        void Deletar(long id);
        Task DeletarAsync(T entidade);
        Task DeletarAsync(long id);
        T Salvar(T entidade);
        Task<T> SalvarAsync(T entidade);
    }
}