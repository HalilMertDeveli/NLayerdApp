using PubsDataAccess.Abstract;
using PubsEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubsDataAccess.Concrete.Hibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product{
                    ProductId=1,
                    CategoryID=1,
                    ProductName="Laptop",
                    UnitPrice=3000, 
                    QuantityPerUnit = "1 Stack in box ",
                    UnitsInStock=11 
                },
                new Product
                {
                    ProductId=2,
                    CategoryID=1,
                    ProductName="Phone",
                    UnitPrice=2000,
                    QuantityPerUnit="One Phone in Box",
                    UnitsInStock=8
                }
            };

            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
