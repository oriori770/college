namespace college.forms
{
    partial class MainForm1
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
            buttonStudent = new Button();
            buttonAdministrator = new Button();
            SuspendLayout();
            // 
            // buttonStudent
            // 
            buttonStudent.Location = new Point(51, 90);
            buttonStudent.Name = "buttonStudent";
            buttonStudent.Size = new Size(264, 153);
            buttonStudent.TabIndex = 0;
            buttonStudent.Text = "sign in as a student";
            buttonStudent.UseVisualStyleBackColor = true;
            buttonStudent.Click += buttonStudent_Click;
            // 
            // buttonAdministrator
            // 
            buttonAdministrator.Location = new Point(375, 90);
            buttonAdministrator.Name = "buttonAdministrator";
            buttonAdministrator.Size = new Size(336, 158);
            buttonAdministrator.TabIndex = 1;
            buttonAdministrator.Text = "Sign in as an administrator";
            buttonAdministrator.UseVisualStyleBackColor = true;
            buttonAdministrator.Click += buttonAdministrator_Click;
            // 
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdministrator);
            Controls.Add(buttonStudent);
            Name = "MainForm1";
            Text = "MainForm1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStudent;
        private Button buttonAdministrator;
    }
}