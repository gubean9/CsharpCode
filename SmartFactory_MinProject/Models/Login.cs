using System.ComponentModel.DataAnnotations;

namespace SmartFactory_MinProject.Models
{
    public class Login
    {
        [Required(ErrorMessage = "아이디를 입력하세요.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
