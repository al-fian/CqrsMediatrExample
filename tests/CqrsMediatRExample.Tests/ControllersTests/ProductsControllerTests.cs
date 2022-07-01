using CqrsMediatrExample.Controllers;
using CqrsMediatrExample.Data;
using CqrsMediatrExample.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsMediatRExample.Tests.ControllersTests
{
    public class ProductsControllerTests
    {

        [Fact]
        public async Task GetAllProducts_WhenCalled_ReturnsAllProductsWithOk()
        {

            var mediator = new Mock<IMediator>();
            var controller = new ProductsController(mediator.Object);

            var result = await controller.GetAllProducts();

            Assert.NotNull(result);
            var list = Assert.IsType<OkObjectResult>(result);
            var newList = list as ObjectResult;
            Assert.IsType<Product[]>(newList.Value);
        }
    }
}
