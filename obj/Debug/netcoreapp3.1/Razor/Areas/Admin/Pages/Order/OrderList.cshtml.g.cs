#pragma checksum "C:\Ec utbildning\asp.netcore\FreakyFashion\Areas\Admin\Pages\Order\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a608b4d14d798de018f18f664ccc4cef3ec59591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FreakyFashion.Pages.Order.Areas_Admin_Pages_Order_OrderList), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Order/OrderList.cshtml")]
namespace FreakyFashion.Pages.Order
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
#line 1 "C:\Ec utbildning\asp.netcore\FreakyFashion\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ec utbildning\asp.netcore\FreakyFashion\Areas\Admin\Pages\_ViewImports.cshtml"
using FreakyFashion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Ec utbildning\asp.netcore\FreakyFashion\Areas\Admin\Pages\_ViewImports.cshtml"
using FreakyFashion.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a608b4d14d798de018f18f664ccc4cef3ec59591", @"/Areas/Admin/Pages/Order/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fd40435331658698252967b4770e434015c281", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Order_OrderList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Ec utbildning\asp.netcore\FreakyFashion\Areas\Admin\Pages\Order\OrderList.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Coustomer</th>
                    <th>Date</th>
                    <th>Total Price</th>

                </tr>
            </thead>
");
            WriteLiteral(@"        <tbody>
            <tr>
                <td>John Doe</td>
                <td>2020-01-15 12:00</td>
                <td>299.00 sek</td>

            </tr>
            <tr>
                <td>JaneDoe</td>
                <td>2020-02-15 14:20</td>
                <td>499.00 sek</td>

            </tr>
        </tbody>
        </table>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreakyFashion.OrderListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FreakyFashion.OrderListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FreakyFashion.OrderListModel>)PageContext?.ViewData;
        public FreakyFashion.OrderListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591