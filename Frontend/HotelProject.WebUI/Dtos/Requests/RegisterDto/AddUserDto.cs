using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Requests.RegisterDto;

public class AddUserDto
{
    [Required(ErrorMessage = "Name is Required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Surname is Required")]
    public string Surname { get; set; }
    [Required(ErrorMessage = "Username is Required")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Mail is Required")]
    public string Mail { get; set; }
    [Required(ErrorMessage = "Password is Required")]
    public string Password { get; set; }
    [Required(ErrorMessage = "Name is Required")]
    [Compare("Password",ErrorMessage = "Password is not Matched")]
    public string ConfirmPassword { get; set; }
}