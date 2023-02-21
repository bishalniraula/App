using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime DateTime { get; set; }
    }
}
