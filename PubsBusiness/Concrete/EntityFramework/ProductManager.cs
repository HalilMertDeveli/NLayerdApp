using PubsDataAccess.Concrete;
using PubsEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubsBusiness.Concrete
{
    public class ProductManager
    {
        EfProductDal productDal = new EfProductDal();
        public List<Product> GetAll()
        {
            //Business code
            return productDal.GetAll();
        }
    }
}
