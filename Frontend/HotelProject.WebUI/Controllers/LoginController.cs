using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.Requests.LoginDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers;

public class LoginController : Controller
{
    private readonly SignInManager<AppUser> _signInManager;

    public LoginController(SignInManager<AppUser> signInManager)
    {
        _signInManager = signInManager;
    }

    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(LoginUserDto loginUserDto)
    {
        if (!ModelState.IsValid) return View();
        
        var loginResult = await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false, false);
        if (!loginResult.Succeeded) return View();
        return RedirectToAction("Index", "Staff");
    }
}