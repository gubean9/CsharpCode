using System.ComponentModel.DataAnnotations;

namespace SmartFactory_MinProject.Models
{
    public class Codeboard
    {
        
        public int Id { get; set; }

        [StringLength(25, ErrorMessage = "제목은 25자 이하로 입력 가능합니다")]
        public string Title { get; set; }

        [StringLength(25, ErrorMessage = "25자 이하로 입력해주세요")]
        public string Name { get; set; }

        public string Contents { get; set; }
        public DateTime Date { get; set; } = DateTime.Now.Date;

        public ICollection<Comment>? Comments { get; set; }
	}
}
