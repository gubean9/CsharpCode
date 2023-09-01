using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Hp { get; set; }


        public int No { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        //public DateTime DateTime { get; set; }
    }
}
