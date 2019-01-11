using Microsoft.AspNetCore.Mvc;

namespace PipelineSample.Controllers
{
    public class HomeController: Controller
    {
        [Route("")]
        [Route("Home")]
        public string Index()
        {
            return "hello world!!";
        }
    }
}