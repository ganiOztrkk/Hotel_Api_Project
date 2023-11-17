using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Components.Default;

public class _SpinnerVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}