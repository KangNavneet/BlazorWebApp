#pragma checksum "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\Pages\VoteComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "731f271719631949a2cd75500ac4034b08e8ce15"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebApplicationVote.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\_Imports.razor"
using BlazorWebApplicationVote;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\_Imports.razor"
using BlazorWebApplicationVote.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vote")]
    public partial class VoteComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Vote Component</h2>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.OpenElement(2, "b");
            __builder.AddContent(3, "Hii ");
            __builder.AddContent(4, 
#nullable restore
#line 3 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\Pages\VoteComponent.razor"
            nameValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "h3");
            __builder.AddAttribute(7, "class", ".text-danger");
            __builder.AddContent(8, " Current count: ");
            __builder.AddContent(9, 
#nullable restore
#line 4 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\Pages\VoteComponent.razor"
                                          currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "<br> ");
            __builder.AddContent(11, 
#nullable restore
#line 4 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\Pages\VoteComponent.razor"
                                                             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n");
            __builder.OpenElement(13, "form");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.AddMarkupContent(18, "<label for=\"name\" class=\"col-sm-2 col-form-label\">Enter Name</label><br>\r\n        ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "id", "name");
            __builder.AddAttribute(23, "name", "name");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\Pages\VoteComponent.razor"
                                                                 nameValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nameValue = __value, nameValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "<br>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.AddMarkupContent(31, "<label for=\"vote\" class=\"col-sm-2 col-form-label\">Enter Vote</label><br>\r\n        ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "number");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "id", "vote");
            __builder.AddAttribute(36, "name", "vote");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\Pages\VoteComponent.razor"
                                                                   currentValue

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentValue = __value, currentValue, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "<br>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\Pages\VoteComponent.razor"
                                          VoteCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\navne\source\repos\BlazorWebApplicationVote\BlazorWebApplicationVote\Pages\VoteComponent.razor"
       
    private String currentCount = "";
    private int currentValue;
    public String nameValue;
    private Boolean btnFlag = false;
    private String message;

    private void VoteCount()
    {
        btnFlag = true;

        if(currentValue>5 )
        {

            currentCount = "You cannot enter greater than 5";
            message = "";
        }
        else if(currentValue<1)
        {
            currentCount = "You cannot enter less than 1";
            message = "";
        }
        else
        {
            if(btnFlag)
            {
                currentCount = currentValue.ToString();
                message = "Thank you for your vote!";

            }
            else
            {
                currentCount = "Not Clicked Button";
                message = "";
            }

        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
