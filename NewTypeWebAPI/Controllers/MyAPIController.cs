using Microsoft.AspNetCore.Mvc;

namespace NewTypeWebAPI.Controllers
{
    public class ResponseModel
    {
        public string Message { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
    }

    public class MyAPIController : Controller
    {
        public MyAPIController()
        { }

        public IActionResult Index() 
        {
            return Ok();
        }

        //https://www.twilio.com/en-us/blog/distribute-sessions-in-aspdotnet-core
        [HttpGet]
        public IActionResult GetString(string key)
        {
            string temp = string.Empty;

            temp = HttpContext.Session.GetString(key);
            if (string.IsNullOrEmpty(temp))
            {
                temp = string.Empty;
            }

            return Content(temp);
        }

        [HttpGet]
        public IActionResult SetString(string value)
        {
            HttpContext.Session.SetString(value, value);
            return Content("OK");
        }

        public async IAsyncEnumerable<ResponseModel> GetJSONStream()
        {
            yield return new ResponseModel { Id = Guid.NewGuid().ToString(), Message = "aaa3" };
            await Task.Delay(100);
            yield return new ResponseModel { Id = Guid.NewGuid().ToString(), Message = "aaa4" };
            await Task.Delay(100);
            yield return new ResponseModel { Id = Guid.NewGuid().ToString(), Message = "aaa5" };
            await Task.Delay(100);
            yield return new ResponseModel { Id = Guid.NewGuid().ToString(), Message = "aaa6" };
        }
    }
}
