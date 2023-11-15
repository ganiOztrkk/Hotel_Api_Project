using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers;

public class StaffController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}