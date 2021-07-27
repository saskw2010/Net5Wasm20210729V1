// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 11 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\admin\source\repos\Net5Wasm20210729\client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/example-upload")]
    public partial class UploadPagez : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\admin\source\repos\Net5Wasm20210729\client\Pages\UploadPagez.razor"
       
    EventConsole console;

    RadzenUpload upload;

    int progress;
    string info;

    int customParameter = 1;

    void OnChange(UploadChangeEventArgs args, string name)
    {
        foreach (var file in args.Files)
        {
            console.Log($"File: {file.Name} / {file.Size} bytes");
        }

        console.Log($"{name} changed");
    }

    void OnProgress(UploadProgressArgs args, string name)
    {
        this.info = $"% '{name}' / {args.Loaded} of {args.Total} bytes.";
        this.progress = args.Progress;

        if (args.Progress == 100)
        {
            console.Clear();

            foreach (var file in args.Files)
            {
                console.Log($"Uploaded: {file.Name} / {file.Size} bytes");
            }
        }
    }

    void OnComplete(UploadCompleteEventArgs args)
    {
        console.Log($"Server response: {args.RawResponse}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
