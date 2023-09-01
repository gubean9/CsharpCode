namespace WinFormsApp001
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            btn_finish = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(156, 94);
            button1.TabIndex = 0;
            button1.Text = "왕버튼";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 12);
            button2.Name = "button2";
            button2.Size = new Size(373, 117);
            button2.TabIndex = 1;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(22, 199);
            button3.Name = "button3";
            button3.Size = new Size(146, 132);
            button3.TabIndex = 2;
            button3.Text = "절대 누르지 마세요";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 23);
            textBox1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(310, 297);
            button4.Name = "button4";
            button4.Size = new Size(138, 50);
            button4.TabIndex = 4;
            button4.Text = "내용 지우기";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btn_finish
            // 
            btn_finish.Location = new Point(539, 286);
            btn_finish.Name = "btn_finish";
            btn_finish.Size = new Size(121, 90);
            btn_finish.TabIndex = 5;
            btn_finish.Text = "종료 버튼";
            btn_finish.UseVisualStyleBackColor = true;
            btn_finish.Click += btn_finish_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_finish);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Button btn_finish;
    }
}