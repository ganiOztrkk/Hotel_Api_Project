using System.Text;
using HotelProject.WebUI.Models.Staff;
using HotelProject.WebUI.Models.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers;

public class TestimonialController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public TestimonialController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient(); // bir client-istemci oluşturduk.
        var responseMessage =
            await client.GetAsync(
                "https://localhost:7095/api/Testimonial"); // istek gönderdiğimiz api adresinden dönen mesajı yakaladık
        if (responseMessage.IsSuccessStatusCode) // eğer dönen mesajın status code 200 ise
        {
            var jsonData =
                await responseMessage.Content
                    .ReadAsStringAsync(); //dönen mesajın contentini yani verilerini string olarak okuduk fakat şuan veri json türünde.
            var testimonials =
                JsonConvert.DeserializeObject<List<GetTestimonialVM>>(
                    jsonData); // jsondata ile tuttuğumuz veriyi deserialize ederek list içinde viewmodelimize convert ettik.
            return View(testimonials); // ilgili listeyi döndük
        }

        return View();
    }


    [HttpGet]
    public IActionResult AddTestimonial()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddTestimonial(AddTestimonialVM addTestimonialVm)
    {
        var client = _httpClientFactory.CreateClient();
        var stringJsonData = JsonConvert.SerializeObject(addTestimonialVm);
        StringContent stringContent = new StringContent(stringJsonData, Encoding.UTF8, "application/json");
        var apiResponse = await client.PostAsync("https://localhost:7095/api/Testimonial", stringContent);
        if (apiResponse.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }


    public async Task<IActionResult> DeleteTestimonial(int id)
    {
        //https://{host}/api/Staff?id=4
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.DeleteAsync($"https://localhost:7095/api/Testimonial?id={id}");
        if (apiResponse.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }


    [HttpGet]
    public async Task<IActionResult> UpdateTestimonial(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var apiResponse = await client.GetAsync($"https://localhost:7095/api/Testimonial/{id}");
        if (apiResponse.IsSuccessStatusCode)
        {
            var stringJsonData = await apiResponse.Content.ReadAsStringAsync();
            var testimonial = JsonConvert.DeserializeObject<UpdateTestimonialVM>(stringJsonData);
            return View(testimonial);
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialVM updateTestimonialVm)
    {
        var client = _httpClientFactory.CreateClient();
        var serializedStaffModel = JsonConvert.SerializeObject(updateTestimonialVm);
        StringContent stringContent = new StringContent(serializedStaffModel, Encoding.UTF8, "application/json");
        var apiResponse = await client.PutAsync("https://localhost:7095/api/Testimonial", stringContent);
        if (apiResponse.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}