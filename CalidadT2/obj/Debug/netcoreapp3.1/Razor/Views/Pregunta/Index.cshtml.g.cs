#pragma checksum "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "189ff435fd7fb1fff3e3b917179e7ea5339f36d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pregunta_Index), @"mvc.1.0.view", @"/Views/Pregunta/Index.cshtml")]
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
#line 1 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\_ViewImports.cshtml"
using CalidadT2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\_ViewImports.cshtml"
using CalidadT2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"189ff435fd7fb1fff3e3b917179e7ea5339f36d9", @"/Views/Pregunta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f77fd08438e190fd541adb86d8778e3e6b70a9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pregunta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Tema: ");
#nullable restore
#line 2 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
     Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h4>Preguntas</h4>\n\n<a class=\"btn btn-primary float-right\"");
            BeginWriteAttribute("href", " href=\"", 88, "\"", 127, 2);
            WriteAttributeValue("", 95, "/Pregunta/Crear?temaId=", 95, 23, true);
#nullable restore
#line 5 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
WriteAttributeValue("", 118, Model.Id, 118, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Crear Pregunta</a>
<a class=""btn btn-link float-right"" href=""/Tema"">Ir a Temas</a>

<table class=""table table-borderless"">
    <thead>
        <tr>
            <th>#</th>
            <th>Pregunta</th>
            <th></th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 18 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
           var index = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
         foreach (var item in Model.Preguntas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td><strong>");
#nullable restore
#line 22 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
                       Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n                <td><strong>");
#nullable restore
#line 23 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n                <td class=\"text-right\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 665, "\"", 700, 2);
            WriteAttributeValue("", 672, "/Pregunta/Editar?id=", 672, 20, true);
#nullable restore
#line 25 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
WriteAttributeValue("", 692, item.Id, 692, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> |\n                    <a");
            BeginWriteAttribute("href", " href=\"", 737, "\"", 774, 2);
            WriteAttributeValue("", 744, "/Pregunta/Eliminar?id=", 744, 22, true);
#nullable restore
#line 26 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
WriteAttributeValue("", 766, item.Id, 766, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a>\n                </td>\n            </tr>\n            <tr>\n                <td colspan=\"3\">\n                    <ul>\n");
#nullable restore
#line 32 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
                         foreach (var alt in item.Alternativas)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\n                                ");
#nullable restore
#line 35 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
                           Write(alt.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
                                                  if (alt.EsCorrecto) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong>(X)</strong> ");
#nullable restore
#line 35 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </li>\n");
#nullable restore
#line 37 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </td>\n            </tr>\n");
#nullable restore
#line 41 "C:\Users\Miguel Aliaga\Desktop\CalidadT2\CalidadT2\Views\Pregunta\Index.cshtml"
            index++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n</table>\n");
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
