#pragma checksum "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b4f7b60b3545bba544fad1ebf250ad37d4eb80f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Basket), @"mvc.1.0.view", @"/Views/Home/Basket.cshtml")]
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
#line 1 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b4f7b60b3545bba544fad1ebf250ad37d4eb80f", @"/Views/Home/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
  
    ViewData["Title"] = "Basket";
    Random rand = new Random();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b4f7b60b3545bba544fad1ebf250ad37d4eb80f3627", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title></title>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b4f7b60b3545bba544fad1ebf250ad37d4eb80f4658", async() => {
                WriteLiteral(@"

    <br />
    <!--Section: Block Content-->
    <section>

        <!--Grid row-->
        <div class=""row"">

            <!--Grid column-->
            <div class=""col-lg-8"">

                <!-- Card -->
                <div class=""card wish-list mb-3"">
                    <div class=""card-body"">

                        <h5 class=""mb-4""></h5>

                        <div class=""row mb-4"">
                            <div class=""col-md-5 col-lg-3 col-xl-3"">
                                <div class=""view zoom overlay z-depth-1 rounded mb-3 mb-md-0"">
                                    <img class=""img-fluid w-100""");
                BeginWriteAttribute("src", "\r\n                                         src=\"", 833, "\"", 906, 2);
                WriteAttributeValue("", 881, "/", 881, 1, true);
#nullable restore
#line 38 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
WriteAttributeValue("", 882, ViewBag.product.picture, 882, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""Sample"">
                                    <a href=""#!"">
                                    </a>
                                </div>
                            </div>
                            <div class=""col-md-7 col-lg-9 col-xl-9"">
                                <div>
                                    <div class=""d-flex justify-content-between"">
                                        <div>
                                            <h5>");
#nullable restore
#line 47 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
                                           Write(ViewBag.product.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                            <p class=\"mb-3 text-muted text-uppercase small\">Гарантия по чеку: ");
#nullable restore
#line 48 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
                                                                                                         Write(ViewBag.WarrantyDuration);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                        </div>

                                    </div>

                                    <div class=""d-flex justify-content-between align-items-center"">
                                        <p class=""mb-0""><span><strong>");
#nullable restore
#line 54 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
                                                                 Write(ViewBag.product.price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ₽</strong></span></p>
                                    </div>

                                    <div class=""form-check form-switch"">
                                        <input name=""delivery"" onclick=""showList()"" class=""form-check-input"" type=""checkbox"" id=""flexSwitchCheckChecked"">
                                        <label class=""form-check-label"" for=""flexSwitchCheckChecked"">Доставка курьером: ");
#nullable restore
#line 59 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
                                                                                                                   Write(ViewBag.ShippingCost);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </label>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <hr class=""mb-4"">

                    </div>
                </div>
                <!-- Card -->
                <!-- Card -->
                <div class=""card mb-3"">
                    <div class=""card-body"">

                        <h5 class=""mb-4"">Ожидаемое время доставки</h5>

                        <p class=""mb-0"">");
#nullable restore
#line 76 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
                                   Write(DateTime.Now.ToString("dd MMMM"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 76 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
                                                                       Write(DateTime.Now.AddDays(rand.Next(0, 10)).ToString("dd MMMM"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                    </div>
                </div>
                <!-- Card -->


            </div>
            <!--Grid column-->
            <!--Grid column-->
            <div class=""col-lg-4"">

                <!-- Card -->
                <div class=""card mb-3"">
                    <div class=""card-body"">

                        <h5 class=""mb-3"">Корзина</h5>

                        <ul class=""list-group list-group-flush"">

                            <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3"">
                                <div>
                                    <strong>Итоговая сумма:</strong>
                                    <p class=""mb-0"">(без учета доставки)</p>
                                </div>
                                <span><strong name=""price"">");
#nullable restore
#line 100 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
                                                      Write(ViewBag.product.price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></span>
                            </li>
                        </ul>

                        <button type=""button"" href=""/Home"" data-toggle=""modal"" data-target=""#exampleModal"" class=""btn btn-primary btn-block waves-effect waves-light"">Купить</button>

                    </div>
                </div>
                <!-- Card -->


            </div>
            <!--Grid column-->

        </div>
        <!--Grid row-->
        <!-- Modal -->
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Покупка</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
       ");
                WriteLiteral(@"                 </button>
                    </div>
                    <div class=""modal-body"">
                        Покупка прошла успешно.<br />
                        Удачного дня!
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" onclick=""document.location.replace('/Home');"" data-dismiss=""modal"">Ок</button>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--Section: Block Content-->

    <script>
        var element = document.querySelector('.form-check-input');
        var price = document.querySelector('[name=""price""]');
        function showList() {
            var val = price.innerHTML;
            if (element.checked) { val = val.replace("" "", """") + ""+"" + ");
#nullable restore
#line 144 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
                                                                 Write(ViewBag.ShippingCost);

#line default
#line hidden
#nullable disable
                WriteLiteral("; }\r\n            else { val = val.replace(\" \", \"\") + \"-\" + ");
#nullable restore
#line 145 "C:\Users\Ryaba\Desktop\учеба 3 курс\оаипПаттерн\WebApplication1\WebApplication1\Views\Home\Basket.cshtml"
                                                 Write(ViewBag.ShippingCost);

#line default
#line hidden
#nullable disable
                WriteLiteral("; };\r\n            val = val.replace(\"₽\", \"\");\r\n            price.innerHTML = (eval(val).toString()).replace(/(\\d)(?=(\\d{3})+(\\D|$))/g, \'$1 \') + \" ₽\"\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
