using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Persistencia.Interfaces;

namespace Persistencia.Contexts.Application
{
    /// <summary>
    /// Change how EF is caching database model definitions. 
    /// By default just the type of the DbContext is used but we need to differentiate the models not just by type but by the schema as well. 
    /// For that we implement the interface IModelCacheKeyFactory.
    /// </summary>
    public class DbSchemaAwareModelCacheKeyFactory : IModelCacheKeyFactory
    {
        public object Create(DbContext context)
        {
            return new
            {
                Type = context.GetType(),
                Schema = context is IDbContextSchema schema ? schema.Schema : null
            };
        }
    }
}
