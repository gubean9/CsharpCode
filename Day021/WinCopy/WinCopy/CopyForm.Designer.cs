namespace WinCopy
{
    partial class CopyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSrcFile = new Button();
            btnDstFile = new Button();
            lblSrcPath = new Label();
            lblDstPath = new Label();
            SuspendLayout();
            // 
            // btnSrcFile
            // 
            btnSrcFile.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSrcFile.Location = new Point(100, 64);
            btnSrcFile.Name = "btnSrcFile";
            btnSrcFile.Size = new Size(198, 116);
            btnSrcFile.TabIndex = 0;
            btnSrcFile.Text = "원본(Src)";
            btnSrcFile.UseVisualStyleBackColor = true;
            btnSrcFile.Click += btnSrcFile_Click;
            // 
            // btnDstFile
            // 
            btnDstFile.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDstFile.Location = new Point(100, 253);
            btnDstFile.Name = "btnDstFile";
            btnDstFile.Size = new Size(198, 116);
            btnDstFile.TabIndex = 1;
            btnDstFile.Text = "복사(Dst)";
            btnDstFile.UseVisualStyleBackColor = true;
            // 
            // lblSrcPath
            // 
            lblSrcPath.AutoSize = true;
            lblSrcPath.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSrcPath.Location = new Point(452, 104);
            lblSrcPath.Name = "lblSrcPath";
            lblSrcPath.Size = new Size(188, 37);
            lblSrcPath.TabIndex = 2;
            lblSrcPath.Text = "원본파일 경로";
            // 
            // lblDstPath
            // 
            lblDstPath.AutoSize = true;
            lblDstPath.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDstPath.Location = new Point(452, 293);
            lblDstPath.Name = "lblDstPath";
            lblDstPath.Size = new Size(188, 37);
            lblDstPath.TabIndex = 3;
            lblDstPath.Text = "복사파일 경로";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDstPath);
            Controls.Add(lblSrcPath);
            Controls.Add(btnDstFile);
            Controls.Add(btnSrcFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSrcFile;
        private Button btnDstFile;
        private Label lblSrcPath;
        private Label lblDstPath;
    }
}