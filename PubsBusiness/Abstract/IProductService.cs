using PubsEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubsBusiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
