using System.Text;
using HotelProject.WebUI.Dtos.Requests.Newsletter;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers;

public class DefaultController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public DefaultController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public IActionResult Index()
    {
        return View();
    }


    [HttpGet]
    public PartialViewResult _NewsletterPV()
    {
        return PartialView();
    }


    [HttpPost]
    public async Task<IActionResult> _NewsletterPV(AddNewsletterDto addNewsletterDto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(addNewsletterDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var apiResponse = await client.PostAsync("https://localhost:7095/api/Subscribe", stringContent);
        if (!apiResponse.IsSuccessStatusCode) return View();
        return RedirectToAction("Index");
    }
}