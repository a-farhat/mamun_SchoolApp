#pragma checksum "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f433fe80c725f699e2ce6de4b10cbdee2f290f1"
// <auto-generated/>
#pragma warning disable 1591
namespace mamun_SchoolApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using mamun_SchoolApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\_Imports.razor"
using mamun_SchoolApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
using mamun_SchoolApp.Data.EFCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
using mamun_SchoolApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "}\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>mamun school app</h1>\r\n\r\n\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                                 student.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.Id = __value, student.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 90 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                                 student.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.name = __value, student.name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                                 student.date_of_birth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.date_of_birth = __value, student.date_of_birth));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 96 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                                 student.ClassId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.ClassId = __value, student.ClassId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                                 student.CountryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.CountryId = __value, student.CountryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-success");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                                            e=>SaveItem()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table table-striped table-bordered");
            __builder.AddMarkupContent(34, "<thead><tr><th>id</th>\r\n            <th>name</th>\r\n            <th>DOB</th>\r\n            <th>Class</th>\r\n            <th>Country</th>\r\n            <th>Actions</th></tr></thead>\r\n    ");
            __builder.OpenElement(35, "tbody");
#nullable restore
#line 115 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
         foreach (Models.Students student in students)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 118 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                     student.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 119 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                     student.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 120 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                     student.date_of_birth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 121 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                     student.ClassId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 122 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                     student.CountryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n                ");
            __builder.OpenElement(52, "td");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 125 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                                                                e=>GetItem(@student.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-danger");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
                                                               e=>DeleteItem(@student.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 129 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Students.razor"
      

    private Models.Students student = new Models.Students();
    private List<Models.Students> students = new List<Models.Students>();




    protected override async Task OnInitializedAsync()
    {
        students = await Task.Run(() => studentsRepository.GetAll());

    }


    private async Task LoadItems()
    {
        List<Models.Students> students = new List<Models.Students>();
        students = await Task.Run(() => studentsRepository.GetAll());
    }

    private async Task GetItem(int id)
    {
        //Models.Students student = new Models.Students();
        student = await Task.Run(() => studentsRepository.Get(id));

    }

    private async Task DeleteItem(int id)
    {
        await Task.Run(() => studentsRepository.Delete(id));
        await LoadItems();
    }

    private async Task SaveItem()
    {
        if (student.Id == 0)
            student = await studentsRepository.Add(student);
        else student = await studentsRepository.Update(student);

        student = new Models.Students();

        await LoadItems();
    }


    private void SetItemValue(Models.Students student)
    {
        this.student = student;
    }

    //private async Task StudentsCountPerClass()
    //{
    //    List<Models.Students> students = new List<Models.Students>();
    //    students = await Task.Run(() => studentsRepository.GetAll());

    //    string result = String.Empty;
    //    var studentByClass = from s in students
    //                         group s by s.ClassId;

    //    foreach (var grp in studentByClass)
    //    {
    //        result += "<tr>"  +grp.Key+ "</tr>"; //Each group has a key 

    //        foreach (Models.Students s in grp) // Each group has inner collection
    //            result += "<td>"  +s.name+  "</td>";
    //    }

    //    result += "<tbody>" + result + "</tbody>";


    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private mamun_SchoolApp.Data.EFCore.EfCoreStudentsRepository studentsRepository { get; set; }
    }
}
#pragma warning restore 1591
