#pragma checksum "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41624c46c2c320d1bce8f7426318ad943a0b0200"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Editors_Views_ContentManagement_AllDrafts), @"mvc.1.0.view", @"/Areas/Editors/Views/ContentManagement/AllDrafts.cshtml")]
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
#line 1 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\_ViewImports.cshtml"
using SportBox7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\_ViewImports.cshtml"
using SportBox7.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
using SportBox7.Areas.Editors.ViewModels.Content;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41624c46c2c320d1bce8f7426318ad943a0b0200", @"/Areas/Editors/Views/ContentManagement/AllDrafts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16aa6c3b10dcf43a2a238b8dd280e0cb8ea3bd2d", @"/Areas/Editors/Views/_ViewImports.cshtml")]
    public class Areas_Editors_Views_ContentManagement_AllDrafts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<AllArticlesViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
  
    ViewData["Title"] = "AllDrafts";
    Layout = "~/Areas/Editors/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Your Drafts</h1>
<hr />
<button class=""btn btn-primary"" onclick=""window.location='/Editors/ContentManagement/AddNewDraft'"">Add new draft</button>
<br />
<br />
<table class=""table table-bordered"">
    <tr>
        <th>Date</th>
        <th>Title</th>
        <th>Category</th>
        <th>Actions</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
     foreach (var draft in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
           Write(draft.CreationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
           Write(draft.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
           Write(draft.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 756, "\"", 811, 2);
            WriteAttributeValue("", 763, "/Editors/ContentManagement/DeleteDraft/", 763, 39, true);
#nullable restore
#line 27 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
WriteAttributeValue("", 802, draft.Id, 802, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> | <a");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 881, 2);
            WriteAttributeValue("", 835, "/Editors/ContentManagement/EditDraft/", 835, 37, true);
#nullable restore
#line 27 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
WriteAttributeValue("", 872, draft.Id, 872, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View and Edit</a>\r\n                | <a");
            BeginWriteAttribute("href", " href=\"", 922, "\"", 980, 2);
            WriteAttributeValue("", 929, "/Editors/ContentManagement/PublishArticle/", 929, 42, true);
#nullable restore
#line 28 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
WriteAttributeValue("", 971, draft.Id, 971, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Publish</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Liubo PC\SportBox7\SportBox7\SportBox7\Areas\Editors\Views\ContentManagement\AllDrafts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<button class=\"btn btn-primary\" onclick=\"window.location=\'/Editors/ContentManagement/Index\'\">Content Management Panel</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<AllArticlesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591