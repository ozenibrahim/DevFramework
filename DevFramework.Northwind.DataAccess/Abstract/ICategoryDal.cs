using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    //2.Adım
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
