#pragma checksum "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3f11445d92f35916d1f3529fc5e06d0775f8557"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3f11445d92f35916d1f3529fc5e06d0775f8557", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce10a58e72b6683d8c0ccecdd337a0e65bb2f6ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""hero-wrap hero-wrap-2"" style=""background-image: url('../images/bg_1.jpg');""
         data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <h1 class=""mb-2 bread"">Contact Us</h1>
                <p class=""breadcrumbs"">
                    <span class=""mr-2"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f11445d92f35916d1f3529fc5e06d0775f85575215", async() => {
                WriteLiteral("\r\n                            Home <i class=\"ion-ios-arrow-forward\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </span> <span>
                        Contact <i class=""ion-ios-arrow-forward""></i>
                    </span>
                </p>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section ftco-no-pt ftco-no-pb contact-section"">
    <div class=""container"">
        <div class=""row d-flex align-items-stretch no-gutters"">
            <div class=""col-md-6 p-4 p-md-5 order-md-last bg-light"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f11445d92f35916d1f3529fc5e06d0775f85577151", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Your Name"">
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Your Email"">
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Subject"">
                    </div>
                    <div class=""form-group"">
                        <textarea");
                BeginWriteAttribute("name", " name=\"", 1777, "\"", 1784, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1785, "\"", 1790, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""7"" class=""form-control"" placeholder=""Message""></textarea>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Send Message"" class=""btn btn-primary py-3 px-5"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""mapouter""><div class=""gmap_canvas""><iframe width=""600"" height=""500"" id=""gmap_canvas"" src=""https://maps.google.com/maps?q=%D0%A3%D0%BB.%20%D0%93%D0%B2%D0%B0%D1%80%D0%B4%D0%B5%D0%B9%D1%86%D0%B5%D0%B2%20%D0%A8%D0%B8%D1%80%D0%BE%D0%BD%D0%B8%D1%86%D0%B5%D0%B2%2084%20(2%20%D0%B9%20%D1%8D%D1%82%D0%B0%D0%B6)&t=&z=13&ie=UTF8&iwloc=&output=embed"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0""></iframe><a href=""https://yts-mx.net"">slow</a></div>
            <style>
                .mapouter {
                    position: relative;
                    text-align: right;
                    height: 500px;
                    width: 600px;
                }

                .gmap_canvas {
                    overflow: hidden;
                    background: none !important;
                    height: 500px;
                    width: 600px;
                }
            </style></div>
        </div>
    </div>
</section>
<section class=""ftc");
            WriteLiteral(@"o-section contact-section"">
    <div class=""container"">
        <div class=""row d-flex mb-5 contact-info"">
            <div class=""col-md-12 mb-4"">
                <h2 class=""h4"">Contact Information</h2>
            </div>
            <div class=""w-100""></div>
            <div class=""col-md-4 d-flex"">
                <div class=""bg-light d-flex align-self-stretch box p-4"">
                    <p><span>Address:</span> ");
#nullable restore
#line 76 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Contact\Index.cshtml"
                                        Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4 d-flex\">\r\n                <div class=\"bg-light d-flex align-self-stretch box p-4\">\r\n                    <p><span>Phone:</span> <a");
            BeginWriteAttribute("href", " href=\"", 3774, "\"", 3805, 2);
            WriteAttributeValue("", 3781, "tel://", 3781, 6, true);
#nullable restore
#line 81 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Contact\Index.cshtml"
WriteAttributeValue("", 3787, Model.PhoneNumber, 3787, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Contact\Index.cshtml"
                                                                         Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4 d-flex\">\r\n                <div class=\"bg-light d-flex align-self-stretch box p-4\">\r\n                    <p>\r\n                        <span>Email:");
#nullable restore
#line 87 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Contact\Index.cshtml"
                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <a");
            BeginWriteAttribute("href", " href=\"", 4079, "\"", 4098, 1);
#nullable restore
#line 87 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Contact\Index.cshtml"
WriteAttributeValue("", 4086, Model.Email, 4086, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </a>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
