using HotelProject.WebUI.Dtos.Responses.AboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Components.Default;

public class _AboutVC : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _AboutVC(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.GetAsync("https://localhost:7095/api/About");
        if (!apiResponse.IsSuccessStatusCode) return View();
        var jsonStringData = await apiResponse.Content.ReadAsStringAsync();
        var aboutList = JsonConvert.DeserializeObject<List<DisplayAboutDto>>(jsonStringData);
        return View(aboutList);
    }
}