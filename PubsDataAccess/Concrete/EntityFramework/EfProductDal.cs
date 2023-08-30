using PubsDataAccess.Abstract;
using PubsEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubsDataAccess.Concrete
{
    public class EfProductDal :IProductDal
    {
        public List<Product> GetAll()
        {
            using(PubsContext pubsContext = new PubsContext())
            {
                return pubsContext.Products.ToList();
            }
        }
        public Product Get(int id)
        {
            using(PubsContext pubsContext = new PubsContext())
            {
                return pubsContext.Products.SingleOrDefault(productInstance => productInstance.ProductId == id);
            }
        }
        public void Add(Product product)
        {
            using(PubsContext pubsContext = new PubsContext())
            {
                pubsContext.Products.Add(product);
                pubsContext.SaveChanges();
            }

        }
        public void Update(Product product)
        {
            using(PubsContext pubsContext = new PubsContext())
            {
                pubsContext.SaveChanges();
            }
        }
        public void Delete(int productId)
        {

        }
    }
}
