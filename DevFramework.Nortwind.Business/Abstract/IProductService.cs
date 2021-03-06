﻿using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Nortwind.Business.Abstract
{
     public interface IProductService
    {

        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Delete(int id);
        Product Update(Product product);
    }
}
