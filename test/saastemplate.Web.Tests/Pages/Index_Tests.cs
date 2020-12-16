using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace saastemplate.Pages
{
    public class Index_Tests : saastemplateWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
