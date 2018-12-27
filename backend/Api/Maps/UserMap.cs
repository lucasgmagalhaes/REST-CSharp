using Api.Models;
using FluentNHibernate.Mapping;

namespace Api.Maps
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");

            Id(x => x.Id);
            Map(x => x.UserName);
            Map(x => x.Email);
            Map(x => x.UserPassword);
        }
    }
}
