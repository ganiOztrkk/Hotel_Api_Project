using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Requests.ServiceDto;

public class UpdateServiceDto
{
    public int ServiceId { get; set; }
    [Required(ErrorMessage = "Write Icon Url")]
    public string? ServiceIcon { get; set; }
    [Required(ErrorMessage = "Service Title is Required")]
    public string? Title { get; set; }
    [Required(ErrorMessage = "Service Description is Required")]
    public string? Description { get; set; }
}