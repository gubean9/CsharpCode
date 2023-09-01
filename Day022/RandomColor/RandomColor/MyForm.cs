namespace RandomColor
{
    public partial class MyForm : Form
    {
        private Random rand;
        //�����ڰ� ���� �߰� Load�� ȣ���
        public MyForm()
        {
            InitializeComponent();

            Load += Form1_Load;
            //this�� ��������
            this.MouseClick += RandomColorClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
        }

        //����� ���� �޼ҵ�
        private void RandomColorClick(object sender, MouseEventArgs e)
        {
            int red = rand.Next(0, 255);
            int green = rand.Next(0, 255);
            int blue = rand.Next(0, 255);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}