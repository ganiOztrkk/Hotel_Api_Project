using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _FooterVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}