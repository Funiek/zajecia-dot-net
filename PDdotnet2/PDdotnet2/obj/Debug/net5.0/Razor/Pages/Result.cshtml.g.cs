#pragma checksum "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b3ab020773167259d4e5306f3da9aac2d1af52c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PDdotnet2.Pages.Pages_Result), @"mvc.1.0.razor-page", @"/Pages/Result.cshtml")]
namespace PDdotnet2.Pages
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
#line 1 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\_ViewImports.cshtml"
using PDdotnet2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b3ab020773167259d4e5306f3da9aac2d1af52c", @"/Pages/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac493cd882a30abffaa634bb8030f4bd0195ac86", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Result : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b3ab020773167259d4e5306f3da9aac2d1af52c3040", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>Wynik</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b3ab020773167259d4e5306f3da9aac2d1af52c4068", async() => {
                WriteLiteral("\r\n    <h1>Wyniki</h1>\r\n    <div class=\"form-text-color\">\r\n        Twoje dane: <br />\r\n        Imię: ");
#nullable restore
#line 16 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
         Write(Model.imie);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n        Email: ");
#nullable restore
#line 17 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
          Write(Model.email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n        Wiek: ");
#nullable restore
#line 18 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
         Write(Model.wiek);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br /> \r\n        Płeć: ");
#nullable restore
#line 19 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
         Write(Model.plec);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n        BMI: ");
#nullable restore
#line 20 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
        Write(Model.BMI);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n        Twój przedział: \r\n");
#nullable restore
#line 22 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
         if (Model.wiadomosc.Equals("waga prawidłowa"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
       Write(Model.wiadomosc);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n");
#nullable restore
#line 25 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span style=\"color: red;\">");
#nullable restore
#line 28 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
                                 Write(Model.wiadomosc);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br /></span>\r\n");
#nullable restore
#line 29 "C:\Users\Krzysiek\source\repos\PDdotnet2\PDdotnet2\Pages\Result.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PDdotnet2.Pages.ResultModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PDdotnet2.Pages.ResultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PDdotnet2.Pages.ResultModel>)PageContext?.ViewData;
        public PDdotnet2.Pages.ResultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
