#pragma checksum "C:\Users\Xinia Aguilar\Source\Repos\VideoTecProject\WebAppBD\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2372b5b0951ff31cbb67a5f5704b802e5e30868e"
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
#line 1 "C:\Users\Xinia Aguilar\Source\Repos\VideoTecProject\WebAppBD\Views\_ViewImports.cshtml"
using WebAppBD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Xinia Aguilar\Source\Repos\VideoTecProject\WebAppBD\Views\_ViewImports.cshtml"
using WebAppBD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2372b5b0951ff31cbb67a5f5704b802e5e30868e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57409e8ca004c7155c6ce682031a578bc56f04c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Xinia Aguilar\Source\Repos\VideoTecProject\WebAppBD\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "VIDEOTEC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Page Heading -->
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
    <a href=""#"" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"">
        <i class=""fas fa-download fa-sm text-white-50""></i> Generate Report
    </a>
</div>

<!-- Content Row -->
<div class=""row"">

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Earnings (Monthly)</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">$40,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-calendar fa-2x text-gray-");
            WriteLiteral(@"300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">Earnings (Annual)</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">$215,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-info shadow h-100 py");
            WriteLiteral(@"-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Tasks</div>
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col-auto"">
                                <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">50%</div>
                            </div>
                            <div class=""col"">
                                <div class=""progress progress-sm mr-2"">
                                    <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=");
            WriteLiteral(@"""fas fa-clipboard-list fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Pending Requests Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Pending Requests</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">18</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-comments fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Content Row -->

<div class=""row"">

    <!-- Area Chart -->
    <div class=""col-xl-8 col-lg-7"">
   ");
            WriteLiteral(@"     <div class=""card shadow mb-4"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Earnings Overview</h6>
                <div class=""dropdown no-arrow"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in"" aria-labelledby=""dropdownMenuLink"">
                        <div class=""dropdown-header"">Dropdown Header:</div>
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <div class=""dropdown-divider""></div>
                 ");
            WriteLiteral(@"       <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </div>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-area"">
                    <canvas id=""myAreaChart""></canvas>
                </div>
            </div>
        </div>
    </div>

    <!-- Pie Chart -->
    <div class=""col-xl-4 col-lg-5"">
        <div class=""card shadow mb-4"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Revenue Sources</h6>
                <div class=""dropdown no-arrow"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                  ");
            WriteLiteral(@"  </a>
                    <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in"" aria-labelledby=""dropdownMenuLink"">
                        <div class=""dropdown-header"">Dropdown Header:</div>
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </div>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-pie pt-4 pb-2"">
                    <canvas id=""myPieChart""></canvas>
                </div>
                <div class=""mt-4 text-center small"">
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-primary""></i> Direct
                    </span>
                    <span class=""mr-2"">
      ");
            WriteLiteral(@"                  <i class=""fas fa-circle text-success""></i> Social
                    </span>
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-info""></i> Referral
                    </span>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
