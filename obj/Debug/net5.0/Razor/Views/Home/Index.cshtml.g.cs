#pragma checksum "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "091ec3934680cefe02adeacd3685f493cc7a7be6"
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
#line 1 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\_ViewImports.cshtml"
using finalApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\_ViewImports.cshtml"
using finalApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"091ec3934680cefe02adeacd3685f493cc7a7be6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11144ffb3a5f110509e34e44697de62f0d0804bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"slider\">\r\n");
#nullable restore
#line 8 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h2>");
#nullable restore
#line 11 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
           Write(item.CarName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h3>");
#nullable restore
#line 12 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
           Write(item.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 240, "\"", 262, 1);
#nullable restore
#line 13 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 246, item.CarPicture, 246, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 263, "\"", 282, 1);
#nullable restore
#line 13 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 269, item.CarName, 269, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a href=\"#offer\"><i class=\"fas fa-chevron-down\"></i> Oferta <i class=\"fas fa-chevron-down\"></i></a>\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n<section class=\"offer\" id=\"offer\">\r\n    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 22 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\'col-xs-12 col-sm-6 col-lg-4 card--selected\'>\r\n                    <div class=\'card\'>\r\n                        <img");
            BeginWriteAttribute("src", " src=\'", 709, "\'", 731, 1);
#nullable restore
#line 26 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 715, item.CarPicture, 715, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\'", 732, "\'", 751, 1);
#nullable restore
#line 26 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 738, item.CarName, 738, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091ec3934680cefe02adeacd3685f493cc7a7be67781", async() => {
                WriteLiteral("\r\n                            <!--<input type=\'hidden\' name=\'id\' value=\'<%= i%>\'></input>-->\r\n                            <span>Marka: ");
#nullable restore
#line 29 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
                                    Write(item.CarName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <span>Model: ");
#nullable restore
#line 30 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
                                    Write(item.CarModel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <span>Pochodzenie: ");
#nullable restore
#line 31 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
                                          Write(item.CarOrigin);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <span>Rok produkcji: ");
#nullable restore
#line 32 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
                                            Write(item.CarYear);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <span>Cena: ");
#nullable restore
#line 33 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
                                   Write(item.CarPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" zł/dzień</span>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091ec3934680cefe02adeacd3685f493cc7a7be69696", async() => {
                    WriteLiteral("Więcej <i class=\'fas fa-chevron-right\'></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
                                                                                              WriteLiteral(item.CarId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 27 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 793, Url.Action("Details", "Car"), 793, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\BaXTeR\Desktop\final\finalApp\finalApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
