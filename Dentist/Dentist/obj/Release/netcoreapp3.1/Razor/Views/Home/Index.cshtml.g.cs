#pragma checksum "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04d3fe31296ca0bd6fe4e5425466a59c04d72172"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04d3fe31296ca0bd6fe4e5425466a59c04d72172", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce10a58e72b6683d8c0ccecdd337a0e65bb2f6ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:506px !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("work-box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"ftco-section ftco-no-pt ftco-no-pb\">\r\n    <div class=\"container\">\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"col-md-5 p-md-5 img img-2 mt-5 mt-md-0\"");
            BeginWriteAttribute("style", " style=\"", 248, "\"", 313, 4);
            WriteAttributeValue("", 256, "background-image:", 256, 17, true);
            WriteAttributeValue(" ", 273, "url(../images/", 274, 15, true);
#nullable restore
#line 10 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
WriteAttributeValue("", 288, Model.WellComing.Image, 288, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 311, ");", 311, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""col-md-7 wrap-about py-4 py-md-5 ftco-animate"">
                <div class=""heading-section mb-5"">
                    <div class=""pl-md-5 ml-md-5 pt-md-5"">
                        <span class=""subheading mb-2"">
                            Добро пожаловать в CK ДEНT
                        </span>
                        <h2 class=""mb-2"" style=""font-size: 32px;"" >");
#nullable restore
#line 18 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                                                              Write(Model.WellComing.WelcomeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                </div>\r\n                <div class=\"pl-md-5 ml-md-5 mb-5\">\r\n                    <p>");
#nullable restore
#line 22 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                  Write(Html.Raw(Model.WellComing.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    <div class=\"founder d-flex align-items-center mt-5\">\r\n                        <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 1058, "\"", 1119, 4);
            WriteAttributeValue("", 1066, "background-image:", 1066, 17, true);
            WriteAttributeValue(" ", 1083, "url(../images/", 1084, 15, true);
#nullable restore
#line 25 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
WriteAttributeValue("", 1098, Model.Doctor.Image, 1098, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1117, ");", 1117, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"text pl-3\">\r\n                            <h3 class=\"mb-0\"> ");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                                         Write(Model.Doctor.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <span class=\"position\">");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                                              Write(Model.Doctor.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section ftco-services"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-2"">
            <div class=""col-md-8 text-center heading-section ftco-animate"">
                
                <h2 class=""mb-4"">
                    Услуги нашей клиники
                </h2>
                
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
             foreach (Treatment treatment in Model.Treatments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4  d-flex services align-self-stretch p-4 ftco-animate\">\r\n                    <div class=\"media block-6 d-block text-center w-100\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2163, "\"", 2230, 1);
#nullable restore
#line 52 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
WriteAttributeValue("", 2170, Url.Action("Detail","Treatment",new { slug=treatment.Slug}), 2170, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"img w-100 rounded-circle\"");
            BeginWriteAttribute("style", " style=\"", 2299, "\"", 2355, 3);
            WriteAttributeValue("", 2307, "background-image:url(../images/", 2307, 31, true);
#nullable restore
#line 53 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
WriteAttributeValue("", 2338, treatment.Image, 2338, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2354, ")", 2354, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        </a>\r\n                        <div class=\"media-body p-2 mt-3\">\r\n                            <h3 class=\"heading text-center\">");
#nullable restore
#line 56 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                                                       Write(treatment.TreatmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                           \r\n                            \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 62 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</section>
<section id=""gallery"" class=""gallery section"" style=""margin-bottom:150px;padding:0px !important"">
    <div class=""container-fluid text-center"">
        <div class=""section-header"">
            <h2 class=""wow fadeInDown animated"">Портфолио</h2>
            <p class=""wow fadeInDown animated"">
                Последние работы наших врачей.
            </p>
        </div>
        <div class=""row ftco-animate justify-content-center"">
            <div class=""col-md-12"">
                <div class=""carousel-testimony owl-carousel"">
");
#nullable restore
#line 78 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                     foreach (Portfolio portfolio in Model.Portfolios)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-12 col-md-6 col-sm-6 work\" style=\"padding-left:0;padding-right:0;height:506px !important\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04d3fe31296ca0bd6fe4e5425466a59c04d7217212143", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "04d3fe31296ca0bd6fe4e5425466a59c04d7217212431", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3642, "~/images/", 3642, 9, true);
#nullable restore
#line 82 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3651, portfolio.Image, 3651, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3554, "~/images/", 3554, 9, true);
#nullable restore
#line 81 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3563, portfolio.Image, 3563, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 85 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-2"">
            <div class=""col-md-8 text-center heading-section ftco-animate"">
                <h2 class=""mb-4"">НАШИ СПЕЦИАЛИСТЫ</h2>
               
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 100 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
             foreach (Doctor doctor in Model.Doctors)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                    <div class=\"staff\">\r\n                        <div class=\"img-wrap d-flex align-items-stretch\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4495, "\"", 4557, 1);
#nullable restore
#line 105 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
WriteAttributeValue("", 4502, Url.Action("Detail","Doctor",new { slug=doctor.Slug }), 4502, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img align-self-stretch\"");
            BeginWriteAttribute("style", " style=\"", 4589, "\"", 4644, 4);
            WriteAttributeValue("", 4597, "background-image:", 4597, 17, true);
            WriteAttributeValue(" ", 4614, "url(../images/", 4615, 15, true);
#nullable restore
#line 105 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
WriteAttributeValue("", 4629, doctor.Image, 4629, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4642, ");", 4642, 2, true);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        </div>\r\n                        <div class=\"text pt-3 text-center\">\r\n                            <h3>");
#nullable restore
#line 108 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                           Write(doctor.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <span class=\"position mb-2\"></span>\r\n                            <div class=\"faded\">\r\n                                <p>");
#nullable restore
#line 111 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                              Write(doctor.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                               \r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 117 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<section class=""ftco-section testimony-section bg-light"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-2"">
            <div class=""col-md-8 text-center heading-section ftco-animate"">
                <span class=""subheading"">Отзывы</span>
                <h2 class=""mb-4"">Наши пациенты говорят о нас</h2>
            </div>
        </div>
        <div class=""row ftco-animate justify-content-center"">
            <div class=""col-md-12"">
                <div class=""carousel-testimony owl-carousel"">
");
#nullable restore
#line 133 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                     foreach (Patient patient in Model.Patient)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"testimony-wrap d-flex\">\r\n                                <div class=\"user-img\"");
            BeginWriteAttribute("style", " style=\"", 5975, "\"", 6030, 4);
            WriteAttributeValue("", 5983, "background-image:", 5983, 17, true);
            WriteAttributeValue(" ", 6000, "url(../images/", 6001, 15, true);
#nullable restore
#line 137 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
WriteAttributeValue("", 6015, patient.Image, 6015, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6029, ")", 6029, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""text pl-4 bg-light"">
                                    <span class=""quote d-flex align-items-center justify-content-center"">
                                        <i class=""icon-quote-left""></i>
                                    </span>
                                    <p>");
#nullable restore
#line 143 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                                  Write(patient.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"name\">");
#nullable restore
#line 144 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                                               Write(patient.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <span class=\"position\">");
#nullable restore
#line 145 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"
                                                      Write(patient.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 149 "C:\Users\Admin\Desktop\DentistBackend\Dentist\Dentist\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04d3fe31296ca0bd6fe4e5425466a59c04d7217222277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        $(\'.slider-banner\').DrSlider({\r\n            \'transition\': \'fade\',\r\n            showNavigation: false,\r\n            progressColor: \"#03A9F4\"\r\n        });\r\n    });\r\n</script> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
