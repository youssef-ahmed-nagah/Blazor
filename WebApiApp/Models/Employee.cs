using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }


        public int Salary { get; set; }
        public string Image { get; set; }
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }

        public Department? Department { get; set; }
    }
}
