#pragma checksum "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc0218d54c511289f396d132c56904933995cb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Margonem_Details), @"mvc.1.0.view", @"/Views/Margonem/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc0218d54c511289f396d132c56904933995cb7", @"/Views/Margonem/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44eebeb15c37017472cdb6edc05ca7afd6ec31b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Margonem_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MargonemByKycU.Models.ShopModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Margonem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
  
    ViewData["Title"] = "Sklep";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    #stats {
        margin-top: 25px;
        padding-top: 25px;
        float: left;
        width: 45%;
        height: 525px;
        text-align: center;
        background-color: orange;
        border: solid black 7px;
        margin: 2.5%;
        padding: 15px;
        font-size: 25px;
    }

    #title {
        margin-top: 25px;
        padding-top: 25px;
        float: left;
        width: 45%;
        height: 125px;
        text-align: center;
        background-color: orange;
        border: solid black 7px;
        margin: 2.5%;
        padding: 15px;
        font-size: 50px;
    }

    button {
        margin-top: 25px;
        padding-top: 25px;
        float: left;
        width: 45%;
        height: 125px;
        text-align: center;
        background-color: orange;
        border: solid black 7px;
        margin: 2.5%;
        padding: 15px;
        font-size: 50px;
    }

        button:hover {
            background-color: orangered;");
            WriteLiteral(@"
        }
</style>

<div id=""title"">
     Statystyki Postaci:
</div>

<div id=""title"">
     Kup Ulepszenie:
</div>

<div id=""stats"">

    <dl class=""row"">
        <dt class=""col-sm-2"">
            Nazwa Postaci:
        </dt>
        <dd class=""col-sm-10"">
            ");
#nullable restore
#line 70 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["nazwaPostaci"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Klasa Postaci:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["klasaPostaci"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Poziom:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["poziom"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Szybkość:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 88 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["atackSpeed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Atak:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 94 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["atackDamage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Pancerz:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 100 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["armor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Życie:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 106 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["hitPoints"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Punkty XP:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 112 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["xp"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Złoto:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 118 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["zloto"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div id=\"stats\">\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 127 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.atackSpeedUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            + ");
#nullable restore
#line 128 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
         Write(Html.DisplayFor(model => model.atackSpeedUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.atackSpeedCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 132 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["cenaAtackSpeed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 134 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP", "CzyKupic", new { id = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 138 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.atackDamageUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            + ");
#nullable restore
#line 139 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
         Write(Html.DisplayFor(model => model.atackDamageUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 142 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.atackDamageCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 143 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["cenaAtackDamage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 145 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP", "CzyKupic", new { id = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 149 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.armorUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            + ");
#nullable restore
#line 150 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
         Write(Html.DisplayFor(model => model.armorUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 153 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.armorCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 154 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["cenaArmor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 156 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP", "CzyKupic", new { id = 3 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 160 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.hitPointsUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            + ");
#nullable restore
#line 161 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
         Write(Html.DisplayFor(model => model.hitPointsUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 164 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.hitPointsCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 165 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(TempData["cenaHitPoints"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 167 "C:\Users\Kapus\source\repos\MargonemByKycU_v0.1\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP", "CzyKupic", new { id = 4 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc0218d54c511289f396d132c56904933995cb714451", async() => {
                WriteLiteral("<button>Wróć</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MargonemByKycU.Models.ShopModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
