﻿using DevFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
     public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Products");

            LazyLoad();
            Id(x => x.ProductId).Column("ProductID");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.CategoryId).Column("CategoryID");
            Map(x => x.QuentityPerUnit).Column("QuentityPerUnit");
            Map(x => x.UnitPrice).Column("UnitePrice");
        }
    }
}
