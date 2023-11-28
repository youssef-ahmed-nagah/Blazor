using Demo.Data;
using Demo.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Demo.EmployeeComponents
{
    public partial class EditEmployee
    {
        [Parameter]
        public int id { get; set; }
        //[Inject]
        //public NavigationManager navManager { get; set; }
        public Employee myEmployee { get; set; }
        public List<Department> Depts { get; set; }
        protected override void OnInitialized()
        {
            myEmployee = EmpService.getByID(id);
            Depts = deptService.getAll();
            base.OnInitialized();
        }
        public void Save()
        {
     
            Console.WriteLine(myEmployee);
            Console.WriteLine("Valid Data SAve Edit ");
            //redirect details
            navManager.NavigateTo($"/Employee/{id}");
        }
        public void NotSave()
        {
            Console.WriteLine("not Valid Data SAve Edit ");

        }
    }
}
