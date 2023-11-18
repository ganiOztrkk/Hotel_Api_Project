using HotelProject.WebUI.Dtos.Responses.TestimonialDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Components.Default;

public class _TestimonialVC : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _TestimonialVC(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.GetAsync("https://localhost:7095/api/Testimonial");
        var stringJsonData = await apiResponse.Content.ReadAsStringAsync();
        var testimonialList = JsonConvert.DeserializeObject<List<DisplayTestimonialDto>>(stringJsonData);
        return View(testimonialList);
    }
}