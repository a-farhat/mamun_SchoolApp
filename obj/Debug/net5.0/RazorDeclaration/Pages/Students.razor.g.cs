// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
