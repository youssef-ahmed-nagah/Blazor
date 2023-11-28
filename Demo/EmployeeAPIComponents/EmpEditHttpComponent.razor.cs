using Demo.Data;
using Microsoft.AspNetCore.Components;

namespace Demo.EmployeeAPIComponents
{
    public partial class EmpEditHttpComponent
    {
        [Parameter]
        public int id { get; set; }
        //[Inject]
        //public NavigationManager navManager { get; set; }
        public Employee myEmployee { get; set; }
        public List<Department> Depts { get; set; }
        protected override async Task OnInitializedAsync()
        {
            myEmployee = await EmpService.GetById(id);
            Depts =await  deptService.GetAll();
            base.OnInitializedAsync();
        }
        public async Task Save()
        {
            //service
            await EmpService.Update(id, myEmployee);
            Console.WriteLine(myEmployee);
            Console.WriteLine("Valid Data SAve Edit ");
            //redirect details
            navManager.NavigateTo($"/emp/details/{id}");
        }
        public void NotSave()
        {
            Console.WriteLine("not Valid Data SAve Edit ");

        }
    }
}
