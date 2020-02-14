#pragma checksum "/Users/bond/CBBlazorEFID/Pages/CustomerPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f48cfb2319f7581a0f298a81e00958ac8951833"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CBBlazorEFID.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/bond/CBBlazorEFID/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/bond/CBBlazorEFID/_Imports.razor"
using CBBlazorEFID;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/bond/CBBlazorEFID/_Imports.razor"
using CBBlazorEFID.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/bond/CBBlazorEFID/_Imports.razor"
using CBBlazorEFID.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/bond/CBBlazorEFID/_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bond/CBBlazorEFID/Pages/CustomerPage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customer")]
    public partial class CustomerPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "/Users/bond/CBBlazorEFID/Pages/CustomerPage.razor"
       
    string name;
    bool isLoadded;
    List<Customer> customers = new List<Customer>();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            customers = await db.Customers.ToListAsync();
            isLoadded = true;
            logger.LogInformation($"Customer loadded");
            StateHasChanged();
        }
    }

    async void Create()
    {
        isLoadded = false;
        StateHasChanged();

        var customer = new Customer { Name = name };
        await db.AddAsync(customer);
        await db.SaveChangesAsync();
        customers = await db.Customers.ToListAsync();
        isLoadded = true;        
        logger.LogInformation($"Customer({name}) created.");
        StateHasChanged();
    }

    async void Delete(int id)
    {
        isLoadded = false;
        StateHasChanged();

        var customer = await db.Customers.FindAsync(id);

        db.Remove(customer);
        await db.SaveChangesAsync();

        customers = await db.Customers.ToListAsync();
        isLoadded = true;        
        logger.LogInformation($"Customer({name}) deleted.");
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Customer> logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppDbContext db { get; set; }
    }
}
#pragma warning restore 1591
