#pragma checksum "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Doctor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6833fd85b3d4afe5d85cb66cdf2dad9ae2c23256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Index), @"mvc.1.0.view", @"/Views/Doctor/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\_ViewImports.cshtml"
using Dentist;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\_ViewImports.cshtml"
using Dentist.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\_ViewImports.cshtml"
using Dentist.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6833fd85b3d4afe5d85cb66cdf2dad9ae2c23256", @"/Views/Doctor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce10a58e72b6683d8c0ccecdd337a0e65bb2f6ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Doctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Doctor\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""hero-wrap hero-wrap-2"" style=""background-image: url('../images/bg_1.jpg');"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <h1 class=""mb-2 bread"">
                    Наш Стоматолог
                </h1>
                <p class=""breadcrumbs"">
                    <span class=""mr-2""><a href=""index.html"">Главная <i class=""ion-ios-arrow-forward""></i></a></span> <span>
                        Стоматологи <i class=""ion-ios-arrow-forward""></i>
                    </span>
                </p>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Doctor\Index.cshtml"
             foreach (Doctor doctor in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                    <div class=\"staff\">\r\n                        <div class=\"img-wrap d-flex align-items-stretch\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1224, "\"", 1286, 1);
#nullable restore
#line 30 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 1231, Url.Action("Detail","Doctor",new { slug=doctor.Slug }), 1231, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img align-self-stretch\"");
            BeginWriteAttribute("style", " style=\"", 1318, "\"", 1373, 4);
            WriteAttributeValue("", 1326, "background-image:", 1326, 17, true);
            WriteAttributeValue(" ", 1343, "url(../images/", 1344, 15, true);
#nullable restore
#line 30 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 1358, doctor.Image, 1358, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1371, ");", 1371, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                               \r\n                            </a>\r\n                           \r\n                        </div>\r\n                        <div class=\"text pt-3 text-center\">\r\n                            <h3>Dr. ");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Doctor\Index.cshtml"
                               Write(doctor.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <span class=\"position mb-2\">");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Doctor\Index.cshtml"
                                                   Write(doctor.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                           \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Doctor\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
