namespace WinCopy
{
    public partial class CopyForm : Form
    {
        private string sourceFile;
        private string destFile;
        public CopyForm()
        {
            InitializeComponent(); //���ҽ� �ҷ�����
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
                    File.Copy(sourceFile, destFile, true); //Ȥ�� ������ ���� ��� �����
                    lblDstPath.Text = "���� �Ϸ�" + destFile;
                }
            }
        }
    }
}