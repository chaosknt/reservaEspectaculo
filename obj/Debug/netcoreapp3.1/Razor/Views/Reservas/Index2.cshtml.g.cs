#pragma checksum "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80a73115538c6157fcaa00829e5af6c7c65f0b13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservas_Index2), @"mvc.1.0.view", @"/Views/Reservas/Index2.cshtml")]
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
#line 1 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\_ViewImports.cshtml"
using ReservaEspectaculo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\_ViewImports.cshtml"
using ReservaEspectaculo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a73115538c6157fcaa00829e5af6c7c65f0b13", @"/Views/Reservas/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"336ea67069a20b2673fe1024086e90c141a9f465", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservas_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservaEspectaculo.Models.Reserva>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
  
    ViewData["Title"] = "Index2";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Su Reserva</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaAlta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.Funcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadButacas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.ReservaActiva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaAlta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.Funcion.Pelicula.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadButacas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReservaActiva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 45 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
                 if (item.Funcion.Fecha < DateTime.Today.AddDays(-1))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Fecha de funcion</span>");
#nullable restore
#line 47 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Funcion.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <br /> <span>Hoy menos un dia</span>");
#nullable restore
#line 48 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
                                                  Write(DateTime.Today.AddDays(-1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
                                                                                  
                    //si la fecha de la funcion es mayor a la fecha de hoy menos un dia significa
                    //que faltan mas de 24 horas, entonces que pueda cancelar...

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a73115538c6157fcaa00829e5af6c7c65f0b138121", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
                                             WriteLiteral(item.ReservaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "G:\computadora\NuevasTecnologias\ReservaEspectaculo\Views\Reservas\Index2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservaEspectaculo.Models.Reserva>> Html { get; private set; }
    }
}
#pragma warning restore 1591
