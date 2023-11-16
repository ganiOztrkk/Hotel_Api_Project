using System.Text;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers;

public class StaffController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public StaffController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient(); // bir client-istemci oluşturduk.
        var responseMessage = await client.GetAsync("https://localhost:7095/api/Staff"); // istek gönderdiğimiz api adresinden dönen mesajı yakaladık
        if (responseMessage.IsSuccessStatusCode) // eğer dönen mesajın status code 200 ise
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();//dönen mesajın contentini yani verilerini string olarak okuduk fakat şuan veri json türünde.
            var staffs = JsonConvert.DeserializeObject<List<GetStaffVM>>(jsonData); // jsondata ile tuttuğumuz veriyi deserialize ederek list içinde viewmodelimize convert ettik.
            return View(staffs); // ilgili listeyi döndük
        }
        return View();
    }


    [HttpGet]
    public IActionResult AddStaff()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddStaff(AddStaffVM addStaffVm)
    {
        var client = _httpClientFactory.CreateClient();
        var stringJsonData = JsonConvert.SerializeObject(addStaffVm);
        StringContent stringContent = new StringContent(stringJsonData, Encoding.UTF8, "application/json");
        var apiResponse = await client.PostAsync("https://localhost:7095/api/Staff", stringContent);
        if (apiResponse.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
    
    
    
    
    
    
    
    
    
}