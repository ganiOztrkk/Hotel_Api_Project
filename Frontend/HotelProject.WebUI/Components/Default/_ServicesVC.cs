using HotelProject.WebUI.Dtos.Responses.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Components.Default;

public class _ServicesVC : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _ServicesVC(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.GetAsync("https://localhost:7095/api/Service");
        if (!apiResponse.IsSuccessStatusCode) return View();
        var stringJsonData = await apiResponse.Content.ReadAsStringAsync();

        var serviceList = JsonConvert.DeserializeObject<List<DisplayServiceDto>>(stringJsonData);
        return View(serviceList);
    }
}