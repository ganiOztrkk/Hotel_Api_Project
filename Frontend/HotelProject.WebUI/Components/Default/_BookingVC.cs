using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _BookingVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}