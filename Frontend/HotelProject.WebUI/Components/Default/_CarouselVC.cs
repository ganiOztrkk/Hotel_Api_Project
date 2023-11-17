using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _CarouselVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}