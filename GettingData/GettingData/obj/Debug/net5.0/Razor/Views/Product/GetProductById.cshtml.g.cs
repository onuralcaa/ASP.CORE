#pragma checksum "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\GettingData\GettingData\Views\Product\GetProductById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48a9af50f307e72196e5a637a14990b64e6bbffd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProductById), @"mvc.1.0.view", @"/Views/Product/GetProductById.cshtml")]
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
#line 1 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\GettingData\GettingData\Views\Product\GetProductById.cshtml"
using GettingData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a9af50f307e72196e5a637a14990b64e6bbffd", @"/Views/Product/GetProductById.cshtml")]
    #nullable restore
    public class Views_Product_GetProductById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\GettingData\GettingData\Views\Product\GetProductById.cshtml"
 if(ViewBag.Error != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<h2>");
#nullable restore
#line 7 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\GettingData\GettingData\Views\Product\GetProductById.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 8 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\GettingData\GettingData\Views\Product\GetProductById.cshtml"
}
else
{	

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Seçilen ürün:</h2>\r\n<h4>");
#nullable restore
#line 12 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\GettingData\GettingData\Views\Product\GetProductById.cshtml"
Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 13 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\GettingData\GettingData\Views\Product\GetProductById.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
