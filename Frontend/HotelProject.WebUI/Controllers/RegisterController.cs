using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.Requests.RegisterDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers;

public class RegisterController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public RegisterController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(AddUserDto addUserDto)
    {
        if (!ModelState.IsValid) return View();
        var appUser = new AppUser()
        {
            Name = addUserDto.Name,
            Surname = addUserDto.Surname,
            Email = addUserDto.Mail,
            UserName = addUserDto.Username
        };
        var addUserResult = await _userManager.CreateAsync(appUser, addUserDto.Password);
        if (!addUserResult.Succeeded) return View();
        return RedirectToAction("Index", "Login");
    }
}