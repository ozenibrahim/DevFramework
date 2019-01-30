using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetails> GetProductDetails();
        Product Get(int id);
        List<Product> GetList();
        Product Update(Product product);
        Product Add(Product product);
        Product Delete(int id);

    }
}
