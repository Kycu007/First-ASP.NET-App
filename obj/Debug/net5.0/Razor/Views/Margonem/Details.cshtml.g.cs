#pragma checksum "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72bb9ad0a85494ff8e48e4114369a5fcefcc83ba"
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
#line 1 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\_ViewImports.cshtml"
using MargonemByKycU_v0._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\_ViewImports.cshtml"
using MargonemByKycU_v0._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72bb9ad0a85494ff8e48e4114369a5fcefcc83ba", @"/Views/Margonem/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44eebeb15c37017472cdb6edc05ca7afd6ec31b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Margonem_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MargonemByKycU.Models.ShopModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/margonem4.gif", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/margonem5.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("115"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("115"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Margonem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
  
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
        height: 625px;
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
            WriteLiteral("\n        }\r\n</style>\r\n\r\n<div id=\"title\">\r\n     Statystyki Postaci:\r\n</div>\r\n\r\n<div id=\"title\">\r\n     Kup Ulepszenie:\r\n</div>\r\n\r\n<div id=\"stats\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72bb9ad0a85494ff8e48e4114369a5fcefcc83ba6747", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 65 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Nazwa Postaci:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["nazwaPostaci"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Klasa Postaci:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["klasaPostaci"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Poziom:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["poziom"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Szybko????:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["atackSpeed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Atak:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["atackDamage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Pancerz:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["armor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ??ycie:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["hitPoints"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Punkty XP:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["xp"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Z??oto:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["zloto"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div id=\"stats\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72bb9ad0a85494ff8e48e4114369a5fcefcc83ba11958", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 127 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 132 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.atackSpeedUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            + ");
#nullable restore
#line 133 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
         Write(Html.DisplayFor(model => model.atackSpeedUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 136 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.atackSpeedCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 137 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["cenaAtackSpeed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 139 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP", "CzyKupic", new { id = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 140 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP ?? 10", "CzyKupicWiecej", new { id = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 144 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.atackDamageUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            + ");
#nullable restore
#line 145 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
         Write(Html.DisplayFor(model => model.atackDamageUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 148 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.atackDamageCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 149 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["cenaAtackDamage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 151 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP", "CzyKupic", new { id = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 152 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP ?? 10", "CzyKupicWiecej", new { id = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 156 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.armorUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            + ");
#nullable restore
#line 157 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
         Write(Html.DisplayFor(model => model.armorUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 160 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.armorCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 161 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["cenaArmor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 163 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP", "CzyKupic", new { id = 3 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 164 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP ?? 10", "CzyKupicWiecej", new { id = 3 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 168 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.hitPointsUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            + ");
#nullable restore
#line 169 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
         Write(Html.DisplayFor(model => model.hitPointsUpg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 172 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.hitPointsCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 173 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(TempData["cenaHitPoints"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 175 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP", "CzyKupic", new { id = 4 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 176 "C:\Users\Kapus\Desktop\MargonemByKycu\Views\Margonem\Details.cshtml"
       Write(Html.ActionLink("KUP ?? 10", "CzyKupicWiecej", new { id = 4 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72bb9ad0a85494ff8e48e4114369a5fcefcc83ba20751", async() => {
                WriteLiteral("<button>Wr????</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
