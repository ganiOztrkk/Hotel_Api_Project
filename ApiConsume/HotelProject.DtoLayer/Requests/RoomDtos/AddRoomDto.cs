using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Requests.RoomDtos;

public class AddRoomDto
{
    [Required(ErrorMessage = "Room Number is Required")]
    public string? RoomNumber { get; set; }
    public string? RoomCoverImage { get; set; }
    [Required(ErrorMessage = "Room Price is Required")]
    public int Price { get; set; }
    [Required(ErrorMessage = "Room Title is Required")]
    public string? Title { get; set; }
    [Required(ErrorMessage = "Bed Count is Required")]
    public string? BedCount { get; set; }
    [Required(ErrorMessage = "Bath Count is Required")]
    public string? BathCount { get; set; }
    public string? Wifi { get; set; }
    public string? Description { get; set; }
}