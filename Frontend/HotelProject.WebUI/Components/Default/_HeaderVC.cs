using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _HeaderVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}