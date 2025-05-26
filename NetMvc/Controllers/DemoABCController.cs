using Microsoft.AspNetCore.Mvc;
namespace NetMvc.Controllers;

public class DemoABCController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index
}