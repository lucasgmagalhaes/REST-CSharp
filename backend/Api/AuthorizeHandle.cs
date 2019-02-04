using Microsoft.AspNetCore.Authorization;
using Persistencia;
using System.Threading.Tasks;

namespace Api
{
    public class AuthorizeHandle : IAuthorizationHandler
    {
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            var email = context.User.Identity.Name;
            if (context.User.Identity.IsAuthenticated)
            {
                ConnectionString.Database = Session.BuscarBancoDoUsuario(email);
            }
            return Task.CompletedTask;
        }
    }
}
