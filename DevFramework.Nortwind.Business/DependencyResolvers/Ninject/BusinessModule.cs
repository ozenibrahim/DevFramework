using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.DataAccess.Concrete.EntitiyFramework;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using DevFramework.Nortwind.Business.Abstract;
using DevFramework.Nortwind.Business.Concrete.Managers;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Nortwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            Bind(typeof(IQeryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();

            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
