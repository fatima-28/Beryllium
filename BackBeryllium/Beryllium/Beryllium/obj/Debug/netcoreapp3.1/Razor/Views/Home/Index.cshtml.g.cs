#pragma checksum "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90745e90da75dd3bc90348025fc3c4522b1d83a9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90745e90da75dd3bc90348025fc3c4522b1d83a9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- main start -->\r\n<main>\r\n    <!-- SLider section start -->\r\n    <section id=\"slider\">\r\n        <div class=\"slide\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
             foreach (var slide in Model.Slides)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <img class=\"slider-img\" alt=\"slider image\"");
            BeginWriteAttribute("src", "\r\n                         src=\"", 317, "\"", 364, 1);
#nullable restore
#line 16 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
WriteAttributeValue("", 349, slide.SlideUrl, 349, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n");
#nullable restore
#line 18 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <p class=""arhitecture"">Arhitecture#1</p>
    </section>
    <!-- SLider section end -->
    <!-- work section start -->
    <section id=""work"">
        <div class=""work"">
            <h2>Work</h2>
            <p>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis,
                rhoncus euismod erat
                tincidunt. Donec tincidunt volutpat erat.
            </p>
        </div>

        <div class=""work-items"">
            <!-- work single item start -->

");
#nullable restore
#line 38 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
             foreach (var work in Model.Works)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"image-cards\">\r\n                    <div class=\"work-item-cart \">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1169, "\"", 1186, 1);
#nullable restore
#line 42 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
WriteAttributeValue("", 1175, work.Image, 1175, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"place image\">\r\n                        <p class=\"title cart-text\">");
#nullable restore
#line 43 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                              Write(work.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"place cart-text\">");
#nullable restore
#line 44 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                              Write(work.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 47 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!-- work single item end -->
        </div>
    </section>
    <!-- work section end -->
    <!-- news section start -->
    <section id=""news-testimonials"">
        <div class=""news-testimonials-div"">
            <div class=""news news-testimonials-item"">
                <h2>News</h2>

");
#nullable restore
#line 60 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                 foreach (var news in Model.News)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"manila\">\r\n                        <p class=\"date\">");
#nullable restore
#line 63 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                   Write(news.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"manila-title\">\r\n                            ");
#nullable restore
#line 65 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                       Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p class=\"manila-text\">\r\n                           ");
#nullable restore
#line 68 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                      Write(Html.Raw(news.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n");
#nullable restore
#line 71 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""button-more"">
                    <button>MORE NEWS</button>
                </div>
            </div>
            <div class=""testimonials news-testimonials-item"">
                <h2>Testimonials</h2>
                <div class=""comments"">

");
#nullable restore
#line 80 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                     foreach (var testimonial in Model.Testimonials)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"comment\">\r\n                            <i>\r\n                                ");
#nullable restore
#line 85 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                           Write(testimonial.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </i></p>\r\n                        <p class=\"comment-writer\">");
#nullable restore
#line 87 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                             Write(testimonial.Writer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 88 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                </div>\r\n        </div>\r\n    </section>\r\n    <!-- news section end -->\r\n    <!-- features section start -->\r\n    <section id=\"features\">\r\n        <div class=\"features\">\r\n");
#nullable restore
#line 98 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
             foreach (var future in Model.Futures)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"features-item \">\r\n                    <div class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 3209, "\"", 3229, 1);
#nullable restore
#line 101 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
WriteAttributeValue("", 3217, future.icon, 3217, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n                    <div class=\"features-text\">\r\n                        <p class=\"features-title\">");
#nullable restore
#line 103 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                                             Write(future.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"features-text\">\r\n                            ");
#nullable restore
#line 105 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
                       Write(future.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p class=\"learn-more\">LEARN MORE</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 110 "C:\Users\mac\Desktop\BERYLLIUM\BackBeryllium\Beryllium\Beryllium\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n    <!-- features section end -->\r\n</main>\r\n<!-- main end -->\r\n");
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
