using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _HeadVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}