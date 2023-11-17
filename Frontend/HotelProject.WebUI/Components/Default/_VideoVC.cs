using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _VideoVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}