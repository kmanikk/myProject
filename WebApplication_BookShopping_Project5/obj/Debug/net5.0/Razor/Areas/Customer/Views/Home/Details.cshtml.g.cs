#pragma checksum "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "285e09579401951f51e868e1fcfcbe8c67eac24d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Details.cshtml")]
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
#line 1 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\_ViewImports.cshtml"
using WebApplication_BookShopping_Project5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\_ViewImports.cshtml"
using WebApplication_BookShopping_Project5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"285e09579401951f51e868e1fcfcbe8c67eac24d", @"/Areas/Customer/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c7f28e96ad2cc63df417f455e73a5282933df3", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShopping_Project_Models.ShoppingCart>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control  btn-square btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "285e09579401951f51e868e1fcfcbe8c67eac24d5788", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "285e09579401951f51e868e1fcfcbe8c67eac24d6085", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 4 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <br />
    <div class=""container backgroundWhite"">
        <div class=""card"">
            <div class=""card-header bg-light text-light ml-0 row container"">
                <div class=""col-12 col-md-6"">
                    <h1 class=""text-primary"">");
#nullable restore
#line 10 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                        Write(Model.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    <p class=\"text-warning\">");
#nullable restore
#line 11 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                       Write(Model.Product.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-12 col-md-6 text-md-right pt-4\">\r\n                    <span class=\"badge bg-success pt-2\" style=\"height:30px;\">");
#nullable restore
#line 14 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                                                        Write(Model.Product.CoverType.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    <span class=\"badge bg-info pt-2\" style=\"height:30px;\">");
#nullable restore
#line 15 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                                                     Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""container rounded p-2"">
                    <div class=""row"">
                        <div class=""col-8 col-lg-8"">

                            <div class=""row pl-2"">
                                <h5 class=""text-muted"">ISBN :");
#nullable restore
#line 24 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                                        Write(Model.Product.ISBN);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            </div>\r\n                            <div class=\"row pl-2\">\r\n                                <h5 class=\"text-muted pb-2\">List Price: <strike> ");
#nullable restore
#line 27 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                                                            Write(Model.Product.ListPrice.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strike></h5>
                            </div>
                            <div class=""row text-center pl-2"">
                                <div class=""p-1 col-2 bg-primary border-bottom"">
                                    <div class=""text-white"">Quantity</div>
                                </div>
                                <div class=""p-1 col-2 bg-primary border-bottom"">
                                    <div class=""text-white"">1-49</div>
                                    
                                </div>
                                <div class=""p-1 col-2 bg-primary border-bottom"">
                                    <div class=""text-white"">50-99</div>
                                </div>
                                <div class=""p-1 col-2 bg-primary border-bottom"">
                                    <div class=""text-white"">100+</div>
                                </div>
                            </div>
                            <div class=""row text-cent");
                WriteLiteral(@"er pl-2"" style=""color:maroon; font-weight:bold"">
                                <div class=""p-1 col-2 bg-primary"">
                                    <div class=""text-white"">Price</div>
                                </div>
                                <div class=""p-1 col-2 bg-primary"">
                                    <div class=""text-white"">");
#nullable restore
#line 49 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                                       Write(Model.Product.Price.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"p-1 col-2 bg-primary\">\r\n                                    <div class=\"text-white\">");
#nullable restore
#line 52 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                                       Write(Model.Product.Price50.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"p-1 col-2 bg-primary\">\r\n                                    <div class=\"text-white\">");
#nullable restore
#line 55 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                                       Write(Model.Product.Price100.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"row pl-2\">\r\n                                <p class=\"text-secondary\">");
#nullable restore
#line 59 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
                                                     Write(Html.Raw(@Model.Product.Discription));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"row pl-2\">\r\n                                <div class=\"col-2 text-primary\"><h4>Count</h4></div>\r\n                                <div class=\"col-10\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "285e09579401951f51e868e1fcfcbe8c67eac24d14685", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 63 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-12 col-lg-3 offset-lg-1 text-center\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 3951, "\"", 3980, 1);
#nullable restore
#line 67 "G:\Asp.Net Core\WebApplication_BookShopping_Project5\WebApplication_BookShopping_Project5\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3957, Model.Product.ImageURL, 3957, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded"" />
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-footer"">
                <div class=""row"">
                    <div class=""col-12 col-md-6 pb-1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "285e09579401951f51e868e1fcfcbe8c67eac24d17222", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <div class=""col-12 col-md-6 pb-1"">

                        <button type=""submit"" value=""Add to Cart"" class=""btn btn-primary btn-square btn-lg form-control"" style=""height:50px;"">Add to Cart</button>

                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShopping_Project_Models.ShoppingCart> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
