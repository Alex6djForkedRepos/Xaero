#pragma checksum "G:\Yogesh\SEO\Yogihosting\new\Xaero\Xaero\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "171ef1777ddb532f89014fa6040d37ca291daea4"
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
#line 1 "G:\Yogesh\SEO\Yogihosting\new\Xaero\Xaero\Views\_ViewImports.cshtml"
using Xaero.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"171ef1777ddb532f89014fa6040d37ca291daea4", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c10609fed8cd1ab2cfce2802fea69a627c90a7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "171ef1777ddb532f89014fa6040d37ca291daea43932", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 6 "G:\Yogesh\SEO\Yogihosting\new\Xaero\Xaero\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "171ef1777ddb532f89014fa6040d37ca291daea44496", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        table tr th.sort:hover {
            cursor: pointer;
        }

        table tr td img {
            width: 200px;
            height: auto;
        }

        .pagingDiv {
            background: #f2f2f2;
        }

            .pagingDiv > a {
                display: inline-block;
                padding: 0px 9px;
                margin-right: 4px;
                border-radius: 3px;
                border: solid 1px #c0c0c0;
                background: #e9e9e9;
                box-shadow: inset 0px 1px 0px rgba(255,255,255, .8), 0px 1px 3px rgba(0,0,0, .1);
                font-size: .875em;
                font-weight: bold;
                text-decoration: none;
                color: #717171;
                text-shadow: 0px 1px 0px rgba(255,255,255, 1);
            }

                .pagingDiv > a:hover {
                    background: #fefefe;
                    background: -webkit-gradient(linear, 0% 0%, 0% 100%, from(#FEFEFE), to(#f0f0f0));
                WriteLiteral(@"
                    background: -moz-linear-gradient(0% 0% 270deg,#FEFEFE, #f0f0f0);
                }

                .pagingDiv > a.active {
                    border: none;
                    background: #616161;
                    box-shadow: inset 0px 0px 8px rgba(0,0,0, .5), 0px 1px 0px rgba(255,255,255, .8);
                    color: #f0f0f0;
                    text-shadow: 0px 0px 3px rgba(0,0,0, .5);
                }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "171ef1777ddb532f89014fa6040d37ca291daea47897", async() => {
                WriteLiteral("\r\n    <div class=\"m-1 p-1\">\r\n        ");
#nullable restore
#line 54 "G:\Yogesh\SEO\Yogihosting\new\Xaero\Xaero\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <script>
        var dth = document.getElementsByTagName(""table"").item(0).getElementsByClassName(""sort"");
        var cVal = decodeURIComponent(getCookie(""sortCookie""));
        var nColOrder = """";
        if (cVal != ""null"") {
            var colName = cVal.split(',')[0];
            var colOrder = cVal.split(',')[1];
            var colClicked = Array.from(document.querySelectorAll(""th"")).find(el => el.innerText == colName);
            
            if (colOrder == ""asc"")
                colClicked.innerHTML += ""<img src=\""/Images/up.png\"" />"";
            else
                colClicked.innerHTML += ""<img src=\""/Images/down.png\"" />"";
        }

        for (let i = 0; i < dth.length; i++) {
            dth[i].addEventListener(""click"", function (e) {

                if (cVal != null) {
                    var colName = cVal.split(',')[0];
                    var colOrder = cVal.split(',')[1];
                    var clickedColumn = this.innerText.replace(/<[^>]*>?/gm");
                WriteLiteral(@", '');

                    if (clickedColumn == colName) {
                        if (colOrder == ""asc"")
                            nColOrder = ""desc"";
                        else
                            nColOrder = ""asc"";

                        setCookie(""sortCookie"", clickedColumn + "","" + nColOrder);
                    }
                    else {
                        setCookie(""sortCookie"", clickedColumn + "",asc"");
                    }
                }
                else {
                    setCookie(""sortCookie"", clickedColumn + "",asc"");
                }

                var cUrl = window.location.href;
                if(cUrl.includes(""Production""))
                    window.location = """);
#nullable restore
#line 97 "G:\Yogesh\SEO\Yogihosting\new\Xaero\Xaero\Views\Shared\_Layout.cshtml"
                                  Write(Url.Action("Index","Production"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                else if(cUrl.includes(\"Movie\"))\r\n                    window.location = \"");
#nullable restore
#line 99 "G:\Yogesh\SEO\Yogihosting\new\Xaero\Xaero\Views\Shared\_Layout.cshtml"
                                  Write(Url.Action("Index","Movie"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                 else if(cUrl.includes(\"Distribution\"))\r\n                    window.location=\"");
#nullable restore
#line 101 "G:\Yogesh\SEO\Yogihosting\new\Xaero\Xaero\Views\Shared\_Layout.cshtml"
                                Write(Url.Action("Index","Distribution"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
            });
        }

        function setCookie(name, value) {
            var expires = new Date();
            expires.setTime(expires.getTime() + (1 * 60 * 60 * 1000)); // adding 1 hour
            document.cookie = name + '=' + encodeURIComponent(value) + ';path=/;expires=' + expires.toUTCString();
        }

        function getCookie(name) {
            var value = document.cookie.match('(^|;) ?' + name + '=([^;]*)(;|$)');
            return value ? value[2] : null;
        }
    </script>
");
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
            WriteLiteral("\r\n</html>");
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