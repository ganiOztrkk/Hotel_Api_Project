using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Requests.LoginDto;

public class LoginUserDto
{
    [Required(ErrorMessage = "Username is Required")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Password is Required")]
    public string Password { get; set; }
}