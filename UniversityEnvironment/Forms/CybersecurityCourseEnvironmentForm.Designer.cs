namespace UniversityEnvironment.Forms
{
    partial class CybersecurityCourseEnvironmentForm
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
            Exam1Button = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exam1Button
            // 
            Exam1Button.BackColor = SystemColors.ControlLightLight;
            Exam1Button.FlatStyle = FlatStyle.Flat;
            Exam1Button.Location = new Point(12, 346);
            Exam1Button.Name = "Exam1Button";
            Exam1Button.Size = new Size(377, 42);
            Exam1Button.TabIndex = 2;
            Exam1Button.Text = "Go to Test 1";
            Exam1Button.UseVisualStyleBackColor = false;
            Exam1Button.Click += Exam1Button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cybersecurity;
            pictureBox1.Location = new Point(12, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // CybersecurityCourseEnvironmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(pictureBox1);
            Controls.Add(Exam1Button);
            Name = "CybersecurityCourseEnvironmentForm";
            Text = "";
            Controls.SetChildIndex(Exam1Button, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Exam1Button;
        private PictureBox pictureBox1;
    }
}