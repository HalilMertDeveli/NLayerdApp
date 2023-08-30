using PubsDataAccess.Abstract;
using PubsDataAccess.Concrete;
using PubsDataAccess.Concrete.Hibernate;
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
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        EfProductDal productDal = new EfProductDal();
        public List<Product> GetAll()
        {
            //Business code
            return _productDal.GetAll();
        }
    }
}
