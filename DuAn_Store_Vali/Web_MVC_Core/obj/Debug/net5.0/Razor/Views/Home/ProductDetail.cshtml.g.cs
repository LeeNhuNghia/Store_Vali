#pragma checksum "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "495a9514c84b1fe85757b4542c926372162b4bee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetail), @"mvc.1.0.view", @"/Views/Home/ProductDetail.cshtml")]
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
#line 1 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\_ViewImports.cshtml"
using Web_MVC_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\_ViewImports.cshtml"
using Web_MVC_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"495a9514c84b1fe85757b4542c926372162b4bee", @"/Views/Home/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a78e386efeba08aae6dd3ea5d099146cb9ffba5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_MVC_Core.ViewModels.HomeProductDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
  
    ViewData["Title"] = "ProductDetail";
    Layout = "~/Views/Shared/_LayoutOgani.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""product-details spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6"">
                <div class=""product__details__pic"">
                    <div class=""product__details__pic__item"">
                        <img class=""product__details__pic__item--large""");
            BeginWriteAttribute("src", "\r\n                             src=\"", 494, "\"", 558, 2);
            WriteAttributeValue("", 530, "/", 530, 1, true);
#nullable restore
#line 16 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
WriteAttributeValue("", 531, Model.danhMucSp.AnhDaiDien, 531, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 559, "\"", 565, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                   \r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-6\">\r\n                <div class=\"product__details__text\">\r\n                    <h3>");
#nullable restore
#line 23 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                   Write(Model.danhMucSp.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <div class=""product__details__rating"">
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star-half-o""></i>
                        <span>(18 reviews)</span>
                    </div>
                    <div class=""product__details__price"">");
#nullable restore
#line 32 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                                                    Write(Model.danhMucSp.GiaLonNhat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <p>\r\n                        ");
#nullable restore
#line 34 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                   Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <div class=""product__details__quantity"">
                        <div class=""quantity"">
                            <div class=""pro-qty"">
                                <input type=""text"" value=""1"">
                            </div>
                        </div>
                    </div>
                    <a href=""#"" class=""primary-btn"">ADD TO CARD</a>
                    <a href=""#"" class=""heart-icon""><span class=""icon_heart_alt""></span></a>
                    <ul>
                        <li><b>Availability</b> <span>In Stock</span></li>
                        <li><b>Shipping</b> <span>01 day shipping. <samp>Free pickup today</samp></span></li>
                        <li><b>Weight</b> <span>0.5 kg</span></li>
                        <li>
                            <b>Share on</b>
                            <div class=""share"">
                                <a href=""#""><i class=""fa fa-facebook""></i></a>
                             ");
            WriteLiteral(@"   <a href=""#""><i class=""fa fa-twitter""></i></a>
                                <a href=""#""><i class=""fa fa-instagram""></i></a>
                                <a href=""#""><i class=""fa fa-pinterest""></i></a>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-12"">
                <div class=""product__details__tab"">
                    <ul class=""nav nav-tabs"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-toggle=""tab"" href=""#tabs-1"" role=""tab""
                               aria-selected=""true"">Description</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-2"" role=""tab""
                               aria-selected=""false"">Information</a>
                        </li>
                        <li class=");
            WriteLiteral(@"""nav-item"">
                            <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-3"" role=""tab""
                               aria-selected=""false"">Reviews <span>(1)</span></a>
                        </li>
                    </ul>
                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""tabs-1"" role=""tabpanel"">
                            <div class=""product__details__tab__desc"">
                                <h6>Products Infomation</h6>
                                <p>
                                    ");
#nullable restore
#line 82 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 85 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <div class=""tab-pane"" id=""tabs-2"" role=""tabpanel"">
                            <div class=""product__details__tab__desc"">
                                <h6>Products Infomation</h6>
                                <p>
                                    ");
#nullable restore
#line 93 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 96 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <div class=""tab-pane"" id=""tabs-3"" role=""tabpanel"">
                            <div class=""product__details__tab__desc"">
                                <h6>Products Infomation</h6>
                                <p>
                                    ");
#nullable restore
#line 104 "C:\Users\Nghia\Desktop\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_MVC_Core.ViewModels.HomeProductDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
