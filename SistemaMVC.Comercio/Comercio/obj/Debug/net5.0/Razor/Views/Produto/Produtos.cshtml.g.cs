#pragma checksum "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd2f35f5a8fde792b600b215bfa17264d425363"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Produtos), @"mvc.1.0.view", @"/Views/Produto/Produtos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd2f35f5a8fde792b600b215bfa17264d425363", @"/Views/Produto/Produtos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d203dc8a00f50d8d7278dc5ae1161af78da1fd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Produtos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Comercio.Models.ProdutoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
  
    ViewData["Title"] = "Produtos/filtrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"display-4\">PRODUTOS</h4>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
           Write(Html.DisplayNameFor(model => model.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
           Write(Html.DisplayNameFor(model => model.SetorDescricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
           Write(Html.DisplayNameFor(model => model.Preco_venda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
               Write(Html.DisplayFor(modelItem => item.SetorDescricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Preco_venda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd2f35f5a8fde792b600b215bfa17264d4253638738", async() => {
                WriteLiteral("Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\rbonotto\Documents\Pessoal\Projetos\Git\appMVC.Comercio\SistemaMVC.Comercio\Comercio\Views\Produto\Produtos.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<hr />\r\n<div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1661, "\"", 1668, 0);
            EndWriteAttribute();
            WriteLiteral(" onClick=\"history.go(-1); return false;\" class=\"btn btn-info btn-sm\"> VOLTAR</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Comercio.Models.ProdutoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
