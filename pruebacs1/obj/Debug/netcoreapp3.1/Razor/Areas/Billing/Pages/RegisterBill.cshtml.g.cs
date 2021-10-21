#pragma checksum "C:\Users\daciros\OneDrive - Ucompensar\Documents\semillero\pcreasistemas\pruebacs1\Areas\Billing\Pages\RegisterBill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1bcd71719a14684df46e1f6898963447bcc4dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Billing_Pages_RegisterBill), @"mvc.1.0.razor-page", @"/Areas/Billing/Pages/RegisterBill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1bcd71719a14684df46e1f6898963447bcc4dc", @"/Areas/Billing/Pages/RegisterBill.cshtml")]
    public class Areas_Billing_Pages_RegisterBill : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            <div class=""titulo"">Nro. Factura:       </div>
        </div>
        <div class=""col-xs-2"">
            <div id=""numerofactura""></div>
        </div>
        <div class=""col-xs-2"">
            <div class=""titulo"">Autorizacion:       </div>
        </div>
        <div class=""col-xs-5"">
            <div id=""numeroauto""></div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-2"">
            <div class=""titulo"">Fecha Emision: </div>
        </div>
        <div class=""col-xs-2"">
            <div id=""fechaemision""></div>
        </div>
        <div class=""col-xs-2"">
            <div class=""titulo"">RUC Cliente:   </div>
        </div");
            WriteLiteral(@">
        <div class=""col-xs-5"">
            <div id=""rucCliente""></div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-xs-2"">
            <div class=""titulo"">Telefono:      </div>
        </div>
        <div class=""col-xs-2"">
            <div id=""telefono""></div>
        </div>
        <div class=""col-xs-2"">
            <div class=""titulo"">Direccion:     </div>
        </div>
        <div class=""col-xs-5"">
            <div id=""direccion""></div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-2"">
            <div class=""titulo"">Nombres/Razon: </div>
        </div>
        <div class=""col-xs-6"">
            <div id=""razon""></div>
        </div>
    </div>

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;Codigo&nbsp;&nbsp;&nbsp;</h4></th>
                <th><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Descripcion&nbsp;&nbsp;&nbs");
            WriteLiteral(@"p;&nbsp;&nbsp;&nbsp;&nbsp;</h4></th>
                <th><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;Cant.&nbsp;&nbsp;&nbsp;</h4></th>
                <th><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;&nbsp;P.Unit.&nbsp;&nbsp;&nbsp;&nbsp;</h4></th>
                <th><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;&nbsp;Dscto.&nbsp;&nbsp;&nbsp;&nbsp;</h4></th>
                <th><h4 class=""titulo"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Subtotal&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h4></th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class=""codigo""></td>
                <td class=""descripcion""></td>
                <td class=""cantidad izq""></td>
                <td class=""precio izq""></td>
                <td class=""descuento izq""></td>
                <td class=""subtotal izq""></td>
            </tr>
        </tbody>
    </table>
    <div class=""row sinespacio"">
        <div class=""col-xs-3"">
            <div><img src=""images/blanco.png""></div>
        </div>
        <div ");
            WriteLiteral(@"class=""col-xs-3"">
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
        </div>
    </div>
    <!--        <div class=""row sinespacio"">
                 <div class=""col-xs-3"">
                    <div><img src=""images/blanco.png""></div>
                </div>
                <div class=""col-xs-3"">
                    <div id=""blanco3""></div>
                </div>
                <");
            WriteLiteral(@"div class=""col-xs-3"">
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
            <div>Valor a Pagar:      </div>
        </div>
        <div class=""col-xs-3"">
            <div class=""izq borde"" id=""apagar""></div>
        </div>
    </div>
    <div class=""row limpiar""></div>
    <div class=""row"">
        <div class=""col-xs-4"">
            <div><img src=""images/favor.png""></div>
        </div>
        <div class=""col-xs-1""><img src=""images/blanco.png""></div>
        <div class=""col-xs-2"">
            <div><img src=""images/recibiConforme.png""></div>
        </div>");
            WriteLiteral(@"
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
            procedimiento  ejecutivo  o  verbal  sumario a eleccion de _____ sin protesto eximese de presentacion
            para el pago y de aviso por falta del mismo.
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-5 titulopie"">
            QUITO, ______ DE ____________ DEL ______
        </div>
        <div class=""col-xs-1""><img src=""images/blanco.png""></div>
        <div class=""col-xs-");
            WriteLiteral("2\">\r\n            <img src=\"images/cliente.png\">\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pruebacs1.Areas.Billing.Pages.RegisterBillModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pruebacs1.Areas.Billing.Pages.RegisterBillModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pruebacs1.Areas.Billing.Pages.RegisterBillModel>)PageContext?.ViewData;
        public pruebacs1.Areas.Billing.Pages.RegisterBillModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
