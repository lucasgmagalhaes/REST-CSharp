
using FluentNHibernate.Data;

namespace Api.Models
{
    public class User : Entity
    {
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string UserPassword { get; set; }
    }
}
