#pragma checksum "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef11f0f26a131584486a425d1c0ea24f226b6068"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef11f0f26a131584486a425d1c0ea24f226b6068", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce10a58e72b6683d8c0ccecdd337a0e65bb2f6ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""hero-wrap hero-wrap-2"" style=""background-image: url('images/bg_1.jpg');"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <h1 class=""mb-2 bread"">Blog</h1>
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home <i class=""ion-ios-arrow-forward""></i></a></span> <span>Blog <i class=""ion-ios-arrow-forward""></i></span></p>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 20 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
             foreach (Blog blog in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 ftco-animate\">\r\n                    <div class=\"blog-entry\">\r\n                        <a href=\"blog-single.html\" class=\"block-20 d-flex align-items-end justify-content-end\"");
            BeginWriteAttribute("style", " style=\"", 1079, "\"", 1134, 4);
            WriteAttributeValue("", 1087, "background-image:", 1087, 17, true);
            WriteAttributeValue(" ", 1104, "url(\'../images/", 1105, 16, true);
#nullable restore
#line 24 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1120, blog.Image, 1120, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1131, "\');", 1131, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"meta-date text-center p-2\">\r\n                                <span class=\"day\">");
#nullable restore
#line 26 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                                             Write(blog.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"mos\">");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                                             Write(blog.Date.ToString("MMMM",new System.Globalization.CultureInfo("ru")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"yr\">");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                                            Write(blog.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </a>\r\n                        <div class=\"text bg-white p-4\">\r\n                            <h3 class=\"heading\"><a href=\"#\">");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                                                       Write(blog.BlogName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                                 if (blog.Description.Length > 95)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                                     Write(blog.Description.Substring(0, 95));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span>...</span>\r\n");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                               Write(blog.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                                                     ;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </p>
                            <div class=""d-flex align-items-center mt-4"">
                                <p class=""mb-0""><a href=""#"" class=""btn btn-primary"">Read More <span class=""ion-ios-arrow-round-forward""></span></a></p>
                                <p class=""ml-auto mb-0"">
                                    <a href=""#"" class=""mr-2"">");
#nullable restore
#line 46 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
                                                        Write(blog.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 52 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""row no-gutters my-5"">
            <div class=""col text-center"">
                <div class=""block-27"">
                    <ul>
                        <li class=""active""><span>1</span></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#"">4</a></li>
                        <li><a href=""#"">5</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
