using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        //[Required]
        //[Required(ErrorMessage = "이름을 작성해주세요.")]
        [StringLength(15, MinimumLength = 2)]
        public string Name { get; set; }
    }
}
