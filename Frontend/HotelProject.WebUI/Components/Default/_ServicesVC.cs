using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _ServicesVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}