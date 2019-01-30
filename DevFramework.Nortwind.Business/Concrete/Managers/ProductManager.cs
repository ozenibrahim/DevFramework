using DevFramework.Core.Aspects.PostSharp.CacheAspects;
using DevFramework.Core.Aspects.PostSharp.LogAspects;
using DevFramework.Core.Aspects.PostSharp.TransactionAspects;
using DevFramework.Core.Aspects.PostSharp.ValidationAspects;
using DevFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Nortwind.Business.Abstract;
using DevFramework.Nortwind.Business.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Nortwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        //Dependency Injection
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [FluentValidationAspect(typeof(ProductValidatior))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }
        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Delete(int id)
        {
           return _productDal.Delete(id);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }
        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product GetById(int id)
        {
            return _productDal.Get(id);
        }
        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            //Business Codes
            _productDal.Update(product2);
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
