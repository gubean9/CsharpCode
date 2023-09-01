namespace Quiz02
{
    partial class Form1
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
            btnSrcFile.Location = new Point(66, 67);
            btnSrcFile.Name = "btnSrcFile";
            btnSrcFile.Size = new Size(228, 123);
            btnSrcFile.TabIndex = 0;
            btnSrcFile.Text = "원본";
            btnSrcFile.UseVisualStyleBackColor = true;
            // 
            // btnDstFile
            // 
            btnDstFile.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDstFile.Location = new Point(66, 251);
            btnDstFile.Name = "btnDstFile";
            btnDstFile.Size = new Size(228, 123);
            btnDstFile.TabIndex = 1;
            btnDstFile.Text = "복사";
            btnDstFile.UseVisualStyleBackColor = true;
            // 
            // lblSrcPath
            // 
            lblSrcPath.AutoSize = true;
            lblSrcPath.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSrcPath.Location = new Point(348, 110);
            lblSrcPath.Name = "lblSrcPath";
            lblSrcPath.Size = new Size(140, 37);
            lblSrcPath.TabIndex = 2;
            lblSrcPath.Text = "원본파일 :";
            // 
            // lblDstPath
            // 
            lblDstPath.AutoSize = true;
            lblDstPath.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDstPath.Location = new Point(348, 294);
            lblDstPath.Name = "lblDstPath";
            lblDstPath.Size = new Size(140, 37);
            lblDstPath.TabIndex = 3;
            lblDstPath.Text = "복사파일 :";
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