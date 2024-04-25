namespace UniversityEnvironment.View.Forms
{
    partial class RegistrationForm
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
            RegistrateAccountButton = new Button();
            GoBackButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PasswordTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            groupBox1 = new GroupBox();
            StudentCheck = new RadioButton();
            TeacherCheck = new RadioButton();
            AdminCheck = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrateAccountButton
            // 
            RegistrateAccountButton.BackColor = SystemColors.ControlLightLight;
            RegistrateAccountButton.FlatStyle = FlatStyle.Flat;
            RegistrateAccountButton.Location = new Point(120, 260);
            RegistrateAccountButton.Name = "RegistrateAccountButton";
            RegistrateAccountButton.Size = new Size(172, 49);
            RegistrateAccountButton.TabIndex = 3;
            RegistrateAccountButton.Text = "Registrate";
            RegistrateAccountButton.UseVisualStyleBackColor = false;
            RegistrateAccountButton.Click += RegistrateAccountButton_Click;
            // 
            // GoBackButton
            // 
            GoBackButton.BackColor = SystemColors.ControlLightLight;
            GoBackButton.FlatStyle = FlatStyle.Flat;
            GoBackButton.Location = new Point(12, 315);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(280, 41);
            GoBackButton.TabIndex = 3;
            GoBackButton.Text = "Go back";
            GoBackButton.UseVisualStyleBackColor = false;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(169, 202);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(19, 168);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Location = new Point(27, 134);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(120, 73);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Login";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(120, 225);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(172, 27);
            PasswordTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(111, 165);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(181, 27);
            LastNameTextBox.TabIndex = 6;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(12, 96);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(280, 27);
            UsernameTextBox.TabIndex = 8;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(111, 131);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(181, 27);
            FirstNameTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(StudentCheck);
            groupBox1.Controls.Add(TeacherCheck);
            groupBox1.Controls.Add(AdminCheck);
            groupBox1.Location = new Point(12, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(88, 93);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // StudentCheck
            // 
            StudentCheck.AutoSize = true;
            StudentCheck.Checked = true;
            StudentCheck.Location = new Point(0, 68);
            StudentCheck.Name = "StudentCheck";
            StudentCheck.Size = new Size(89, 24);
            StudentCheck.TabIndex = 0;
            StudentCheck.TabStop = true;
            StudentCheck.Text = "Student?";
            StudentCheck.UseVisualStyleBackColor = true;
            // 
            // TeacherCheck
            // 
            TeacherCheck.AutoSize = true;
            TeacherCheck.Location = new Point(0, 40);
            TeacherCheck.Name = "TeacherCheck";
            TeacherCheck.Size = new Size(92, 24);
            TeacherCheck.TabIndex = 0;
            TeacherCheck.Text = "Teacher?";
            TeacherCheck.UseVisualStyleBackColor = true;
            // 
            // AdminCheck
            // 
            AdminCheck.Location = new Point(0, 10);
            AdminCheck.Name = "AdminCheck";
            AdminCheck.Size = new Size(107, 30);
            AdminCheck.TabIndex = 0;
            AdminCheck.Text = "Admin?";
            AdminCheck.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 368);
            Controls.Add(groupBox1);
            Controls.Add(FirstNameTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GoBackButton);
            Controls.Add(RegistrateAccountButton);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "RegistrationForm";
            Text = "Registration";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button RegistrateAccountButton;
        private Button GoBackButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox PasswordTextBox;
        private TextBox LastNameTextBox;
        private TextBox UsernameTextBox;
        private TextBox FirstNameTextBox;
        private GroupBox groupBox1;
        private RadioButton StudentCheck;
        private RadioButton TeacherCheck;
        private RadioButton AdminCheck;
    }
}