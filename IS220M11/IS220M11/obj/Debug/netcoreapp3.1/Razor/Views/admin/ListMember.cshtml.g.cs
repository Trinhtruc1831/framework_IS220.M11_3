#pragma checksum "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac319c53806b3d39d25caebe50767b00e3fc59a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_admin_ListMember), @"mvc.1.0.view", @"/Views/admin/ListMember.cshtml")]
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
#line 1 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\_ViewImports.cshtml"
using IS220M11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\_ViewImports.cshtml"
using IS220M11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac319c53806b3d39d25caebe50767b00e3fc59a", @"/Views/admin/ListMember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb5b49cc0dbf9bed1e2b06c4b6ed57335b89823f", @"/Views/_ViewImports.cshtml")]
    public class Views_admin_ListMember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IS220M11.Models.accountModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuestInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
  
    ViewData["Title"] = "Admin";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #customers {
        font-family: Arial, Helvetica, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

    #customers td, #customers th {
        border: 1px solid #ddd;
        padding: 8px;
    }


    #customers tr:nth-child(even) {
        background-color: #e7e3d4;
    }

    #customers tr:hover {
        background-color: #ddd;
    }

    #customers th {
        padding-top: 12px;
        padding-bottom: 12px;
        text-align: left;
        background-color: #A88A64;
        color: white;
    }
    #customers td {
        color: #49371f;
    }
</style>
<script  type=""text/javascript"">
                    function alertFunction() {
                        alert(""Hi! Chức năng đang dần được hoàn thiện trong lần nâng cấp tới!"");
                    }
</script>
<div class=""container-fluid px-4"">
    <h1 class=""mt-4"" style=""color: #49371f"">Member management</h1>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ac319c53806b3d39d25caebe50767b00e3fc59a5875", async() => {
                WriteLiteral("\r\n        <p>\r\n            <input type=\"search\" placeholder=\"Enter username or email ...\"");
                BeginWriteAttribute("value", " value=\"", 1214, "\"", 1252, 1);
#nullable restore
#line 48 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
WriteAttributeValue("", 1222, ViewData["Getaccountdetails"], 1222, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Usersearch\" style=\"width:500px;\" />\r\n            <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\" /> |\r\n");
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ac319c53806b3d39d25caebe50767b00e3fc59a6824", async() => {
                    WriteLiteral("Get All User");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <table class=\"table\" id=\"customers\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
           Write(Html.DisplayNameFor(model => model.UName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
           Write(Html.DisplayNameFor(model => model.UType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
           Write(Html.DisplayNameFor(model => model.UStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
           Write(Html.DisplayNameFor(model => model.UEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
           Write(Html.DisplayNameFor(model => model.UPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 73 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
               Write(Html.DisplayFor(modelItem => item.UName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
               Write(Html.DisplayFor(modelItem => item.UType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
               Write(Html.DisplayFor(modelItem => item.UStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
               Write(Html.DisplayFor(modelItem => item.UEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
               Write(Html.DisplayFor(modelItem => item.UPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a onclick=\"alertFunction()\"  href=\"javascript:void(0)\">Ban</a> |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ac319c53806b3d39d25caebe50767b00e3fc59a13399", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
                                                                         WriteLiteral(item.UName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    <a onclick=\"alertFunction()\"  href=\"javascript:void(0)\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 97 "D:\Hữu Thắng\FRAMEWORK\BUỔI 4\framework_IS220.M11_3\IS220M11\IS220M11\Views\admin\ListMember.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IS220M11.Models.accountModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
