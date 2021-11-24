#pragma checksum "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bd4ec74022a39c1218e06a7b9f0ed8dd866a462"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails")]
    public partial class EmployeeDetails : EmployeeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
 if (Employee == null)
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 10 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center m-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-8");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h1");
#nullable restore
#line 17 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
__builder.AddContent(10, Employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, " ");
#nullable restore
#line 17 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
__builder.AddContent(12, Employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body text-center");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "class", "card-img-top");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 21 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                    Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n                    ");
            __builder.OpenElement(20, "h4");
            __builder.AddContent(21, "Employee ID : ");
#nullable restore
#line 23 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
__builder.AddContent(22, Employee.EmployeeId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "h4");
            __builder.AddContent(25, "Email : ");
#nullable restore
#line 24 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
__builder.AddContent(26, Employee.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "h4");
            __builder.AddContent(29, "Department : ");
#nullable restore
#line 25 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
__builder.AddContent(30, Employee.Department == null ? "N/A" : Employee.Department.DepartmentName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.AddMarkupContent(32, "<div class=\"card-footer text-center\"><a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                    <a href=\"#\" class=\"btn btn-primary\">Edit</a>\r\n                    <a href=\"#\" class=\"btn btn-danger\">Delete</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "D:\Coding\Blazor\BlazorTutorial\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591