#pragma checksum "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002268545c1140c3cd5def1121e067b78fc47c23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Firma_Edit), @"mvc.1.0.view", @"/Views/Firma/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Firma/Edit.cshtml", typeof(AspNetCore.Views_Firma_Edit))]
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
#line 1 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\_ViewImports.cshtml"
using MixCRM;

#line default
#line hidden
#line 2 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\_ViewImports.cshtml"
using MixCRM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002268545c1140c3cd5def1121e067b78fc47c23", @"/Views/Firma/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d003a1e69c72c5ad002022581ea7097e0e5d14", @"/Views/_ViewImports.cshtml")]
    public class Views_Firma_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Firma>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
  
    ViewData["Title"] = ViewBag.ActionMode; ;

#line default
#line hidden
            BeginContext(68, 121, true);
            WriteLiteral("\r\n<div class=\"m-4\">\r\n    <div class=\"bg-success text-white p-4\">\r\n        <h2>Firma Ekle / Düzenle</h2>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(189, 2241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50fbd8598e684371b5fc8446e7eeeefa", async() => {
                BeginContext(244, 49, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"original.Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 293, "\"", 310, 1);
#line 11 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
WriteAttributeValue("", 301, Model.Id, 301, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(311, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 365, "\"", 388, 1);
#line 12 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
WriteAttributeValue("", 373, Model.FirmaAdi, 373, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(389, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 443, "\"", 463, 1);
#line 13 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
WriteAttributeValue("", 451, Model.Unvan, 451, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(464, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 518, "\"", 547, 1);
#line 14 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
WriteAttributeValue("", 526, Model.FirmaYetkilisi, 526, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(548, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 602, "\"", 623, 1);
#line 15 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
WriteAttributeValue("", 610, Model.Eposta, 610, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(624, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 678, "\"", 696, 1);
#line 16 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
WriteAttributeValue("", 686, Model.Tel, 686, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(697, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 751, "\"", 771, 1);
#line 17 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
WriteAttributeValue("", 759, Model.Adres, 759, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(772, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 826, "\"", 849, 1);
#line 18 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
WriteAttributeValue("", 834, Model.Aciklama, 834, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(850, 294, true);
                WriteLiteral(@" />


        <div class=""row"">
            <div class=""col-6"">
                <div class=""bg-primary text-white p-2 mt-3"">
                    Departman
                </div>
                <div class=""form-group"">
                    <label>Firma Adı</label>
                    ");
                EndContext();
                BeginContext(1144, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0ad3da911244984ae2a691672252b32", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 28 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirmaAdi);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1193, 137, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Firma Unvanı</label>\r\n                    ");
                EndContext();
                BeginContext(1330, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "554653b152c04cfebe199eeb0ffeb48a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 32 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Unvan);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1376, 140, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Firma Yetkilisi</label>\r\n                    ");
                EndContext();
                BeginContext(1516, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00958e4a6a9744558253ccd672560174", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 36 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirmaYetkilisi);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1571, 132, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>E-Posta</label>\r\n                    ");
                EndContext();
                BeginContext(1703, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a0f395c325e4502a9da6b5d0a9d2bb3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 40 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Eposta);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1750, 132, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Telefon</label>\r\n                    ");
                EndContext();
                BeginContext(1882, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1040e003628d4e76b0070216b597b1d2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 44 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tel);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1926, 130, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Adres</label>\r\n                    ");
                EndContext();
                BeginContext(2056, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4026fb9d1fe4d4cb99d4ba8a43f5998", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 48 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Adres);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2102, 133, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Açıklama</label>\r\n                    ");
                EndContext();
                BeginContext(2235, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b60e23ca7864c40b61babdf9fbfb8dc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 52 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Aciklama);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2284, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Firma\Edit.cshtml"
           WriteLiteral(ViewBag.ActionMode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2430, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Firma> Html { get; private set; }
    }
}
#pragma warning restore 1591
