#pragma checksum "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a31a6449fb5277a994a3e249707b03bedf8c8947"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\_ViewImports.cshtml"
using EmployeeManagerProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\_ViewImports.cshtml"
using EmployeeManagerProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a31a6449fb5277a994a3e249707b03bedf8c8947", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd88ff338b14077134edeffb6beaf9238875f22", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeManagerProject.Models.EmployeeLoginViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\Home\Index.cshtml"
  

    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <br /> <br /> <br />
    <div class=""d-flex justify-content-center h-100"">
        <div class=""card"">
            <div class=""card-header"">
                <h3>Employee Login</h3>
            </div>

            <div class=""card-body"">
");
#nullable restore
#line 18 "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\Home\Index.cshtml"
                 using (Html.BeginForm("Index", "Home", FormMethod.Post))
                {
                    if (ViewBag.LoginStatus != null)
                    {
                        if (ViewBag.LoginStatus == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\">Invalid User Name</div>\r\n");
#nullable restore
#line 25 "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\Home\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""input-group form-group"">

                        <div class=""input-group-prepend"">

                            <span class=""input-group-text"">Staff Name</span>

                        </div>
                        <input type=""text"" name=""StaffName"" id=""StaffName"" placeholder=""Staff Name""");
            BeginWriteAttribute("value", " value=\"", 1107, "\"", 1138, 1);
#nullable restore
#line 34 "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1115, ViewBag.SelectedText, 1115, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

                    </div>
                    <div class=""input-group form-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Mobile Number</span>
                        </div>
                        <input type=""text"" name=""MobileNumber"" id=""MobileNumber"" placeholder=""Mobile Number""");
            BeginWriteAttribute("value", " value=\"", 1512, "\"", 1544, 1);
#nullable restore
#line 41 "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1520, ViewBag.SelectedValue, 1520, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" value=\"Countiue\" class=\"btn btn-primary\">\r\n                    </div>\r\n");
            WriteLiteral(@"                    <!-- The Modal Popup Div -->
                    <div id=""myModal"" class=""modal"">
                        <!-- Modal content -->
                        <div class=""modal-content"">

                            <div class=""text-left"">
                                ");
#nullable restore
#line 53 "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\Home\Index.cshtml"
                           Write(Html.DropDownListFor(m => m.EmpId, new SelectList(Model.EmployeeList, "Value", "Text"), new { @class = "form-control", @style = "width:50%;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            </div>\r\n                            <input class=\"btn btn-primary\" type=\"submit\" value=\"Submit\" />\r\n                            <br />\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 59 "D:\Text Core 1\EmployeeManager\EmployeeManagerProject\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n            <button class=\"btn btn-danger\" id=\"myBtn\">Add from Contacts</button>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeManagerProject.Models.EmployeeLoginViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
