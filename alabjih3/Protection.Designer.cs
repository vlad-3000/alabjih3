namespace alabjih3
{
    partial class Protection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F);
            textBox1.Location = new Point(263, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 30);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F);
            button1.Location = new Point(263, 285);
            button1.Name = "button1";
            button1.Size = new Size(197, 37);
            button1.TabIndex = 1;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(333, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 2;
            label1.Text = "логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(333, 134);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 5;
            label2.Text = "пароль";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F);
            button2.Location = new Point(263, 211);
            button2.Name = "button2";
            button2.Size = new Size(197, 40);
            button2.TabIndex = 4;
            button2.Text = "Вход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F);
            textBox2.Location = new Point(263, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 30);
            textBox2.TabIndex = 3;
            // 
            // Protection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 450);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Protection";
            Text = "Protection";
            FormClosing += Protection_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
    }
}