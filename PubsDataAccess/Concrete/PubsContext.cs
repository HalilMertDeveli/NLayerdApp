using PubsEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubsDataAccess.Concrete
{
    public  class PubsContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
