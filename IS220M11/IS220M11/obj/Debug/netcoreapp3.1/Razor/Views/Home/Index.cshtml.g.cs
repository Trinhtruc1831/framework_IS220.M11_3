#pragma checksum "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e086a7d52bdb82fd63eb0ef638a051500abe2d05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\_ViewImports.cshtml"
using IS220M11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\_ViewImports.cshtml"
using IS220M11.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
using static System.Console;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e086a7d52bdb82fd63eb0ef638a051500abe2d05", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb5b49cc0dbf9bed1e2b06c4b6ed57335b89823f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("masthead-avatar mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/public/assets/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("chatForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <header class=\"text-white text-center\">\r\n        <div class=\"container d-flex align-items-center flex-column \">\r\n            <!-- Masthead Avatar Image-->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e086a7d52bdb82fd63eb0ef638a051500abe2d058360", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </header>\r\n</div>\r\n<!-- Recommeded Section-->\r\n\r\n<section class=\"page-section py-5\">\r\n    <!-- Flickity HTML init -->\r\n\r\n    <div class=\"gallery js-flickity\" style=\"margin-left: 10%;margin-right: 10%\">\r\n");
#nullable restore
#line 24 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
         foreach (object item in Model.Posts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"gallery-cell\" style=\"margin-left: 20px;margin-right: 10px\">\r\n                <div class=\"card h-460px\" style=\"width: 200px;height: 300px; right: 230% !important;\">\r\n                    <!-- Product image-->\r\n");
#nullable restore
#line 29 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
                      
                        var utf8 = System.Text.Encoding.UTF8;
                        string title = @item.GetType().GetProperty("tit").GetValue(item, null).ToString();
                        int lentit = title.Length; ;
                        if (lentit > 30)
                        {
                            title = title.Substring(0, 27) + "....";
                            byte[] utfBytes = utf8.GetBytes(title);
                            title = utf8.GetString(utfBytes);
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1565, "\"", 1628, 1);
#nullable restore
#line 40 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
WriteAttributeValue("", 1571, item.GetType().GetProperty("tnpic").GetValue(item, null), 1571, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""..."" />
                    <!-- Product details-->
                    <div class=""card-body p-4"" style=""height:300px"">
                        <div class=""text-center"" style=""height:125px"">
                            <!-- Product name-->
                            <a href=""post.html"" class=""fw-bolder h-60px h5"" style=""color: #49371f;"">");
#nullable restore
#line 45 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
                                                                                               Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                        <div class=\"text-center\">\r\n                            <!-- Product price-->\r\n                            <p style=\"color: #49371f;font-size:18px!important\">~");
#nullable restore
#line 49 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
                                                                           Write(String.Format("{0:n0}", @item.GetType().GetProperty("price").GetValue(item, null)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"vnđ</p>
                        </div>
                    </div>
                    <!-- Product actions-->
                    <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                        <div class=""text-center""><a class=""btn btn-outline-dark mt-auto""");
            BeginWriteAttribute("href", " href=\"", 2576, "\"", 2614, 1);
#nullable restore
#line 54 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
WriteAttributeValue("", 2583, Url.Action("Login", "account"), 2583, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 58 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n<!-- Chatbox Section-->\r\n<section class=\"page-section text-white mb-0\" id=\"chatbox\">\r\n    <div class=\"containerchat\" style=\"background-size: 100% 100%; background-image: url(\'/public/assets/img/chatbox.png\')\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e086a7d52bdb82fd63eb0ef638a051500abe2d0514260", async() => {
                WriteLiteral(@"
            <p style=""margin-left: 3.1%"">
                <input type=""hidden"" id=""mess"" name=""mess"">
                <input type=""hidden"" id=""user"" name=""user"">
                <input type=""hidden"" id=""day"" name=""day"">
                <input class=""textbox"" type=""text"" id=""messageInput"">
                <a");
                BeginWriteAttribute("href", " href=\"", 3373, "\"", 3411, 1);
#nullable restore
#line 70 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
WriteAttributeValue("", 3380, Url.Action("Login", "account"), 3380, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><input style=""width:9%;background-color: #a88a64; border-width: 2px; color: #f5f3f3ef;border-radius: 8px;margin-bottom: 15px;padding-bottom: 0.6%;padding-left: 0.9%;padding-top: 0.5%;"" type=""button"" value=""Send"" /></a>
            </p>
            <ul class=""ul-chat"" id=""messagesList"" style=""text-align:left !important"">
");
#nullable restore
#line 73 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
                 foreach (object item in Model.Chats)
                {
                    var user = @item.GetType().GetProperty("user").GetValue(item, null).ToString();
                    var mess = @item.GetType().GetProperty("mess").GetValue(item, null).ToString();
                    var date = @item.GetType().GetProperty("date").GetValue(item, null).ToString();
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("<li class=\"li-chat\">");
#nullable restore
#line 78 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
                                   Write(date);

#line default
#line hidden
#nullable disable
                WriteLiteral("<a");
                BeginWriteAttribute("href", " href=\"", 4162, "\"", 4200, 1);
#nullable restore
#line 78 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
WriteAttributeValue("", 4169, Url.Action("Login", "account"), 4169, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 78 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
                                                                                  Write(user);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</a> ");
#nullable restore
#line 78 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
                                                                                             Write(mess);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 79 "C:\Users\19521\source\repos\framework_IS220.M11_3\IS220M11\IS220M11\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>            \r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </div>
</section>



<!-- Blank -->
<section class=""page-section text-white mb-0"" style=""background-size: 100% 100%; background-image: url('public/assets/img/plank.png');  "" id=""chatbox""></section>
<!-- About Section-->
<section class=""page-section text-white mb-0"" style=""background-size: 100% 100%; background-image: url('public/assets/img/about.png');  "" id=""about"">
    <div class=""container"">
        <!-- About Section Heading-->
        <h5 class=""page-section-heading text-center text-light text-uppercase "" style=""font-family: 'Caveat', cursive; font-size: 3.5rem;margin-top: 150px"">About us</h5>

        <!-- About Section Content-->
        <div class=""row"">
            <div class=""col-12"">
                <p class=""lead text-light"" style=""text-align: center; font-family: 'Caveat', cursive; font-size: 3rem;  "">We are relaxing, not doing anything special, yet content with ourselves.</p>
            </div>

        </div>

    </div>
</section>
<!-- Donate Section-->
<section");
            WriteLiteral(@" class=""page-section"" id=""donate"">
    <div class=""container"">
        <!-- Donate Section Heading-->
        <h2 class="" text-center text-secondary mb-0"" style=""font-size: 1.5rem;"">Buy us a coffee ☕</h2>
        <!-- Icon Divider-->
        <br>
        <br>
        <img src=""public/assets/img/donate.png"" alt=""Girl in a jacket"" style=""width:100px;"" class=""center"">
    </div>
    </div>
</section>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e086a7d52bdb82fd63eb0ef638a051500abe2d0520934", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e086a7d52bdb82fd63eb0ef638a051500abe2d0521975", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
