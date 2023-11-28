using Demo.Data;

namespace Demo.Services
{
    public class EmployeeService
    {
        List<Employee> emps = new List<Employee>();
        public EmployeeService()
        {
            emps.Add(new Employee { Id = 1, Name = "ahmed", Salary = 1000, Image = "Man.png", Dept_Id = 1 });
            emps.Add(new Employee { Id = 2, Name = "Mohamed", Salary = 2000, Image = "Man.png", Dept_Id = 2 });
            emps.Add(new Employee { Id = 3, Name = "Eman", Salary = 3000, Image = "Woman.png", Dept_Id = 3 });
            emps.Add(new Employee { Id = 4, Name = "Sara", Salary = 4000, Image = "Woman.png", Dept_Id = 4 });
        }
        public List<Employee> getAll()
        {
            return emps;
        }
        public Employee getByID(int id)
        {
            return emps.FirstOrDefault(e => e.Id == id);
        }

    }
}
