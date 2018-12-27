using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Api.Arquitetura.Connection
{
    public class SessionBuilder
    {
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();

        }

        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    BuildSessionFactory();

                return _sessionFactory;
            }
        }

        public static void BuildSessionFactory(bool create = false, bool update = false)
        {
            _sessionFactory = Fluently.Configure().Database(MsSqlConfiguration.MsSql2008
                .ConnectionString(c =>
                 c.Server("DESKTOP-9TG6S3I")
                .Database("dbRest")
                .Username("sa")
                .Password("senha")).ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .CurrentSessionContext("call").ExposeConfiguration(cfg => BuildSchema(cfg, create, update))
                .BuildSessionFactory();
        }

        /// <summary>  
        /// Build the schema of the database.  
        /// </summary>  
        /// <param name="config">Configuration.</param>  
        private static void BuildSchema(Configuration config, bool create = false, bool update = false)
        {
            if (create)
            {
                new SchemaExport(config).Create(false, true);
            }
            else
            {
                new SchemaUpdate(config).Execute(false, update);
            }
        }
    }
}
