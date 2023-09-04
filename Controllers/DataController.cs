using Api_Client.Interface;
using Api_Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_Client.Controllers
{
    public class DataController : Controller
    {
        private readonly IHttpInterface _httpInterface;
        public DataController(IHttpInterface httpInterface)
        {
            _httpInterface = httpInterface;
        }

        public IActionResult Index()
        {
            List<DataModel> model = new();
            var data = _httpInterface.GetData<DataModel>();
            // (data is null) ? NotFound(data) : Ok(data);

                if(data == null)
            {
                return NotFound();
            }
            return View(model);
        } 
    }
}
