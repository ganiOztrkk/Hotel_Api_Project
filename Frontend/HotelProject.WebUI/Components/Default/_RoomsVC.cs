using HotelProject.WebUI.Dtos.Responses.RoomDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Components.Default;

public class _RoomsVC : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _RoomsVC(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.GetAsync("https://localhost:7095/api/Room");
        if (!apiResponse.IsSuccessStatusCode) return View();
        var stringJsonData = await apiResponse.Content.ReadAsStringAsync();
        var roomList = JsonConvert.DeserializeObject<List<DisplayRoomDto>>(stringJsonData);
        return View(roomList);
    }
}