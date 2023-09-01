namespace Diary_01.Models
{
    public class Diary
    {
        public int No { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        DateTime DateTime { get; set; }// = DateTime.Now;
    }
}
