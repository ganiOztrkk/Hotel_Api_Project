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
        var responseMessage =
            await client.GetAsync(
                "https://localhost:7095/api/Staff"); // istek gönderdiğimiz api adresinden dönen mesajı yakaladık
        if (responseMessage.IsSuccessStatusCode) // eğer dönen mesajın status code 200 ise
        {
            var jsonData =
                await responseMessage.Content
                    .ReadAsStringAsync(); //dönen mesajın contentini yani verilerini string olarak okuduk fakat şuan veri json türünde.
            var staffs =
                JsonConvert.DeserializeObject<List<GetStaffVM>>(
                    jsonData); // jsondata ile tuttuğumuz veriyi deserialize ederek list içinde viewmodelimize convert ettik.
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


    public async Task<IActionResult> DeleteStaff(int id)
    {
        //https://{host}/api/Staff?id=4
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.DeleteAsync($"https://localhost:7095/api/Staff?id={id}");
        if (apiResponse.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }


    [HttpGet]
    public async Task<IActionResult> UpdateStaff(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.GetAsync($"https://localhost:7095/api/Staff/{id}");
        if (apiResponse.IsSuccessStatusCode)
        {
            var stringJsonData = await apiResponse.Content.ReadAsStringAsync();
            var staff = JsonConvert.DeserializeObject<UpdateStaffVM>(stringJsonData);
            return View(staff);
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> UpdateStaff(UpdateStaffVM updateStaffVm)
    {
        var client = _httpClientFactory.CreateClient();
        var serializedStaffModel = JsonConvert.SerializeObject(updateStaffVm);
        StringContent stringContent = new StringContent(serializedStaffModel, Encoding.UTF8, "application/json");
        var apiResponse = await client.PutAsync("https://localhost:7095/api/Staff", stringContent);
        if (apiResponse.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}