#pragma checksum "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f75ab2ac5a0d407e0e280030b04fb15e22be3e6"
// <auto-generated/>
#pragma warning disable 1591
namespace Net5Wasm.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Net5Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Net5Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
using Net5Wasm.Models.Net5Wasmconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
using Net5Wasm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-shopping-carts-product")]
    public partial class AddShoppingCartsProduct : Net5Wasm.Pages.AddShoppingCartsProductComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Net5Wasm.Models.Net5Wasmconn.ShoppingCartsProduct>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Net5Wasm.Models.Net5Wasmconn.ShoppingCartsProduct>(
#nullable restore
#line 19 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                   shoppingcartsproduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                    shoppingcartsproduct != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Net5Wasm.Models.Net5Wasmconn.ShoppingCartsProduct>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Net5Wasm.Models.Net5Wasmconn.ShoppingCartsProduct>(this, 
#nullable restore
#line 19 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                                      Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                    L["ShoppingCartIdLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Component", "ShoppingCartId");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\r\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __Blazor.Net5Wasm.Client.Pages.AddShoppingCartsProduct.TypeInference.CreateRadzenDropDownDataGrid_0(__builder3, 24, 25, 
#nullable restore
#line 27 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                               getShoppingCartsForShoppingCartIdResult

#line default
#line hidden
#nullable disable
                    , 26, "UserId", 27, "Id", 28, 
#nullable restore
#line 27 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                               L["ShoppingCartId.Placeholder"]

#line default
#line hidden
#nullable disable
                    , 29, 
#nullable restore
#line 27 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                                                            false

#line default
#line hidden
#nullable disable
                    , 30, 
#nullable restore
#line 27 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                                                                           getShoppingCartsForShoppingCartIdCount

#line default
#line hidden
#nullable disable
                    , 31, "display: block; width: 100%", 32, "ShoppingCartId", 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 27 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                                                                                                                                                                                                                                             ShoppingCartIdLoadData

#line default
#line hidden
#nullable disable
                    ), 34, 
#nullable restore
#line 27 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                                                                                                                                                                      shoppingcartsproduct.ShoppingCartId

#line default
#line hidden
#nullable disable
                    , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shoppingcartsproduct.ShoppingCartId = __value, shoppingcartsproduct.ShoppingCartId)), 36, () => shoppingcartsproduct.ShoppingCartId);
                    __builder3.AddMarkupContent(37, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(38);
                    __builder3.AddAttribute(39, "Component", "ShoppingCartId");
                    __builder3.AddAttribute(40, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                           L["ShoppingCartIdRequiredValidator.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "style", "position: absolute");
                    __builder3.AddAttribute(42, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 29 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                               0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(46, "class", "row");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(49);
                    __builder3.AddAttribute(50, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                    L["ProductIdLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Component", "ProductId");
                    __builder3.AddAttribute(52, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\r\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __Blazor.Net5Wasm.Client.Pages.AddShoppingCartsProduct.TypeInference.CreateRadzenDropDownDataGrid_1(__builder3, 56, 57, 
#nullable restore
#line 39 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                               getProductsForProductIdResult

#line default
#line hidden
#nullable disable
                    , 58, "Name", 59, "Id", 60, 
#nullable restore
#line 39 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                   L["ProductId.Placeholder"]

#line default
#line hidden
#nullable disable
                    , 61, 
#nullable restore
#line 39 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                                           false

#line default
#line hidden
#nullable disable
                    , 62, 
#nullable restore
#line 39 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                                                          getProductsForProductIdCount

#line default
#line hidden
#nullable disable
                    , 63, "display: block; width: 100%", 64, "ProductId", 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 39 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                                                                                                                                                                                                        ProductIdLoadData

#line default
#line hidden
#nullable disable
                    ), 66, 
#nullable restore
#line 39 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                                                                                                                                           shoppingcartsproduct.ProductId

#line default
#line hidden
#nullable disable
                    , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shoppingcartsproduct.ProductId = __value, shoppingcartsproduct.ProductId)), 68, () => shoppingcartsproduct.ProductId);
                    __builder3.AddMarkupContent(69, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(70);
                    __builder3.AddAttribute(71, "Component", "ProductId");
                    __builder3.AddAttribute(72, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                      L["ProductIdRequiredValidator.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "style", "position: absolute");
                    __builder3.AddAttribute(74, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 41 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                                                     0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\r\n            ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(78, "class", "row");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(81);
                    __builder3.AddAttribute(82, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                    L["CreatedOnLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "Component", "CreatedOn");
                    __builder3.AddAttribute(84, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\r\n              ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-9");
                    __Blazor.Net5Wasm.Client.Pages.AddShoppingCartsProduct.TypeInference.CreateRadzenDatePicker_2(__builder3, 88, 89, "dd/MM/yyyy", 90, "display: block; width: 100%", 91, "CreatedOn", 92, 
#nullable restore
#line 51 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                             shoppingcartsproduct.CreatedOn

#line default
#line hidden
#nullable disable
                    , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shoppingcartsproduct.CreatedOn = __value, shoppingcartsproduct.CreatedOn)), 94, () => shoppingcartsproduct.CreatedOn);
                    __builder3.AddMarkupContent(95, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(96);
                    __builder3.AddAttribute(97, "Component", "CreatedOn");
                    __builder3.AddAttribute(98, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                      L["CreatedOnRequiredValidator.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\r\n            ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(103, "class", "row");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(106);
                    __builder3.AddAttribute(107, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                    L["ModifiedOnLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(108, "Component", "ModifiedOn");
                    __builder3.AddAttribute(109, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\r\n              ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-9");
                    __Blazor.Net5Wasm.Client.Pages.AddShoppingCartsProduct.TypeInference.CreateRadzenDatePicker_3(__builder3, 113, 114, "dd/MM/yyyy", 115, "width: 100%", 116, "ModifiedOn", 117, 
#nullable restore
#line 63 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                             shoppingcartsproduct.ModifiedOn

#line default
#line hidden
#nullable disable
                    , 118, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shoppingcartsproduct.ModifiedOn = __value, shoppingcartsproduct.ModifiedOn)), 119, () => shoppingcartsproduct.ModifiedOn);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n            ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(123, "class", "row");
                    __builder3.OpenElement(124, "div");
                    __builder3.AddAttribute(125, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(126);
                    __builder3.AddAttribute(127, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                    L["QuantityLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(128, "Component", "Quantity");
                    __builder3.AddAttribute(129, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(130, "\r\n              ");
                    __builder3.OpenElement(131, "div");
                    __builder3.AddAttribute(132, "class", "col-md-9");
                    __Blazor.Net5Wasm.Client.Pages.AddShoppingCartsProduct.TypeInference.CreateRadzenNumeric_4(__builder3, 133, 134, "display: block; width: 100%", 135, "Quantity", 136, 
#nullable restore
#line 73 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                  shoppingcartsproduct.Quantity

#line default
#line hidden
#nullable disable
                    , 137, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shoppingcartsproduct.Quantity = __value, shoppingcartsproduct.Quantity)), 138, () => shoppingcartsproduct.Quantity);
                    __builder3.AddMarkupContent(139, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(140);
                    __builder3.AddAttribute(141, "Component", "Quantity");
                    __builder3.AddAttribute(142, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 75 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                     L["QuantityRequiredValidator.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(143, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(144, "\r\n            ");
                    __builder3.OpenElement(145, "div");
                    __builder3.AddAttribute(146, "class", "row");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(149);
                    __builder3.AddAttribute(150, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 81 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(151, "Icon", "save");
                    __builder3.AddAttribute(152, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                L["button1.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(153, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 81 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(154, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(155);
                    __builder3.AddAttribute(156, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 83 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(157, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(158, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 83 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                               L["button2.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(159, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\AddShoppingCartsProduct.razor"
                                                                                                                          Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AddShoppingCartsProduct> L { get; set; }
    }
}
namespace __Blazor.Net5Wasm.Client.Pages.AddShoppingCartsProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDownDataGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, System.Object __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::Radzen.LoadDataArgs> __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg10, int __seq11, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg11)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "ShowSearch", __arg4);
        __builder.AddAttribute(__seq5, "Count", __arg5);
        __builder.AddAttribute(__seq6, "style", __arg6);
        __builder.AddAttribute(__seq7, "Name", __arg7);
        __builder.AddAttribute(__seq8, "LoadData", __arg8);
        __builder.AddAttribute(__seq9, "Value", __arg9);
        __builder.AddAttribute(__seq10, "ValueChanged", __arg10);
        __builder.AddAttribute(__seq11, "ValueExpression", __arg11);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDownDataGrid_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, System.Object __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::Radzen.LoadDataArgs> __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg10, int __seq11, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg11)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "ShowSearch", __arg4);
        __builder.AddAttribute(__seq5, "Count", __arg5);
        __builder.AddAttribute(__seq6, "style", __arg6);
        __builder.AddAttribute(__seq7, "Name", __arg7);
        __builder.AddAttribute(__seq8, "LoadData", __arg8);
        __builder.AddAttribute(__seq9, "Value", __arg9);
        __builder.AddAttribute(__seq10, "ValueChanged", __arg10);
        __builder.AddAttribute(__seq11, "ValueExpression", __arg11);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
