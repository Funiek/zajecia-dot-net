#pragma checksum "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb2bb79fc656a13eb159203c34f1781b71e45713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PDdotnet1.Pages.Pages_EqualGreater18), @"mvc.1.0.razor-page", @"/Pages/EqualGreater18.cshtml")]
namespace PDdotnet1.Pages
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
#line 1 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\_ViewImports.cshtml"
using PDdotnet1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2bb79fc656a13eb159203c34f1781b71e45713", @"/Pages/EqualGreater18.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57eaeaa8d43b1ecbf36320f148087386a5f76ac", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EqualGreater18 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb2bb79fc656a13eb159203c34f1781b71e457133072", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>Masz co najmniej 18 lat</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb2bb79fc656a13eb159203c34f1781b71e457134118", async() => {
                WriteLiteral("\r\n    <h1>Witaj u??ytkowniku</h1>\r\n    Masz co najmniej 18 lat i mo??esz pracowa?? w naszej firmie! Dzi??kujemy za zg??oszenie! <br />\r\n    Twoje dane: <br />\r\n    Imi??: ");
#nullable restore
#line 14 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
     Write(Model.Imie);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n    Nazwisko: ");
#nullable restore
#line 15 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
         Write(Model.Nazwisko);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n    Wiek: ");
#nullable restore
#line 16 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
     Write(Model.Wiek);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n    P??e??: ");
#nullable restore
#line 17 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
     Write(Model.Plec);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n");
#nullable restore
#line 18 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
     if (@Model.Telefon != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
   Write(Model.Telefon);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n");
#nullable restore
#line 21 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>Brak podanego numeru telefonu <br /></div>\r\n");
#nullable restore
#line 25 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
     if (@Model.Wiek != 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>Jezyki programowania <br /></div>\r\n");
#nullable restore
#line 30 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
     foreach (var item in @Model.JezykiProgramowania)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
   Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n");
#nullable restore
#line 35 "C:\Users\Krzysiek\source\repos\PDdotnet1\PDdotnet1\Pages\EqualGreater18.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PDdotnet1.Pages.EqualGreater18Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PDdotnet1.Pages.EqualGreater18Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PDdotnet1.Pages.EqualGreater18Model>)PageContext?.ViewData;
        public PDdotnet1.Pages.EqualGreater18Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
