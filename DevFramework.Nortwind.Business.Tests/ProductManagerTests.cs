using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Nortwind.Business.Concrete.Managers;
using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;

namespace DevFramework.Nortwind.Business.Tests
{
    
    [TestClass]
    public class ProductManagerTests
    {        
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            productManager.Add(new Product());
        }
    }
}
