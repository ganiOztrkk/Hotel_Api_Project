using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Requests.ServiceDto;

public class AddServiceDto
{
    [Required(ErrorMessage = "Write Icon Url")]
    public string? ServiceIcon { get; set; }
    [Required(ErrorMessage = "Service Title is Required")]
    public string? Title { get; set; }
    public string? Description { get; set; }
}