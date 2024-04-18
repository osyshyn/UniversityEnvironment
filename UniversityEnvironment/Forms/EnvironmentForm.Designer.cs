namespace UniversityEnvironment.Forms
{
    partial class EnvironmentForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            CloseButton = new Button();
            PersonRole = new Label();
            PersonName = new Label();
            ActualCoursesTable = new DataGridView();
            ActualGridColumnCourseName = new DataGridViewTextBoxColumn();
            ActualGridColumnCourseFaculty = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            UnsignButton = new Button();
            SignButton = new Button();
            AvailableCoursesTable = new DataGridView();
            RowCheck = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ActualCoursesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(600, 337);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(CloseButton);
            tabPage1.Controls.Add(PersonRole);
            tabPage1.Controls.Add(PersonName);
            tabPage1.Controls.Add(ActualCoursesTable);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(592, 304);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 3);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 5;
            label3.Text = "Your courses";
            // 
            // CloseButton
            // 
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(171, 265);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(415, 35);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "Sign out";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // PersonRole
            // 
            PersonRole.BackColor = SystemColors.Control;
            PersonRole.Location = new Point(8, 272);
            PersonRole.Name = "PersonRole";
            PersonRole.Size = new Size(157, 26);
            PersonRole.TabIndex = 3;
            // 
            // PersonName
            // 
            PersonName.BackColor = SystemColors.Control;
            PersonName.Location = new Point(8, 208);
            PersonName.Name = "PersonName";
            PersonName.Size = new Size(157, 26);
            PersonName.TabIndex = 3;
            // 
            // ActualCoursesTable
            // 
            ActualCoursesTable.AllowUserToAddRows = false;
            ActualCoursesTable.AllowUserToDeleteRows = false;
            ActualCoursesTable.BackgroundColor = SystemColors.Control;
            ActualCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ActualCoursesTable.Columns.AddRange(new DataGridViewColumn[] { ActualGridColumnCourseName, ActualGridColumnCourseFaculty });
            ActualCoursesTable.Location = new Point(171, 26);
            ActualCoursesTable.Name = "ActualCoursesTable";
            ActualCoursesTable.ReadOnly = true;
            ActualCoursesTable.Size = new Size(414, 231);
            ActualCoursesTable.TabIndex = 2;
            ActualCoursesTable.CellContentClick += ActualCoursesTable_CellContentClick;
            // 
            // ActualGridColumnCourseName
            // 
            ActualGridColumnCourseName.HeaderText = "Course";
            ActualGridColumnCourseName.Name = "ActualGridColumnCourseName";
            ActualGridColumnCourseName.ReadOnly = true;
            ActualGridColumnCourseName.Width = 150;
            // 
            // ActualGridColumnCourseFaculty
            // 
            ActualGridColumnCourseFaculty.HeaderText = "Faculty";
            ActualGridColumnCourseFaculty.Name = "ActualGridColumnCourseFaculty";
            ActualGridColumnCourseFaculty.ReadOnly = true;
            ActualGridColumnCourseFaculty.Width = 220;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 246);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 182);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(8, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(UnsignButton);
            tabPage2.Controls.Add(SignButton);
            tabPage2.Controls.Add(AvailableCoursesTable);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(592, 304);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Courses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 5);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 6;
            label4.Text = "Available courses";
            // 
            // UnsignButton
            // 
            UnsignButton.BackColor = SystemColors.ControlLightLight;
            UnsignButton.FlatStyle = FlatStyle.Flat;
            UnsignButton.Location = new Point(8, 190);
            UnsignButton.Name = "UnsignButton";
            UnsignButton.Size = new Size(158, 106);
            UnsignButton.TabIndex = 4;
            UnsignButton.Text = "Unsign from courses";
            UnsignButton.UseVisualStyleBackColor = false;
            UnsignButton.Click += UnsignButton_Click;
            // 
            // SignButton
            // 
            SignButton.BackColor = SystemColors.ControlLightLight;
            SignButton.FlatStyle = FlatStyle.Flat;
            SignButton.Location = new Point(8, 28);
            SignButton.Name = "SignButton";
            SignButton.Size = new Size(158, 156);
            SignButton.TabIndex = 4;
            SignButton.Text = "Sign on courses";
            SignButton.UseVisualStyleBackColor = false;
            SignButton.Click += SignButton_Click;
            // 
            // AvailableCoursesTable
            // 
            AvailableCoursesTable.AllowUserToAddRows = false;
            AvailableCoursesTable.AllowUserToDeleteRows = false;
            AvailableCoursesTable.BackgroundColor = SystemColors.Control;
            AvailableCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AvailableCoursesTable.Columns.AddRange(new DataGridViewColumn[] { RowCheck, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            AvailableCoursesTable.Location = new Point(172, 28);
            AvailableCoursesTable.Name = "AvailableCoursesTable";
            AvailableCoursesTable.Size = new Size(414, 268);
            AvailableCoursesTable.TabIndex = 3;
            // 
            // RowCheck
            // 
            RowCheck.HeaderText = "";
            RowCheck.Name = "RowCheck";
            RowCheck.Resizable = DataGridViewTriState.True;
            RowCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            RowCheck.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Course";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Faculty";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // EnvironmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(tabControl1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "EnvironmentForm";
            Text = "Environment";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ActualCoursesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableCoursesTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Label PersonName;
        private DataGridView ActualCoursesTable;
        private Label label1;
        private Button CloseButton;
        private Label PersonRole;
        private DataGridViewTextBoxColumn ActualGridColumnCourseName;
        private DataGridViewTextBoxColumn ActualGridColumnCourseFaculty;
        private Label label2;
        private Label label3;
        private Button SignButton;
        private DataGridView AvailableCoursesTable;
        private Label label4;
        private Button UnsignButton;
        private DataGridViewCheckBoxColumn RowCheck;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}