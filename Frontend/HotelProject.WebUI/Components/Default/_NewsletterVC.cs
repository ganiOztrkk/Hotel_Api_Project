using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _NewsletterVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}