using PubsBusiness.Abstract;
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
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //EfProductDal productDal = new EfProductDal();

            //Business code

            return _productDal.GetAll();
        }
    }
}
