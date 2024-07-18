namespace college.forms
{
    partial class StudentForm
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
            textBoxName = new TextBox();
            textBoxCourse = new TextBox();
            buttonInsert = new Button();
            buttonPay = new Button();
            textBoxAmunet = new TextBox();
            labelBalance = new Label();
            labelCurrentBalance = new Label();
            label1 = new Label();
            label2 = new Label();
            buttonLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(329, 94);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(500, 47);
            textBoxName.TabIndex = 0;
            // 
            // textBoxCourse
            // 
            textBoxCourse.Location = new Point(355, 288);
            textBoxCourse.Name = "textBoxCourse";
            textBoxCourse.Size = new Size(474, 47);
            textBoxCourse.TabIndex = 1;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(94, 277);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(188, 58);
            buttonInsert.TabIndex = 2;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonPay
            // 
            buttonPay.Location = new Point(84, 452);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(188, 58);
            buttonPay.TabIndex = 3;
            buttonPay.Text = "pay";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // textBoxAmunet
            // 
            textBoxAmunet.Location = new Point(380, 452);
            textBoxAmunet.Name = "textBoxAmunet";
            textBoxAmunet.Size = new Size(449, 47);
            textBoxAmunet.TabIndex = 4;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Location = new Point(94, 618);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(222, 41);
            labelBalance.TabIndex = 5;
            labelBalance.Text = "current balance";
            // 
            // labelCurrentBalance
            // 
            labelCurrentBalance.AutoSize = true;
            labelCurrentBalance.Location = new Point(580, 618);
            labelCurrentBalance.Name = "labelCurrentBalance";
            labelCurrentBalance.Size = new Size(34, 41);
            labelCurrentBalance.TabIndex = 6;
            labelCurrentBalance.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(465, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
            label1.TabIndex = 7;
            label1.Text = "Student's name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 198);
            label2.Name = "label2";
            label2.Size = new Size(325, 41);
            label2.TabIndex = 8;
            label2.Text = "the name of the course";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(94, 94);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(188, 58);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "LogIn";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 397);
            label3.Name = "label3";
            label3.Size = new Size(316, 41);
            label3.TabIndex = 10;
            label3.Text = "the amount to be paid";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 1107);
            Controls.Add(label3);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelCurrentBalance);
            Controls.Add(labelBalance);
            Controls.Add(textBoxAmunet);
            Controls.Add(buttonPay);
            Controls.Add(buttonInsert);
            Controls.Add(textBoxCourse);
            Controls.Add(textBoxName);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxCourse;
        private Button buttonInsert;
        private Button buttonPay;
        private TextBox textBoxAmunet;
        private Label labelBalance;
        private Label labelCurrentBalance;
        private Label label1;
        private Label label2;
        private Button buttonLogin;
        private Label label3;
    }
}