using System.Threading.Tasks;
using Sadec.Sample.Models.TokenAuth;
using Sadec.Sample.Web.Controllers;
using Shouldly;
using Xunit;

namespace Sadec.Sample.Web.Tests.Controllers
{
    public class HomeController_Tests: SampleWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}