using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers;

public class RoomController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}