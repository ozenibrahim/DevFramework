using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Nortwind.Business.ValidationRules.FluentValidation;
using FluentValidation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Nortwind.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidatior>().InSingletonScope();
        }
    }
}
