
using System.ComponentModel.DataAnnotations;

namespace MVCApplication1.Models
{
    public class Employee
    {
       [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int Phone { get; set; }

    }
}
