using AspNetCoreWebApplication.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApplicationTest.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = (ViewResult) controller.Index();
            Assert.Single(result.ViewData);
            Assert.Equal("", result.ViewData["Message"]);
        }

        [Fact]
        public void ErrorTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = (ViewResult)controller.Error();
            Assert.Single(result.ViewData);
            Assert.Equal("", result.ViewData["Message"]);
        }
    }
}
