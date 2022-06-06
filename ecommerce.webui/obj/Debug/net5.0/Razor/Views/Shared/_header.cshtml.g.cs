#pragma checksum "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0882c12efb152a1558a158280634ed4c2f3f0507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__header), @"mvc.1.0.view", @"/Views/Shared/_header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0882c12efb152a1558a158280634ed4c2f3f0507", @"/Views/Shared/_header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d785bead249b9e31b0c8fc74f7b486b0c590de", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""header"">
    <div class=""navbar navbar-dark navbar-expand-sm"" style=""background: #F97E76;"">
        <div class=""container"">
            <a href=""/"" class=""navbar-brand"">Anasayfa</a>
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item"">
                    <a href=""/products"" class=""nav-link"">Ürünler</a>
                </li>
");
#nullable restore
#line 9 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml"
                 if(User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\n                        <a href=\"/orders\" class=\"nav-link\">Siparişlerim</a>\n                    </li>                        \n");
#nullable restore
#line 14 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml"

                    if(User.IsInRole("admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                         <li class=""nav-item"">
                        <a href=""/admin/products"" class=""nav-link"">Yönetici Ürünleri</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/admin/categories"" class=""nav-link"">Yönetici Kategorileri</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/admin/role/list"" class=""nav-link"">Roller</a>
                        </li>
                         <li class=""nav-item"">
                            <a href=""/admin/user/list"" class=""nav-link"">Kullanıcılar</a>
                        </li>
");
#nullable restore
#line 29 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml"
                    }                      
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n    </div>\n    <div class=\"bottom-header\">\n        <div class=\"container\">\n            <div class=\"header-bottom-left\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0882c12efb152a1558a158280634ed4c2f3f05076367", async() => {
                WriteLiteral("\n                    <div class=\"search\">\n                        <input name=\"q\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1687, "\"", 1695, 0);
                EndWriteAttribute();
                WriteLiteral(" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'\';}\" >\n                        <input type=\"submit\"  value=\"ARA\">\n\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <div class=\"clearfix\"> </div>\n            </div>\n            <div class=\"header-bottom-right\">\t\t\t\t\t\n");
            WriteLiteral("                        <ul class=\"login\">\n");
#nullable restore
#line 49 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml"
                             if(User.Identity.IsAuthenticated)
                            {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\n                                    <a href=\"/account/manage\">\n                                        <span> </span>\n                                        ");
#nullable restore
#line 54 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml"
                                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | \n                                    </a>\n                                </li>\n                                <li>\n                                    <a href=\"/account/logout\">Çıkış</a>\n                                </li>\n");
#nullable restore
#line 60 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml"
                            }
                            else
                            {                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li>
                                    <a href=""/account/login""><span> </span>Giriş Yap | </a>
                                </li>
                                <li>
                                    <a href=""/account/register"">Üye Ol</a>
                                </li>
");
#nullable restore
#line 69 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n");
#nullable restore
#line 71 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"cart\"><a href=\"/cart\"><span> </span>SEPETİM</a></div>   \n");
#nullable restore
#line 74 "/home/ahmet/proje/ecommerce/ecommerce.webui/Views/Shared/_header.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"clearfix\"> </div>\n            </div>\n            <div class=\"clearfix\"> </div>\t\n        </div>\n    </div>\n</div>");
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
