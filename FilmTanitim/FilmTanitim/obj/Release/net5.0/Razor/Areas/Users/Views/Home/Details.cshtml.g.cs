#pragma checksum "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1673951a6270e8381f303b11a088b573dd0e78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Users/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Areas\Users\Views\_ViewImports.cshtml"
using FilmTanitim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Areas\Users\Views\_ViewImports.cshtml"
using FilmTanitim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1673951a6270e8381f303b11a088b573dd0e78", @"/Areas/Users/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43199b482ad16e61170f00ccfa242b4f71cc3299", @"/Areas/Users/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Users_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmTanitim.Models.Movie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2 style=\"text-align:center;\" class=\"text-primary\">");
#nullable restore
#line 9 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br />\r\n\r\n<div class=\"row\">\r\n    <div style=\"text-align:center\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 314, "\"", 337, 1);
#nullable restore
#line 14 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Details.cshtml"
WriteAttributeValue("", 320, Model.MovieImage, 320, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:300px;text-align:center\">\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    ");
#nullable restore
#line 19 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Details.cshtml"
Write(Html.DisplayFor(model => model.MovieDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h5 class=\"text-success\"><b>Kategori : </b>");
#nullable restore
#line 24 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <div style=\"float:right\" id=\"rateYo\"></div>\r\n    </div>\r\n\r\n</div>\r\n<br />\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<h4 class=\"text-success\" style=\"text-align:center;\">YORUMLAR</h4>\r\n");
#nullable restore
#line 39 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Details.cshtml"
Write(await Component.InvokeAsync("YorumListeleme"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h4 class=\"text-success\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e1673951a6270e8381f303b11a088b573dd0e786941", async() => {
                WriteLiteral("Yorum Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n\r\n");
            WriteLiteral("<br />\r\n<br />\r\n<script>\r\n    $(function () {\r\n\r\n        $(\"#rateYo\").rateYo({\r\n            rating: \"65%\",\r\n            readOnly: true\r\n        });\r\n    });\r\n\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmTanitim.Models.Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
