#pragma checksum "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/WorkLocation/Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bb44cf4de0438b879d3f2d4118172a08936c401ff44e97b082401dbc948d91d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkLocation_Index), @"mvc.1.0.view", @"/Views/WorkLocation/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Models.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.WorkLocationDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bb44cf4de0438b879d3f2d4118172a08936c401ff44e97b082401dbc948d91d7", @"/Views/WorkLocation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7755824f406077370017210db51b1f808ec9ce9afd5b3a42fde832e3471aee9d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_WorkLocation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultWorkLocationDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/WorkLocation/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table table-bordered\">\n    <tr>\n        <th>#</th>\n        <th>Lokasyon Adı</th>\n        <th>Şehir</th>\n        <th>Sil</th>\n        <th>Güncelle</th>\n    </tr>\n");
#nullable restore
#line 16 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/WorkLocation/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 19 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/WorkLocation/Index.cshtml"
           Write(item.WorkLocationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 20 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/WorkLocation/Index.cshtml"
           Write(item.WorkLocationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/WorkLocation/Index.cshtml"
           Write(item.WorkLocationCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 506, "\"", 566, 2);
            WriteAttributeValue("", 513, "/WorkLocation/DeleteWorkLocation/", 513, 33, true);
#nullable restore
#line 22 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/WorkLocation/Index.cshtml"
WriteAttributeValue("", 546, item.WorkLocationID, 546, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 647, "\"", 707, 2);
            WriteAttributeValue("", 654, "/WorkLocation/UpdateWorkLocation/", 654, 33, true);
#nullable restore
#line 23 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/WorkLocation/Index.cshtml"
WriteAttributeValue("", 687, item.WorkLocationID, 687, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\n        </tr>\n");
#nullable restore
#line 25 "/Users/gani/Desktop/Github/Hotel_Api_Project/Frontend/HotelProject.WebUI/Views/WorkLocation/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<a href=\"/AdminRoom/AddRoom/\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Lokasyon Girişi</a>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultWorkLocationDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591