#pragma checksum "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee4407339e666c053dd2b4928c7af065265021c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleEdit), @"mvc.1.0.view", @"/Views/Admin/RoleEdit.cshtml")]
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
#line 2 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/_ViewImports.cshtml"
using ecommerce.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/_ViewImports.cshtml"
using ecommerce.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/_ViewImports.cshtml"
using ecommerce.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/_ViewImports.cshtml"
using ecommerce.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee4407339e666c053dd2b4928c7af065265021c9", @"/Views/Admin/RoleEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d785bead249b9e31b0c8fc74f7b486b0c590de", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mystyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee4407339e666c053dd2b4928c7af065265021c97026", async() => {
                WriteLiteral("\n<title>Rol Güncelleme</title>\n<link rel=\"stylesheet\" href=\"/modules/bootstrap/dist/css/bootstrap.min.css\" crossorigin=\"anonymous\">\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee4407339e666c053dd2b4928c7af065265021c97419", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.4.1/css/all.css\">\n<!--theme-style-->\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee4407339e666c053dd2b4928c7af065265021c98860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"	
<!--//theme-style-->
<meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
<script type=""application/x-javascript""> addEventListener(""load"", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!--fonts-->
<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'>
<!--//fonts-->
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee4407339e666c053dd2b4928c7af065265021c910623", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<!--script-->
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee4407339e666c053dd2b4928c7af065265021c912827", async() => {
                WriteLiteral("\n\t");
#nullable restore
#line 24 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
Write(await Html.PartialAsync("_header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \n\t<div class=\"container\">\n        <h1 class=\"h3\">Rolü Güncelle</h1>\n        <hr>\n        <div class=\"row\">\n            <div class=\"col-md-12\">\n\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee4407339e666c053dd2b4928c7af065265021c913486", async() => {
                    WriteLiteral("\n                    <input type=\"hidden\" name=\"RoleId\"");
                    BeginWriteAttribute("value", " value=\"", 1654, "\"", 1676, 1);
#nullable restore
#line 32 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
WriteAttributeValue("", 1662, Model.Role.Id, 1662, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                    <input type=\"hidden\" name=\"RoleName\"");
                    BeginWriteAttribute("value", " value=\"", 1735, "\"", 1759, 1);
#nullable restore
#line 33 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
WriteAttributeValue("", 1743, Model.Role.Name, 1743, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                    <h6 class=\"bg-info text-white p-1\">");
#nullable restore
#line 34 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                                                  Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" rolüne ekle</h6>\n                    <table class=\"table table-bordered table-sm\">\n");
#nullable restore
#line 36 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                         if(Model.NonMembers.Count()==0)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <tr>\n                                <td colspan=\"2\">Bütün kullanıcılar role ait</td>\n                            </tr>\n");
#nullable restore
#line 41 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                        }else{
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                             foreach (var user in Model.NonMembers)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 45 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n                                <td style=\"width: 150px;\">\n                                        <input type=\"checkbox\" name=\"IdsToAdd\"");
                    BeginWriteAttribute("value", " value=\"", 2511, "\"", 2527, 1);
#nullable restore
#line 47 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
WriteAttributeValue("", 2519, user.Id, 2519, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 50 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </table>\n\n                    <hr>\n\n                    <h6 class=\"bg-info text-white p-1\">");
#nullable restore
#line 56 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                                                  Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" rolünden çıkar</h6>\n                    <table class=\"table table-bordered table-sm\">\n");
#nullable restore
#line 58 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                         if(Model.Members.Count()==0)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <tr>\n                                <td colspan=\"2\">Role ait kullanıcı yok.</td>\n                            </tr>\n");
#nullable restore
#line 63 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                        }else{
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                             foreach (var user in Model.Members)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 67 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\n                                    <td style=\"width: 150px;\">\n                                        <input type=\"checkbox\" name=\"IdsToDelete\"");
                    BeginWriteAttribute("value", " value=\"", 3471, "\"", 3487, 1);
#nullable restore
#line 69 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
WriteAttributeValue("", 3479, user.Id, 3479, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 72 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Admin/RoleEdit.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </table>\n\n                    <button type=\"submit\" class=\"btn btn-primary\">Değişiklikleri Kaydet</button>\n\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n\n            </div>\n        </div>\n\t</div>\n\t<!---->\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
