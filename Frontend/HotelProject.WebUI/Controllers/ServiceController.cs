using System.Text;
using HotelProject.WebUI.Dtos.Requests.ServiceDto;
using HotelProject.WebUI.Dtos.Responses.ServiceDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers;

public class ServiceController : Controller
{
    // GET
    private readonly IHttpClientFactory _httpClientFactory;

    public ServiceController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient(); // bir client-istemci oluşturduk.
        var apiResponse =
            await client.GetAsync(
                "https://localhost:7095/api/Service"); // istek gönderdiğimiz api adresinden dönen mesajı yakaladık
        if (apiResponse.IsSuccessStatusCode) // eğer dönen mesajın status code 200 ise
        {
            var jsonData =
                await apiResponse.Content
                    .ReadAsStringAsync(); //dönen mesajın contentini yani verilerini string olarak okuduk fakat şuan veri json türünde.
            var services =
                JsonConvert.DeserializeObject<List<DisplayServiceDto>>(
                    jsonData); // jsondata ile tuttuğumuz veriyi deserialize ederek list içinde viewmodelimize convert ettik.
            return View(services); // ilgili listeyi döndük
        }

        return View();
    }

    [HttpGet]
    public IActionResult AddService()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddService(AddServiceDto addServiceDto)
    {
        if (!ModelState.IsValid) return View();

        var client = _httpClientFactory.CreateClient();
        var stringJsonData = JsonConvert.SerializeObject(addServiceDto);
        StringContent stringContent = new StringContent(stringJsonData, Encoding.UTF8, "application/json");
        var apiResponse = await client.PostAsync("https://localhost:7095/api/Service", stringContent);
        
        if (apiResponse.IsSuccessStatusCode)
            return RedirectToAction("Index");
        return View();
    }
    
    public async Task<IActionResult> DeleteService(int id)
    {
        //https://{host}/api/Staff?id=4
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.DeleteAsync($"https://localhost:7095/api/Service?id={id}");
        if (apiResponse.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> UpdateService(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.GetAsync($"https://localhost:7095/api/Service/{id}");
        if (apiResponse.IsSuccessStatusCode)
        {
            var stringJsonData = await apiResponse.Content.ReadAsStringAsync();
            var service = JsonConvert.DeserializeObject<UpdateServiceDto>(stringJsonData);
            return View(service);
        }
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
    {
        var client = _httpClientFactory.CreateClient();
        var serializedStaffModel = JsonConvert.SerializeObject(updateServiceDto);
        StringContent stringContent = new StringContent(serializedStaffModel, Encoding.UTF8, "application/json");
        var apiResponse = await client.PutAsync("https://localhost:7095/api/Service", stringContent);
        if (apiResponse.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
}












