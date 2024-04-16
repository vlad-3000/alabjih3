namespace alabjih3
{
    partial class Applicant
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            status = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F);
            label1.Location = new Point(203, 138);
            label1.Name = "label1";
            label1.Size = new Size(180, 26);
            label1.TabIndex = 0;
            label1.Text = "Статус заявления";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(203, 62);
            label2.Name = "label2";
            label2.Size = new Size(247, 26);
            label2.TabIndex = 1;
            label2.Text = "Фамилия Имя Отчество";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F);
            button1.Location = new Point(687, 300);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Times New Roman", 13.8F);
            status.Location = new Point(203, 178);
            status.Name = "status";
            status.Size = new Size(0, 26);
            status.TabIndex = 3;
            // 
            // Applicant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 341);
            Controls.Add(status);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Applicant";
            Text = "Applicant";
            FormClosing += Applicant_FormClosing;
            Load += Applicant_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label status;
    }
}