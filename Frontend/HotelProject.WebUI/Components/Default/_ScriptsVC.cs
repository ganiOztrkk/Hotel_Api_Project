using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _ScriptsVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}