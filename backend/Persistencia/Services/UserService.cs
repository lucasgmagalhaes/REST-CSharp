using Entidades;
using Entidades.Models;
using Persistencia.Interfaces;

namespace Persistencia.Services
{
    public class UserService : CrudService<Usuario>, IUserService
    {
    }
}
