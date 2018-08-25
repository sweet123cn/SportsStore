using Moq;
using SportsStore.WebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStore.WebApp.App_Start
{
    public class AutofacConfig
    {
        private object kernel;

        private void AddBindings()
        {
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>
            {          
              new Product { Name = "Football", Price = 25 },
              new Product { Name = "Surf board", Price = 179 },
              new Product { Name = "Running shoes", Price = 95 }
            });
            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
    }
}