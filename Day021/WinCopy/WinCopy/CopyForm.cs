namespace WinCopy
{
    public partial class CopyForm : Form
    {
        private string sourceFile;
        private string destFile;
        public CopyForm()
        {
            InitializeComponent(); //리소스 불러오기
        }

        private void btnSrcFile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    sourceFile = openFileDialog.FileName;
                    lblSrcPath.Text = sourceFile;
                }
            }
        }

        private void btnDstFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    destFile = saveFileDialog.FileName;
                    File.Copy(sourceFile, destFile, true); //혹시 파일이 있을 경우 덮어쓰기
                    lblDstPath.Text = "복사 완료" + destFile;
                }
            }
        }
    }
}