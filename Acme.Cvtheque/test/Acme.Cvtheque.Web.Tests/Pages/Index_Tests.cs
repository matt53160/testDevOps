using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.Cvtheque.Pages;

public class Index_Tests : CvthequeWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
