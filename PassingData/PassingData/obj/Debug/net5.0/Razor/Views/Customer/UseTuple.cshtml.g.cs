#pragma checksum "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\PassingData\PassingData\Views\Customer\UseTuple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d6776465ce87c559fb097284f8bafba55f1c44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_UseTuple), @"mvc.1.0.view", @"/Views/Customer/UseTuple.cshtml")]
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
#line 1 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
using PassingData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d6776465ce87c559fb097284f8bafba55f1c44", @"/Views/Customer/UseTuple.cshtml")]
    #nullable restore
    public class Views_Customer_UseTuple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(List<Customer> customers, string date, Product product)>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<p>\r\n\tTarih: ");
#nullable restore
#line 6 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
      Write(Model.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<ul>\r\n");
#nullable restore
#line 10 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
     foreach (Customer item in Model.customers)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<li>");
#nullable restore
#line 12 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<p>\r\n\tÜrün: ");
#nullable restore
#line 17 "C:\Users\onura\OneDrive\Masaüstü\ASP.CORE Dersleri\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
     Write(Model.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(List<Customer> customers, string date, Product product)> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591