using System.ComponentModel.DataAnnotations;

namespace Name_Test.Models
{
    public class Student
    {
        //[Required]
        [Required(ErrorMessage = "이름을 입력하세요")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "이름은 2자 이상 15자 이하입니다")]
        public string Name { get; set; }

        [Required(ErrorMessage = "나이를 입력하세요")]
        [Range(20, 70, ErrorMessage = "20~70세까지 작성할 수 있습니다")]
        public int Age { get; set; }

        [Required(ErrorMessage = "패스워드를 적어주세요.")]
        [RegularExpression(@"(?=.*[a-zA-Z])(?=.*[0-9]).{8,25}$", ErrorMessage = "영문자로 대소문자와 숫자조합으로 8자리이상")]
        public string Password { get; set; }
    }
}
