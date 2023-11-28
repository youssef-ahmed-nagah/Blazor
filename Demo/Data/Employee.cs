using System.ComponentModel.DataAnnotations;

namespace Demo.Data
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3,ErrorMessage ="Name must be more than 3 char")]
        [MaxLength(10)]
        public string? Name { get; set; }

        [Range(2000,15000)]
        public int Salary { get; set; }

        public string Image { get; set; }
        public int Dept_Id { get; set; }
        public override string ToString()
        {
            return $"Name:{Name} - Salary : {Salary} -Dept :{Dept_Id}";
        }
    }
}
