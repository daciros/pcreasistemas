#pragma checksum "C:\Users\daciros\source\prueba\pruebacs1\pruebacs1\Areas\Billing\Pages\RegisterBill\RegisterBill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f998001d87d7037593c6ad9bca01d93d1b9d2e49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(pruebacs1.Areas.Billing.Pages.RegisterBill.Areas_Billing_Pages_RegisterBill_RegisterBill), @"mvc.1.0.razor-page", @"/Areas/Billing/Pages/RegisterBill/RegisterBill.cshtml")]
namespace pruebacs1.Areas.Billing.Pages.RegisterBill
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
#line 1 "C:\Users\daciros\source\prueba\pruebacs1\pruebacs1\Areas\Billing\Pages\_ViewImports.cshtml"
using pruebacs1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daciros\source\prueba\pruebacs1\pruebacs1\Areas\Billing\Pages\_ViewImports.cshtml"
using pruebacs1.Areas.Billing.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daciros\source\prueba\pruebacs1\pruebacs1\Areas\Billing\Pages\_ViewImports.cshtml"
using pruebacs1.Areas.Billing.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "Billing/RegisterBill")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f998001d87d7037593c6ad9bca01d93d1b9d2e49", @"/Areas/Billing/Pages/RegisterBill/RegisterBill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c589672eb0a8ac982d587cd847029e7581a51edb", @"/Areas/Billing/Pages/_ViewImports.cshtml")]
    public class Areas_Billing_Pages_RegisterBill_RegisterBill : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-xs-4""><img src=""images/logo.png""></div>
        <div class=""col-xs-4""><img src=""images/direccion.png""></div>
        <div class=""col-xs-4""><img src=""images/factura.png""></div>
    </div>
    <hr>
    <div class=""row"">
        <div class=""col-xs-2"">
            <div class=""titulo"">N°. Bill:       </div>
        </div>
        <div class=""col-xs-2"">
            <div id=""numbill""></div>
        </div>
        <div class=""col-xs-2"">
            <div class=""titulo"">Autorization:       </div>
        </div>
        <div class=""col-xs-5"">
            <div id=""autorization""></div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-2"">
            <div class=""titulo"">Broadcast Date: </div>
        </div>
        <div class=""col-xs-2"">
            <div id=""broadcst date""></div>
        </div>
        <div class=""col-xs-2"">
            <div class=""titulo"">RUC Client:   </div>
        </div>
    ");
            WriteLiteral(@"    <div class=""col-xs-5"">
            <div id=""rucClient""></div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-xs-2"">
            <div class=""titulo"">Phone:      </div>
        </div>
        <div class=""col-xs-2"">
            <div id=""Phone""></div>
        </div>
        <div class=""col-xs-2"">
            <div class=""titulo"">Address:     </div>
        </div>
        <div class=""col-xs-5"">
            <div id=""address""></div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-2"">
            <div class=""titulo"">Names/Business Name: </div>
        </div>
        <div class=""col-xs-6"">
            <div id=""Business_Name""></div>
        </div>
    </div>

    <div class=""table table-bordered"">
        <div class=""table-primary"">
            <div class=""row"">
                <div class=""col""><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;Code&nbsp;&nbsp;&nbsp;</h4></div>
                <div class=""col""><h4 class=""titulo"">&nbsp;&nbsp;&nbsp");
            WriteLiteral(@";&nbsp;&nbsp;&nbsp;&nbsp;Description&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h4></div>
                <div class=""col""><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;Cant.&nbsp;&nbsp;&nbsp;</h4></div>
                <div class=""col""><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;&nbsp;Price.Unit.&nbsp;&nbsp;&nbsp;&nbsp;</h4></div>
                <div class=""col""><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;&nbsp;Tax.&nbsp;&nbsp;&nbsp;&nbsp;</h4></div>
                <div class=""col""><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;&nbsp;Discount.&nbsp;&nbsp;&nbsp;&nbsp;</h4></div>
                <div class=""col""><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Subtotal&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h4></div>
            </div>
        </div>
        <div class=""table tab-content"">
            <div class=""row"">
                <div class=""col"" class=""Code""></div>
                <div class=""col"" class=""Description""></div>
                <div class=""col"" class=""Cant ""></div>
                <div class=""col"" class=""p");
            WriteLiteral(@"rice""></div>
                <div class=""col"" class=""Discount""></div>
                <div class=""col"" class=""Subtotal""></div>
            </div>
        </div>
    </div>
    <div class=""row sinespacio"">
        <div class=""col-xs-3"">
            <div><img src=""images/blanco.png""></div>
        </div>
        <div class=""col-xs-3"">
            <div id=""blanco1""></div>
        </div>
        <div class=""col-xs-3"">
            <div>Total Sin Impto.:   </div>
        </div>
        <div class=""col-xs-3"">
            <div class=""izq borde"" id=""totalSinImpto""></div>
        </div>
    </div>
    <div class=""row sinespacio"">
        <div class=""col-xs-3"">
            <div><img src=""images/blanco.png""></div>
        </div>
        <div class=""col-xs-3"">
            <div id=""blanco2""></div>
        </div>
        <div class=""col-xs-3"">
            <div>Impuesto 12%:       </div>
        </div>
        <div class=""col-xs-3"">
            <div class=""izq borde"" id=""valorImpto12""></div>
 ");
            WriteLiteral(@"       </div>
    </div>
    <!--        <div class=""row sinespacio"">
                 <div class=""col-xs-3"">
                    <div><img src=""images/blanco.png""></div>
                </div>
                <div class=""col-xs-3"">
                    <div id=""blanco3""></div>
                </div>
                <div class=""col-xs-3"">
                    <div>Impuesto 0%:        </div>
                </div>
                <div class=""col-xs-3"">
                    <div class=""izq borde"" id=""valorImpto0""></div>
                </div>
            </div>  -->
    <div class=""row sinespacio"">
        <div class=""col-xs-3"">
            <div><img src=""images/blanco.png""></div>
        </div>
        <div class=""col-xs-3"">
            <div id=""blanco4""></div>
        </div>
        <div class=""col-xs-3"">
            <div>Total:      </div>
        </div>
        <div class=""col-xs-3"">
            <div class=""izq borde"" id=""apagar""></div>
        </div>
    </div>
    <div class=""ro");
            WriteLiteral(@"w limpiar""></div>
    <div class=""row"">
        <div class=""col-xs-4"">
            <div><img src=""images/favor.png""></div>
        </div>
        <div class=""col-xs-1""><img src=""images/blanco.png""></div>
        <div class=""col-xs-2"">
            <div><img src=""images/recibiConforme.png""></div>
        </div>
        <div class=""col-xs-1""><img src=""images/blanco.png""></div>
        <div class=""col-xs-2"">
            <div><img src=""images/aceptado.png""></div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-8 titulopie"">
            Debo y pagare incondicionalmente a la orden de _____ la cantidad de _________ en esra ciudad de Quito
            En  caso de  mora me  comprometo a  pagar el interes del _____ anual  desde su  vencimiento  hasta la
            cancelacion  de  la  deuda. En  el evento de juicio me someto a los jueces de la ciudad de Quito y al
            procedimiento  ejecutivo  o  verbal  sumario a eleccion de _____ sin protesto eximese de presentaci");
            WriteLiteral(@"on
            para el pago y de aviso por falta del mismo.
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-5 titulopie"">
            QUITO, ______ DE ____________ DEL ______
        </div>
        <div class=""col-xs-1""><img src=""images/blanco.png""></div>
        <div class=""col-xs-2"">
            <img src=""images/cliente.png"">
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterBillModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterBillModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterBillModel>)PageContext?.ViewData;
        public RegisterBillModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
