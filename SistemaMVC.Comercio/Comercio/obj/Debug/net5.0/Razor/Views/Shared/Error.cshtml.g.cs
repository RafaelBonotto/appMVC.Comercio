#pragma checksum "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db41b38bf8ea3294e46fca4f45f65a6a04bd65b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\_ViewImports.cshtml"
using Comercio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\_ViewImports.cshtml"
using Comercio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db41b38bf8ea3294e46fca4f45f65a6a04bd65b7", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d203dc8a00f50d8d7278dc5ae1161af78da1fd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">OPS !!</h1>\r\n<h2 class=\"text-danger\">Um erro ocorreu durante o processamento da sua requisição.</h2>\r\n\r\n<h3>Mensagem: </h3>");
#nullable restore
#line 9 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Shared\Error.cshtml"
              Write(Model.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n<p>\r\n    <strong>Para maiores informações entre em contato com o administrador do sistema.</strong>    \r\n</p>\r\n\r\n<div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 368, "\"", 375, 0);
            EndWriteAttribute();
            WriteLiteral(" onClick=\"history.go(-1); return false;\" class=\"btn btn-info btn-sm\"> VOLTAR</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
