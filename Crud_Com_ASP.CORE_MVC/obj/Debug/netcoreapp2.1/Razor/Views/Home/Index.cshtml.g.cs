#pragma checksum "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bfeed3c73a1bd416341a964200ca39325e81534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfeed3c73a1bd416341a964200ca39325e81534", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Crud_Com_ASP.CORE_MVC.Models.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 5 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Lista de Clientes";

#line default
#line hidden
            BeginContext(147, 450, true);
            WriteLiteral(@"

<div class=""container-fluid p-5 "">
    <table class=""table"">

        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">id</th>
                <th scope=""col"" scope=""col"">Nome</th>
                <th scope=""col"">E-mail</th>
                <th scope=""col"">Telefone</th>
                <th scope=""col""> <a href=""/cadastrar/"" class=""btn btn-primary"">Cadastrar</a></th>
            </tr>
        </thead>
        <tbody>

");
            EndContext();
#line 24 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
             foreach (var cliente in @Model)
            {

#line default
#line hidden
            BeginContext(656, 57, true);
            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(714, 10, false);
#line 27 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
                               Write(cliente.id);

#line default
#line hidden
            EndContext();
            BeginContext(724, 42, true);
            WriteLiteral("</th>\n                    <td scope=\"col\">");
            EndContext();
            BeginContext(767, 12, false);
#line 28 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
                               Write(cliente.nome);

#line default
#line hidden
            EndContext();
            BeginContext(779, 42, true);
            WriteLiteral("</td>\n                    <td scope=\"col\">");
            EndContext();
            BeginContext(822, 13, false);
#line 29 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
                               Write(cliente.email);

#line default
#line hidden
            EndContext();
            BeginContext(835, 42, true);
            WriteLiteral("</td>\n                    <td scope=\"col\">");
            EndContext();
            BeginContext(878, 16, false);
#line 30 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
                               Write(cliente.telefone);

#line default
#line hidden
            EndContext();
            BeginContext(894, 69, true);
            WriteLiteral("</td>\n                    <td scope=\"col\">\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 963, "\"", 996, 2);
            WriteAttributeValue("", 970, "/editar/editar/", 970, 15, true);
#line 32 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 985, cliente.id, 985, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(997, 50, true);
            WriteLiteral(" class=\"btn\">Editar</a>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1047, "\"", 1079, 2);
            WriteAttributeValue("", 1054, "/home/excluir/", 1054, 14, true);
#line 33 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1068, cliente.id, 1068, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1080, 73, true);
            WriteLiteral(" class=\"btn\">Excluir</a>\n                    </td>\n                </tr>\n");
            EndContext();
#line 36 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1167, 32, true);
            WriteLiteral("        </tbody>\n\n    </table>\n\n");
            EndContext();
#line 41 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
     if (TempData["CadastroFeedback"] != null)
    {

#line default
#line hidden
            BeginContext(1252, 54, true);
            WriteLiteral("        <div class=\"alert alert-success\">\n            ");
            EndContext();
            BeginContext(1307, 28, false);
#line 44 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
       Write(TempData["CadastroFeedback"]);

#line default
#line hidden
            EndContext();
            BeginContext(1335, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 46 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1357, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 47 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
     if (TempData["MensagemExcluir"] != null)
    {

#line default
#line hidden
            BeginContext(1409, 54, true);
            WriteLiteral("        <div class=\"alert alert-success\">\n            ");
            EndContext();
            BeginContext(1464, 27, false);
#line 50 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
       Write(TempData["MensagemExcluir"]);

#line default
#line hidden
            EndContext();
            BeginContext(1491, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 52 "C:\Users\z0045u5v\Desktop\Crud-Asp.Net-Core-Mvc-master\Crud_Com_ASP.CORE_MVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1513, 11, true);
            WriteLiteral("\n\n\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Crud_Com_ASP.CORE_MVC.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
