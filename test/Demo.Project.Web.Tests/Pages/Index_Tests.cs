using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Demo.Project.Pages
{
    public class Index_Tests : ProjectWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
