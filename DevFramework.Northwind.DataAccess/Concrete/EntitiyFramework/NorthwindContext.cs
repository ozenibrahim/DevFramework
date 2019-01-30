using DevFramework.Northwind.DataAccess.Concrete.EntitiyFramework.Mappings;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.EntitiyFramework
{
     public class NorthwindContext:DbContext
    {
        //4.Adım
        public NorthwindContext()
        {
            //Burası benim hazır veri tabanı kullandığım için Initializer değil de SetInitializer kullandığım yer.
            Database.SetInitializer<NorthwindContext>(null);
            //
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //eklenmiş olan entity'ler buraya tanımlanır.
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            //
        }
    }
}
