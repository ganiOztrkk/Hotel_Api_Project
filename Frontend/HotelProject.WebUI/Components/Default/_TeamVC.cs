using HotelProject.WebUI.Dtos.Responses.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Components.Default;

public class _TeamVC : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _TeamVC(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.GetAsync("https://localhost:7095/api/Staff");
        if (!apiResponse.IsSuccessStatusCode) return View();
        var stringJsonData = await apiResponse.Content.ReadAsStringAsync();
        var staffList = JsonConvert.DeserializeObject<List<DisplayStaffDto>>(stringJsonData);
        return View(staffList);
    }
}