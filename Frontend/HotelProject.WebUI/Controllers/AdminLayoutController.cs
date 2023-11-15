using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers;

public class AdminLayoutController : Controller
{
    // GET
    public IActionResult _AdminLayout()
    {
        return View();
    }
}