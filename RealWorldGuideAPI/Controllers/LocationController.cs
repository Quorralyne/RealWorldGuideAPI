using System.Web.Http;

namespace RealWorldGuideAPI.Controllers
{
    public class LocationController : ApiController
    {
        // GET: api/Location/Test
        [HttpGet, Route("api/location/test")]
        public string Test()
        {
            return "Hello NDC!";
        }
    }
}
