#pragma checksum "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\Pages\PatientDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "746b3a76e0f16747d4f5a89296cdc44724fbfc7e"
// <auto-generated/>
#pragma warning disable 1591
namespace Gestion_Cabinet_Front.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using Gestion_Cabinet_Front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\_Imports.razor"
using Gestion_Cabinet_Front.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PatientDetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/PatientDetails")]
    public partial class PatientDetails : PatientDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\">PatientDetails</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center m-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-8");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h1");
            __builder.AddAttribute(10, "class", "text-center");
            __builder.AddContent(11, 
#nullable restore
#line 11 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\Pages\PatientDetails.razor"
                                         Patient.prenom

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, "  ");
            __builder.AddContent(13, 
#nullable restore
#line 11 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\Pages\PatientDetails.razor"
                                                          Patient.nom

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "cart-body text-center");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "class", "card-img-top");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 15 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\Pages\PatientDetails.razor"
                                                Patient.photo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n                ");
            __builder.OpenElement(21, "h4");
            __builder.AddContent(22, " Patient ID : ");
            __builder.AddContent(23, 
#nullable restore
#line 17 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\Pages\PatientDetails.razor"
                                   Patient.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "h4");
            __builder.AddContent(26, " Email : ");
            __builder.AddContent(27, 
#nullable restore
#line 18 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\Pages\PatientDetails.razor"
                              Patient.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "h4");
            __builder.AddContent(30, " Adresse : ");
            __builder.AddContent(31, 
#nullable restore
#line 19 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\Pages\PatientDetails.razor"
                                Patient.Adresse

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "h4");
            __builder.AddContent(34, " Telephone : ");
            __builder.AddContent(35, 
#nullable restore
#line 20 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\Pages\PatientDetails.razor"
                                  Patient.Telephone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "h4");
            __builder.AddContent(38, " Date Naiss : ");
            __builder.AddContent(39, 
#nullable restore
#line 21 "C:\Users\daoud\Documents\IPSAS\3Ginfo\.Net core\Projet\Gestion_Cabinet_Front\Gestion_Cabinet_Front\Pages\PatientDetails.razor"
                                   Patient.Date_naiss.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<div class=\"card-footer text-center\"><a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                <a href=\"#\" class=\"btn btn-primary\">Edite</a>\r\n                <a href=\"#\" class=\"btn btn-danger\">Delete</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591