#pragma checksum "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e034426d83f6d44574cf26bf3ac95cdc527863c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
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
#line 1 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\_ViewImports.cshtml"
using Assignment02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\_ViewImports.cshtml"
using Assignment02.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\_ViewImports.cshtml"
using Assignment02.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\_ViewImports.cshtml"
using BLL.internalinterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e034426d83f6d44574cf26bf3ac95cdc527863c", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce05ecc06b2d85e0fd3d6feac43fab7ee22ad0b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsViewPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "All Roles";


#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .searchClass {\r\n        display: flex;\r\n        justify-content:center;\r\n    }\r\n</style>\r\n<h1>All Roles</h1>\r\n<br />\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e034426d83f6d44574cf26bf3ac95cdc527863c5796", async() => {
                WriteLiteral("Create New Role");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n\r\n\r\n\r\n");
#nullable restore
#line 23 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"mt-3 table table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
               Write(Html.DisplayNameFor(R => R.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
               Write(Html.DisplayNameFor(R => R.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>Details</td>\r\n                <td>Update</td>\r\n                <td>Delete</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
             foreach (var role in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
                   Write(Html.DisplayFor(M => role.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
                   Write(Html.DisplayFor(M => role.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e034426d83f6d44574cf26bf3ac95cdc527863c9269", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 43 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = role.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 48 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-4 alert alert-warning\">\r\n        <h3>There is No Roles!!</h3>\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\hp\OneDrive - Faculty of Computers and Information\Desktop\Assignment03\ASPCoreMVCAssignment02\Views\Roles\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
