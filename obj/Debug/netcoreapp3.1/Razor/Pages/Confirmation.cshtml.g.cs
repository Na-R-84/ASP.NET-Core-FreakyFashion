#pragma checksum "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0817dc4b243b79a7ec59c849505e5f64216e3612"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FreakyFashion.Pages.Pages_Confirmation), @"mvc.1.0.razor-page", @"/Pages/Confirmation.cshtml")]
namespace FreakyFashion.Pages
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
#line 1 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\_ViewImports.cshtml"
using FreakyFashion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\_ViewImports.cshtml"
using FreakyFashion.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{searchString?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0817dc4b243b79a7ec59c849505e5f64216e3612", @"/Pages/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fd40435331658698252967b4770e434015c281", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Confirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
  
    ViewData["Title"] = "Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center font-weight-bold"">Confirmation</h1>
<h4 class=""text-center"">Thank you for your order</h4>
<h4 class=""text-center"">Payment has been made and the order is shipped in 2 working days</h4>
<br />
<h3>Order Details</h3>
<hr class=""h-25 w-25"" />
<p>
    John Doe <br /> Lyton Road <br /> EN5 5BU London
</p>

<h3 class=""text-center"">Ordered Items</h3>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0817dc4b243b79a7ec59c849505e5f64216e36125876", async() => {
                WriteLiteral("\r\n    <table border=\"1\">\r\n        <tr>\r\n            <th>      </th>\r\n            <th>Price</th>\r\n            <th>Quantity <input type=\"submit\" value=\"Update\" /></th>\r\n            <th>Sub Total</th>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
         foreach (var item in Model.confirmation)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr align=\"center\">\r\n\r\n                <td>\r\n                    <div class=\"row\">\r\n                        <div class=\"col border\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0817dc4b243b79a7ec59c849505e5f64216e36126771", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 990, "~/images/", 990, 9, true);
#nullable restore
#line 33 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
AddHtmlAttributeValue("", 999, item.Product.ImageUrl, 999, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n                        <div class=\"col\">\r\n                            <h5>");
#nullable restore
#line 35 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            <h6>");
#nullable restore
#line 36 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
                           Write(item.Product);

#line default
#line hidden
#nullable disable
                WriteLiteral(".</h6>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n                <td>$");
#nullable restore
#line 40 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
                Write(item.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td><input type=\"number\" name=\"quantities\"");
                BeginWriteAttribute("value", " value=\"", 1397, "\"", 1419, 1);
#nullable restore
#line 41 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
WriteAttributeValue("", 1405, item.Quantity, 1405, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" style=\"width: 50px;\" /></td>\r\n                <td>\r\n                    $");
#nullable restore
#line 43 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
                 Write(item.Product.Price * item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td colspan=\"6\" align=\"right\">Total</td>\r\n            <td align=\"center\">$");
#nullable restore
#line 49 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Confirmation.cshtml"
                           Write(Model.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"border\">\r\n    <h4>Total Items : </h4>\r\n    <h6>Shipping : 100.00</h6>\r\n    <h4>Total : </h4>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreakyFashion.ConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FreakyFashion.ConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FreakyFashion.ConfirmationModel>)PageContext?.ViewData;
        public FreakyFashion.ConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591