#pragma checksum "C:\Users\acer\Desktop\Demo\Project\FrontToASP\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27c75ea8d81d6128ea9ab0fac0e3c4a8c38b1240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\acer\Desktop\Demo\Project\FrontToASP\Views\_ViewImports.cshtml"
using FrontToASP;

#line default
#line hidden
#line 2 "C:\Users\acer\Desktop\Demo\Project\FrontToASP\Views\_ViewImports.cshtml"
using FrontToASP.Models;

#line default
#line hidden
#line 3 "C:\Users\acer\Desktop\Demo\Project\FrontToASP\Views\_ViewImports.cshtml"
using FrontToASP.ViewsModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27c75ea8d81d6128ea9ab0fac0e3c4a8c38b1240", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f66c7064a7e930eacad75b725965f5768cf22f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 974, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da9c6a696ada48df86bdb08969176bc9", async() => {
                BeginContext(41, 961, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"" />
    <title>Winkel</title>
    <link rel=""stylesheet""
          href=""https://use.fontawesome.com/releases/v5.8.1/css/all.css""
          integrity=""sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf""
          crossorigin=""anonymous"" />
    <link rel=""stylesheet""
          href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T""
          crossorigin=""anonymous"" />
    <link rel=""stylesheet""
          href=""../JS/OwlCarousel2-2.3.4/dist/assets/owl.carousel.min.css"" />
    <link rel=""stylesheet""
          href=""../JS/OwlCarousel2-2.3.4/dist/assets/owl.theme.default.min.css"" />

    <link rel=""stylesheet"" href=""../CSS/style.css"" />
");
                EndContext();
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
            EndContext();
            BeginContext(1009, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1011, 7831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86689989b09e49f2868b26a9486d31d9", async() => {
                BeginContext(1017, 3013, true);
                WriteLiteral(@"
    <div id=""preloader"">
        <img src=""../IMG/loading.gif"" />
    </div>
    <div class=""topInfo"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 d-block"">
                    <div class=""row d-flex"">
                        <div style=""color: #fff""
                             class=""col-md pr-4 topper align-items-center d-flex"">
                            <div class=""icon mr-2 d-flex justify-content-center align-items-center"">
                                <i class=""fas fa-phone""></i>
                            </div>
                            <span class=""text"">+ 1235 2355 98</span>
                        </div>
                        <div style=""color: #fff""
                             class=""col-md pr-4 topper align-items-center"">
                            <i class=""fas fa-paper-plane""></i>
                            <span class=""text"">youremail@email.com</span>
                        </div>
                      ");
                WriteLiteral(@"  <div style=""color: #fff""
                             class=""col-md-4 pr-4 topper align-items-center text-lg-right"">
                            <span class=""text"">3-5 Business days delivery & Free Returns</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <nav class=""topNavBar mt-3"" id=""topNavBar"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 topNav d-flex justify-content-between"">
                    <a class=""indexBrand"" href=""index.html"">WINKEL</a>
                    <ul class=""indexTopNav d-flex justify-content-around"">
                        <li><a href=""../INDEX/index.html"">HOME</a></li>
                        <li class=""navLi"">
                            <a href=""#"">SHOP</a><i class=""fas fa-sort-down""></i>
                            <ul class=""dropDown"">
                                <li><a href=""../INDEX/shop.html"">Shop</a></li>
    ");
                WriteLiteral(@"                            <li>
                                    <a href=""../INDEX/product-single.html"">Single Product</a>
                                </li>
                                <li><a href=""../INDEX/cart.html"">Cart</a></li>
                                <li><a href=""../INDEX/checkout.html"">Checout</a></li>
                            </ul>
                        </li>
                        <li><a href=""about.html"">ABOUT</a></li>
                        <li><a href=""blog.html"">BLOG</a></li>
                        <li><a href=""contact.html"">CONTACT</a></li>
                        <li>
                            <a href=""checkout.html"">
                                <span class=""basketCart""><i class=""clearZero fas fa-shopping-cart"">[0]</i></span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </nav>
    ");
                EndContext();
                BeginContext(4031, 12, false);
#line 84 "C:\Users\acer\Desktop\Demo\Project\FrontToASP\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4043, 495, true);
                WriteLiteral(@"
    <section id=""subcribe"">
        <hr />
        <div class=""d-flex align-items-center"">
            <div class=""container"">
                <div class=""row d-flex justify-content-center py-5"">
                    <div class=""col-md-7 text-center"">
                        <h2 class=""bold"">Subcribe to our Newsletter</h2>
                        <div class=""row d-flex justify-content-center mt-5"">
                            <div class=""col-md-8"">
                                ");
                EndContext();
                BeginContext(4538, 624, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f163d05cba2849e1aa208f278206f30e", async() => {
                    BeginContext(4578, 577, true);
                    WriteLiteral(@"
                                    <div class=""form-group d-flex"">
                                        <input type=""text""
                                               class=""form-control myInput""
                                               placeholder=""Enter email address"" />
                                        <input type=""submit""
                                               value=""Subscribe""
                                               class=""submit px-3 mySubmit"" />
                                    </div>
                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5162, 3673, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <footer id=""footer"">
        <a href=""#"">
            <span class=""topper""><i class=""fas fa-chevron-up""></i></span>
        </a>
        <div class=""container"">
            <div class=""row"">
                <ul class=""col-3"">
                    WINKEL
                    <p class=""unicP"">
                        Far far away, behind the word mountains, far from the countries
                        Vokalia and Consonantia.
                    </p>
                    <li>
                        <a href=""#"">
                            <span><i class=""fab fa-twitter""></i></span>
                        </a>
                        <a href=""#"">
                            <span><i class=""fab fa-facebook-f""></i></span>
                        </a>
                        <a href=""#"">
                            <spa");
                WriteLiteral(@"n><i class=""fab fa-instagram""></i></span>
                        </a>
                    </li>
                </ul>
                <ul class=""col-3"">
                    MENU
                    <li><a href=""#"">Shop</a></li>
                    <li><a href=""#"">About</a></li>
                    <li><a href=""#"">Journal</a></li>
                    <li><a href=""#"">Contact Us</a></li>
                </ul>
                <ul class=""col-3 d-flex"">
                    HELP
                    <div class=""row"">
                        <ul class=""col-6"">
                            <li><a href=""#"">Shipping Information</a></li>
                            <li><a href=""#"">Returns & Exchange</a></li>
                            <li><a href=""#"">Terms & Conditions</a></li>
                            <li><a href=""#"">Privacy Policy</a></li>
                        </ul>
                        <ul class=""col-6 unicMargin"">
                            <li><a href=""#"">FAGs</a></li>
               ");
                WriteLiteral(@"             <li><a href=""#""></a>Contact</li>
                        </ul>
                    </div>
                </ul>
                <ul class=""col-3"">
                    HAVE A QUESTIONS?
                    <li>
                        <a href=""#"">
                            <i class=""fas fa-map-marker-alt""></i>
                            <p>
                                203 Fake St. Mountain View, San Francisco, California, USA
                            </p>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fas fa-phone""></i>
                            <p>+2 392 3929 210</p>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fas fa-envelope""></i>
                            <p>info@yourdomain.com</p>
                        </a>
                    </li>
    ");
                WriteLiteral(@"            </ul>
            </div>
            <p class=""mBottom"">
                Copyright ©2019 All rights reserved | This template is made with
                <i class=""fas fa-heart""></i> by <a href=""#""><span>Colorlib</span></a>
            </p>
        </div>
    </footer>
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""
            integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=""
            crossorigin=""anonymous""></script>
    <script src=""../JS/OwlCarousel2-2.3.4/dist/owl.carousel.min.js""></script>
    <script src=""../JS/script.js""></script>
");
                EndContext();
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
            EndContext();
            BeginContext(8842, 9, true);
            WriteLiteral("\r\n</html>");
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
