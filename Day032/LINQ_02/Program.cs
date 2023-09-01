namespace LINQ_02
{
    class Profile
    {
        public string name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Profile[] arrProfile =
            {
                new Profile() { name = "정우성", Height = 186 },
                new Profile() { name = "김태희", Height = 158 },
                new Profile() { name = "고현정", Height = 172 },
                new Profile() { name = "이문세", Height = 178 },
                new Profile() { name = "하하", Height = 171 }
            };

            var profiles = from p in arrProfile
                           where p.Height >= 178
                           select p;

            foreach (var p in profiles)
                Console.WriteLine($"{p.name}, {p.Height}");




            /*
            var profiles = from p in arrProfile
                           where p.Height < 175
                           select p;

            foreach (var p in profiles)
                Console.WriteLine($"{p.name}, {p.Height}");
            */
        }
    }
}