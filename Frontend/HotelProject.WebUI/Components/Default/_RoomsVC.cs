using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _RoomsVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}