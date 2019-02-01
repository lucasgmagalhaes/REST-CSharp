using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Contexts
{
    public class DbContextSchema : IDbContextSchema
    {
        public string Schema { get; }

        public DbContextSchema(string schema)
        {
            Schema = schema ?? throw new ArgumentNullException(nameof(schema));
        }
    }
}
