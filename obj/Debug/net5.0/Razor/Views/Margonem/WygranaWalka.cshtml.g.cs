#pragma checksum "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2af5a99a5f72acd5d1a02e09c479eb8ddaa29ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Margonem_WygranaWalka), @"mvc.1.0.view", @"/Views/Margonem/WygranaWalka.cshtml")]
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
#line 1 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\_ViewImports.cshtml"
using MargonemByKycU_v0._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\_ViewImports.cshtml"
using MargonemByKycU_v0._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2af5a99a5f72acd5d1a02e09c479eb8ddaa29ca", @"/Views/Margonem/WygranaWalka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44eebeb15c37017472cdb6edc05ca7afd6ec31b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Margonem_WygranaWalka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MargonemByKycU.Models.PlayerAndEnemy>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Margonem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Walka", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
  
    ViewData["Title"] = "WygranaWalka";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    #stats {
        margin-top: 25px;
        padding-top: 25px;
        float: left;
        width: 45%;
        height: 350px;
        text-align: center;
        background-color: orange;
        border: solid black 7px;
        margin: 2.5%;
        padding: 15px;
    }

    #title {
        margin-top: 25px;
        padding-top: 25px;
        float: left;
        width: 95%;
        height: 100px;
        text-align: center;
        background-color: orange;
        border: solid black 7px;
        margin: 2.5%;
        padding: 15px;
    }

    button {
        margin-top: 25px;
        padding-top: 25px;
        width: 45%;
        height: 125px;
        text-align: center;
        background-color: orange;
        border: solid black 7px;
        margin: 2.5%;
        padding: 15px;
        font-size: 50px;
        float: right;
    }

        button:hover {
            background-color: orangered;
        }


    #wygryw {
        color: law");
            WriteLiteral(@"ngreen;
        font-size: 25px;
        text-align: center;
    }

    #przegryw {
        color: red;
        font-size: 25px;
        text-align: center;
    }
</style>

<h1 id=""title"">Zwycięstwo!</h1>

<div id=""stats"">

    <h2 id=""przegryw"">Przegrany!</h2>

    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
#nullable restore
#line 75 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayNameFor(model => model.enemyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayFor(model => model.enemyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayNameFor(model => model.enemyLvl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayFor(model => model.enemyLvl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayNameFor(model => model.enemyHitPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayFor(model => model.enemyHitPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayNameFor(model => model.zlotoZaWalke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayFor(model => model.zlotoZaWalke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayNameFor(model => model.xpZaWalke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayFor(model => model.xpZaWalke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n\r\n<div id=\"stats\">\r\n\r\n    <h2 id=\"wygryw\">Wygrany!</h2>\r\n\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 114 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 117 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 120 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayNameFor(model => model.lvl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 123 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayFor(model => model.lvl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 126 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayNameFor(model => model.hitPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 129 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayFor(model => model.hitPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 132 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayNameFor(model => model.zloto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 135 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\WygranaWalka.cshtml"
       Write(Html.DisplayFor(model => model.zloto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2af5a99a5f72acd5d1a02e09c479eb8ddaa29ca11328", async() => {
                WriteLiteral("<button>Zakończ</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MargonemByKycU.Models.PlayerAndEnemy> Html { get; private set; }
    }
}
#pragma warning restore 1591
