#pragma checksum "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d84e2c54a2930e8fe20c6f5c7e63e087ec4f6f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\_ViewImports.cshtml"
using Homework__13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\_ViewImports.cshtml"
using Homework__13.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d84e2c54a2930e8fe20c6f5c7e63e087ec4f6f6", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1acbff6f6500ab7f82f133b23db9a623cd34eb45", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Homework__13.Models.info>
    #nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d84e2c54a2930e8fe20c6f5c7e63e087ec4f6f63784", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width  initial-scale=1.0\" />\r\n    <title>Index</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d84e2c54a2930e8fe20c6f5c7e63e087ec4f6f64862", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table cellpadding=""0"" cellspacing=""0"" >
            <tr>
                <th colspan=""2"" align=""center"">Please, fill in the information </th>
            </tr>
            <tr>
                <td>First Name:    </td>
                <td>
                    ");
#nullable restore
#line 25 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml"
               Write(Html.TextBoxFor(m => m.firstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td >Last Name:    </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml"
               Write(Html.TextBoxFor(m => m.lastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Doctor:    </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml"
               Write(Html.DropDownListFor(m => m.doctor, new List<SelectListItem>
                { new SelectListItem{Text="Pediatrician", Value="Pediatrician"},
                new SelectListItem{Text="Dentist", Value="Dentist"}}, "Please select"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Time:    </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml"
               Write(Html.EditorFor(m => m.time));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </td>
            </tr>
            <tr>
                <td></td>
                <td><input type=""submit"" value=""Submit"" /></td>
            </tr>

            <tr>
                <td ></td>
                <td>
                    <button style=""background-color: #008CBA;"" type=""button""");
                BeginWriteAttribute("onclick", " onclick=\r\n                    \"", 1684, "\"", 1759, 3);
                WriteAttributeValue("", 1716, "location.href=\'", 1716, 15, true);
#nullable restore
#line 57 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml"
WriteAttributeValue("", 1731, Url.Action("appointments"), 1731, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1758, "\'", 1758, 1, true);
                EndWriteAttribute();
                WriteLiteral(">See the list of appointments</button>\r\n                    </td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 61 "C:\Users\Yoga\source\repos\Homework__13\Homework__13\Views\Home\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p >\r\n        <img src=\"https://riseapps.co/wp-content/uploads/2020/05/img_Doctor-Appointment-App-1024x768-min-1024x768.jpg\"\r\n             alt=\" appointment with doc\" width=\"600\" height=\"350\" align=\"top\">\r\n    </p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Homework__13.Models.info> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591