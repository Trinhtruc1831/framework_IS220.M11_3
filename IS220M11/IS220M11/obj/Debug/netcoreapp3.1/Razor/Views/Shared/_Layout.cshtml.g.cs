#pragma checksum "D:\Hữu Thắng\FRAMEWORK\framework_IS220.M11_3\IS220M11\IS220M11\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4533eaf4b3a114d703ab02adb316adf242c473e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Hữu Thắng\FRAMEWORK\framework_IS220.M11_3\IS220M11\IS220M11\Views\_ViewImports.cshtml"
using IS220M11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hữu Thắng\FRAMEWORK\framework_IS220.M11_3\IS220M11\IS220M11\Views\_ViewImports.cshtml"
using IS220M11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4533eaf4b3a114d703ab02adb316adf242c473e8", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3cc93fea50f2c373e998cabbc73428e83c956c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" background: url(\'public/assets/img/test.png\') no-repeat center center fixed; background-size: cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4533eaf4b3a114d703ab02adb316adf242c473e83731", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 254, "\"", 264, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 293, "\"", 303, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <title>FindnFound</title>
    <!-- Favicon-->
    <link rel=""icon"" type=""image/x-icon"" href=""public/assets/img/favicon.ico"" />
    <!-- Font Awesome icons (free version)-->
    <script src=""https://use.fontawesome.com/releases/v5.15.3/js/all.js"" crossorigin=""anonymous""></script>
    <!-- Google fonts-->
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Nanum+Gothic:wght@400;800&display=swap"" rel=""stylesheet"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Caveat:wght@400;600;700&display=swap"" rel=""stylesheet"">
    <!-- Core theme CSS (includes Bootstrap)-->
    <link rel=""stylesheet"" href=""public/css/styles.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""public/css/flickity.css"" media=""screen"">
    <!-- jQuery first, then Popper.js, then ");
                WriteLiteral(@"Bootstrap JS -->
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.perfect-scrollbar/0.6.7/js/min/perfect-scrollbar.jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>

");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4533eaf4b3a114d703ab02adb316adf242c473e86867", async() => {
                WriteLiteral(@"
    <!-- Navigation-->
    <!-- Masthead header-->
    <!-- Music Section-->

    <div class=""container"">
        <nav class=""navbar navbar-expand-lg bg-secondary text-uppercase fixed-top "" id=""mainNav"">
            <div class=""container"">
                <a class=""navbar-brand js-scroll-trigger"" href=""#page-top""><img src=""public\assets\img\pagetop.png"" alt=""logo"" title=""Logo""></a>
                <button class=""navbar-toggler navbar-toggler-right text-uppercase font-weight-bold bg-primary text-white rounded"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    Menu
                    <i class=""fas fa-bars""></i>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                    <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item mx-0 mx-lg-1""><a class=""nav-link py-3 px-0 px-lg-3 rounded js-scr");
                WriteLiteral(@"oll-trigger"" href=""index.html"">Home</a></li>
                        <li class=""nav-item mx-0 mx-lg-1""><a class=""nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger"" href=""#about"">About</a></li>
                        <li class=""nav-item mx-0 mx-lg-1""><a class=""nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger"" href=""#donate"">Donate</a></li>
                        <li class=""nav-item mx-0 mx-lg-1""><a class=""nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger"" href=""login.html"">Login</a></li>
                    </ul>
                </div>
            </div>
        </nav>
        <main class=""masthead text-white text-center"">
            ");
#nullable restore
#line 55 "D:\Hữu Thắng\FRAMEWORK\framework_IS220.M11_3\IS220M11\IS220M11\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>

        <!-- Footer-->
        <footer class=""footer"">
            <div class=""container"">
                <div class=""row"">
                    <!-- Footer Location-->
                    <img src=""public\assets\img\cloud.svg"" alt=""Footer"" style=""width:1000px;"" class=""bottom"">
                </div>
            </div>
        </footer>

        <!-- Bootstrap core JS-->
        <!-- audio.js -->
        </script>
        <!-- <script src=""public/js/audio.js""> </script> -->
        <script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js""></script>
        <!-- Third party plugin JS-->
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/animejs/3.2.1/anime.min.js""></script>
        <!-- Core theme JS-->
        <script src=""public/js/scripts.js""></script>
        <!-- Core JS-->
        <!-- <script src=""public/js/audio.js""></script> -->
        <scrip");
                WriteLiteral(@"t src=""public/js/login.js""></script>
        <script src=""public/js/main.js""></script>
        <script src=""public/js/searchNav.js""></script>
        <script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>
        <script src=""public/js/flickity.pkgd.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
