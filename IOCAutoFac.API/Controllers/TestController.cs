using IOCAutofac.Services;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;

namespace IOCAutoFac.API.Controllers
{
    public class TestController : ApiController
    {
        private TestService _testService;

        public TestController(TestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        [Route("watches")]
        public async Task<HttpResponseMessage> GetWatches()
        {
            var watches = await _testService.GetWatches();
            return Request.CreateResponse(
                HttpStatusCode.OK,
                watches,
                JsonMediaTypeFormatter.DefaultMediaType
                );
        }
    }
}
