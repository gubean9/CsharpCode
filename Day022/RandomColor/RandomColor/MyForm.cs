namespace RandomColor
{
    public partial class MyForm : Form
    {
        private Random rand;
        //생성자가 먼저 뜨고 Load가 호출됨
        public MyForm()
        {
            InitializeComponent();

            Load += Form1_Load;
            //this는 생략가능
            this.MouseClick += RandomColorClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
        }

        //사용자 정의 메소드
        private void RandomColorClick(object sender, MouseEventArgs e)
        {
            int red = rand.Next(0, 255);
            int green = rand.Next(0, 255);
            int blue = rand.Next(0, 255);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}