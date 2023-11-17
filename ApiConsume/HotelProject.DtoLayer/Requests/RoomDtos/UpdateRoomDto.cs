using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Requests.RoomDtos;

public class UpdateRoomDto
{
    public int RoomId { get; set; }
    [Required(ErrorMessage = "Room Number is Required")]
    public string? RoomNumber { get; set; }
    [Required(ErrorMessage = "Room Image is Required")]
    public string? RoomCoverImage { get; set; }
    [Required(ErrorMessage = "Room Price is Required")]
    public int Price { get; set; }
    [Required(ErrorMessage = "Room Title is Required")]
    [StringLength(50,ErrorMessage = "Max Title Length is 50")]
    public string? Title { get; set; }
    [Required(ErrorMessage = "Bed Count is Required")]
    public string? BedCount { get; set; }
    [Required(ErrorMessage = "Bath Count is Required")]
    public string? BathCount { get; set; }
    public string? Wifi { get; set; }
    [Required(ErrorMessage = "Description is Required")]
    [StringLength(100,ErrorMessage = "Max Length is 100")]
    public string? Description { get; set; }
}