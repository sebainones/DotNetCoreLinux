using Microsoft.AspNetCore.Mvc;

namespace Reminders.Web.Controllers
{
    [Route ("api/[controller]")]
    [ResponseCache (Duration = 3600)]
    public class AddressController : Controller 
    {
        [HttpGet("/api/Address/", Name = "GetAddress")]
        public IActionResult GetAction () 
        {
            return Ok ("This will be a list of Addresses");
        }
    }
}