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
#line 2 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Index.razor"
using mamun_SchoolApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\AhmadFarhat\Documents\GitHub\mamun_SchoolApp\Pages\Index.razor"
      
    Students Student = new Students();
    List<Students> Students = new List<Students>();

    protected override void OnInitialized()
    {
        LoadItems();
    }

    private void LoadItems()
    {
        Students = new List<Students>();
        Students = studentsRepository.Gets();
    }

    private void GetItem(int id)
    {
        Student = studentsRepository.Get(id);
    }

    private void DeleteItem(int id)
    {
        string message = studentsRepository.Delete(id);
    }

    private void SaveItem()
    {
        if (Student.id == 0) Student = studentsRepository.Save(Student);
        else Student = studentsRepository.Update(Student);
        Student = new Students();
        LoadItems();
    }


    private void SetItemValue(Students student)
    {
        Student = student;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private mamun_SchoolApp.IRepository.IStudentsRepository studentsRepository { get; set; }
    }
}
#pragma warning restore 1591
