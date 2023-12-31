﻿using PubsEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubsDataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);

        void Update(Product product);
        void Delete(int productId);

    }
}
