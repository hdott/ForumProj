#pragma checksum "C:\Users\nhori\Git\ForumProject\Views\Forum\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15cc6dda92a6dbf7b33bb78dd006e3407e51d8bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Index), @"mvc.1.0.view", @"/Views/Forum/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forum/Index.cshtml", typeof(AspNetCore.Views_Forum_Index))]
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
#line 1 "C:\Users\nhori\Git\ForumProject\Views\_ViewImports.cshtml"
using ForumProject;

#line default
#line hidden
#line 2 "C:\Users\nhori\Git\ForumProject\Views\_ViewImports.cshtml"
using ForumProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15cc6dda92a6dbf7b33bb78dd006e3407e51d8bd", @"/Views/Forum/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a903d9a8834e2742fca2a1311ac1cedf6c70fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\nhori\Git\ForumProject\Views\Forum\Index.cshtml"
  
    ViewData["Title"] = "Forum";

#line default
#line hidden
            BeginContext(41, 58, true);
            WriteLiteral("\r\n    <nav class=\"navbar navbar-light bg-light\">\r\n        ");
            EndContext();
            BeginContext(99, 326, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cc6dda92a6dbf7b33bb78dd006e3407e51d8bd3811", async() => {
                BeginContext(125, 293, true);
                WriteLiteral(@"
            <button type=""button"" class=""btn btn-outline-dark"">New Post</button>
            <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
            <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit"">Search</button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(425, 361, true);
            WriteLiteral(@"
    </nav>
    <ul class=""nav nav-tabs"">
        <li class=""nav-item"">
            <a class=""nav-link active"" href=""#"">Latest Posts</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""#"">Most Liked</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""#"">My Posts</a>
        </li>
");
            EndContext();
            BeginContext(935, 1995, true);
            WriteLiteral(@"    </ul>
    <div class=""card text-center"">
        <div class=""card-header"">
            Featured
        </div>
        <div class=""card-body"">
            <h5 class=""card-title"">Special title treatment</h5>
            <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
        </div>
        <div class=""card-footer text-muted"">
            2 days ago
        </div>
    </div>
    <div class=""card text-center"">
        <div class=""card-header"">
            Featured
        </div>
        <div class=""card-body"">
            <h5 class=""card-title"">Special title treatment</h5>
            <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
        </div>
        <div class=""card-footer text-muted"">
            2 days ago
        </div>
    </div>
    <div class=""card ");
            WriteLiteral(@"text-center"">
        <div class=""card-header"">
            Featured
        </div>
        <div class=""card-body"">
            <h5 class=""card-title"">Special title treatment</h5>
            <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
        </div>
        <div class=""card-footer text-muted"">
            2 days ago
        </div>
    </div>
    <div class=""card text-center"">
        <div class=""card-header"">
            Featured
        </div>
        <div class=""card-body"">
            <h5 class=""card-title"">Special title treatment</h5>
            <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
        </div>
        <div class=""card-footer text-muted"">
            2 days ago
        </div>
    </div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
