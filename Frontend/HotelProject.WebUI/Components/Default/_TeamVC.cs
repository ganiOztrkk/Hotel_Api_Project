using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _TeamVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}