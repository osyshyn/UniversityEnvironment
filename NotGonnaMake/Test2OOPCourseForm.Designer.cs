namespace UniversityEnvironment.View.Forms
{
    partial class Test2OOPCourseForm
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
            Question3Table = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Question2Table = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Question1Table = new DataGridView();
            StudentName = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Q3Box = new GroupBox();
            Q3Answer3 = new RadioButton();
            Q3Answer2 = new RadioButton();
            Q3Answer1 = new RadioButton();
            Q2Box = new GroupBox();
            Q2Answer3 = new RadioButton();
            Q2Answer2 = new RadioButton();
            Q2Answer1 = new RadioButton();
            Q1Box = new GroupBox();
            Q1Answer3 = new RadioButton();
            Q1Answer2 = new RadioButton();
            Q1Answer1 = new RadioButton();
            label1 = new Label();
            SendButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Question3Table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Question2Table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Question1Table).BeginInit();
            Q3Box.SuspendLayout();
            Q2Box.SuspendLayout();
            Q1Box.SuspendLayout();
            SuspendLayout();
            // 
            // Question3Table
            // 
            Question3Table.AllowUserToAddRows = false;
            Question3Table.AllowUserToDeleteRows = false;
            Question3Table.BackgroundColor = SystemColors.Control;
            Question3Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Question3Table.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            Question3Table.Location = new Point(632, 432);
            Question3Table.Name = "Question3Table";
            Question3Table.ReadOnly = true;
            Question3Table.Size = new Size(256, 119);
            Question3Table.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Student";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Question2Table
            // 
            Question2Table.AllowUserToAddRows = false;
            Question2Table.AllowUserToDeleteRows = false;
            Question2Table.BackgroundColor = SystemColors.Control;
            Question2Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Question2Table.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            Question2Table.Location = new Point(632, 294);
            Question2Table.Name = "Question2Table";
            Question2Table.ReadOnly = true;
            Question2Table.Size = new Size(256, 119);
            Question2Table.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Student";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Question1Table
            // 
            Question1Table.AllowUserToAddRows = false;
            Question1Table.AllowUserToDeleteRows = false;
            Question1Table.BackgroundColor = SystemColors.Control;
            Question1Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Question1Table.Columns.AddRange(new DataGridViewColumn[] { StudentName });
            Question1Table.Location = new Point(632, 158);
            Question1Table.Name = "Question1Table";
            Question1Table.ReadOnly = true;
            Question1Table.Size = new Size(256, 119);
            Question1Table.TabIndex = 8;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(145, 426);
            label4.Name = "label4";
            label4.Size = new Size(203, 20);
            label4.TabIndex = 15;
            label4.Text = "What about encapsulation?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Location = new Point(144, 278);
            label3.Name = "label3";
            label3.Size = new Size(204, 20);
            label3.TabIndex = 16;
            label3.Text = "What mean polymorphism?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(156, 142);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 17;
            label2.Text = "What mean inheritance?";
            // 
            // Q3Box
            // 
            Q3Box.BackColor = SystemColors.ControlLightLight;
            Q3Box.Controls.Add(Q3Answer3);
            Q3Box.Controls.Add(Q3Answer2);
            Q3Box.Controls.Add(Q3Answer1);
            Q3Box.Location = new Point(70, 449);
            Q3Box.Name = "Q3Box";
            Q3Box.Size = new Size(363, 99);
            Q3Box.TabIndex = 12;
            Q3Box.TabStop = false;
            // 
            // Q3Answer3
            // 
            Q3Answer3.AutoSize = true;
            Q3Answer3.Location = new Point(6, 72);
            Q3Answer3.Name = "Q3Answer3";
            Q3Answer3.Size = new Size(188, 24);
            Q3Answer3.TabIndex = 0;
            Q3Answer3.TabStop = true;
            Q3Answer3.Text = "Flexibility, overloading.";
            Q3Answer3.UseVisualStyleBackColor = true;
            Q3Answer3.CheckedChanged += new System.EventHandler(this.Q3Box_CheckedChanged);
            // 
            // Q3Answer2
            // 
            Q3Answer2.AutoSize = true;
            Q3Answer2.Location = new Point(6, 42);
            Q3Answer2.Name = "Q3Answer2";
            Q3Answer2.Size = new Size(181, 24);
            Q3Answer2.TabIndex = 0;
            Q3Answer2.TabStop = true;
            Q3Answer2.Text = "Code reuse, hierarchy.";
            Q3Answer2.UseVisualStyleBackColor = true;
            Q3Answer2.CheckedChanged += new System.EventHandler(this.Q3Box_CheckedChanged);
            // 
            // Q3Answer1
            // 
            Q3Answer1.AutoSize = true;
            Q3Answer1.Location = new Point(6, 12);
            Q3Answer1.Name = "Q3Answer1";
            Q3Answer1.Size = new Size(199, 24);
            Q3Answer1.TabIndex = 0;
            Q3Answer1.TabStop = true;
            Q3Answer1.Text = "Data hiding, abstraction.";
            Q3Answer1.UseVisualStyleBackColor = true;
            Q3Answer1.CheckedChanged += new System.EventHandler(this.Q3Box_CheckedChanged);
            // 
            // Q2Box
            // 
            Q2Box.BackColor = SystemColors.ControlLightLight;
            Q2Box.Controls.Add(Q2Answer3);
            Q2Box.Controls.Add(Q2Answer2);
            Q2Box.Controls.Add(Q2Answer1);
            Q2Box.Location = new Point(70, 301);
            Q2Box.Name = "Q2Box";
            Q2Box.Size = new Size(363, 99);
            Q2Box.TabIndex = 13;
            Q2Box.TabStop = false;
            // 
            // Q2Answer3
            // 
            Q2Answer3.AutoSize = true;
            Q2Answer3.Location = new Point(6, 72);
            Q2Answer3.Name = "Q2Answer3";
            Q2Answer3.Size = new Size(188, 24);
            Q2Answer3.TabIndex = 0;
            Q2Answer3.TabStop = true;
            Q2Answer3.Text = "Flexibility, overloading.";
            Q2Answer3.UseVisualStyleBackColor = true;
            Q2Answer3.CheckedChanged += new System.EventHandler(this.Q2Box_CheckedChanged);

            // 
            // Q2Answer2
            // 
            Q2Answer2.AutoSize = true;
            Q2Answer2.Location = new Point(6, 42);
            Q2Answer2.Name = "Q2Answer2";
            Q2Answer2.Size = new Size(181, 24);
            Q2Answer2.TabIndex = 0;
            Q2Answer2.TabStop = true;
            Q2Answer2.Text = "Code reuse, hierarchy.";
            Q2Answer2.UseVisualStyleBackColor = true;
            Q2Answer2.CheckedChanged += new System.EventHandler(this.Q2Box_CheckedChanged);

            // 
            // Q2Answer1
            // 
            Q2Answer1.AutoSize = true;
            Q2Answer1.Location = new Point(6, 12);
            Q2Answer1.Name = "Q2Answer1";
            Q2Answer1.Size = new Size(199, 24);
            Q2Answer1.TabIndex = 0;
            Q2Answer1.TabStop = true;
            Q2Answer1.Text = "Data hiding, abstraction.";
            Q2Answer1.UseVisualStyleBackColor = true;
            Q2Answer1.CheckedChanged += new System.EventHandler(this.Q2Box_CheckedChanged);

            // 
            // Q1Box
            // 
            Q1Box.BackColor = SystemColors.ControlLightLight;
            Q1Box.Controls.Add(Q1Answer3);
            Q1Box.Controls.Add(Q1Answer2);
            Q1Box.Controls.Add(Q1Answer1);
            Q1Box.Location = new Point(70, 165);
            Q1Box.Name = "Q1Box";
            Q1Box.Size = new Size(363, 99);
            Q1Box.TabIndex = 14;
            Q1Box.TabStop = false;
            // 
            // Q1Answer3
            // 
            Q1Answer3.AutoSize = true;
            Q1Answer3.Location = new Point(6, 72);
            Q1Answer3.Name = "Q1Answer3";
            Q1Answer3.Size = new Size(188, 24);
            Q1Answer3.TabIndex = 0;
            Q1Answer3.TabStop = true;
            Q1Answer3.Text = "Flexibility, overloading.";
            Q1Answer3.UseVisualStyleBackColor = true;
            Q1Answer3.CheckedChanged += new System.EventHandler(this.Q1Box_CheckedChanged);

            // 
            // Q1Answer2
            // 
            Q1Answer2.AutoSize = true;
            Q1Answer2.Location = new Point(6, 42);
            Q1Answer2.Name = "Q1Answer2";
            Q1Answer2.Size = new Size(181, 24);
            Q1Answer2.TabIndex = 0;
            Q1Answer2.TabStop = true;
            Q1Answer2.Text = "Code reuse, hierarchy.";
            Q1Answer2.UseVisualStyleBackColor = true;
            Q1Answer2.CheckedChanged += new System.EventHandler(this.Q1Box_CheckedChanged);

            // 
            // Q1Answer1
            // 
            Q1Answer1.AutoSize = true;
            Q1Answer1.Location = new Point(6, 12);
            Q1Answer1.Name = "Q1Answer1";
            Q1Answer1.Size = new Size(199, 24);
            Q1Answer1.TabIndex = 0;
            Q1Answer1.TabStop = true;
            Q1Answer1.Text = "Data hiding, abstraction.";
            Q1Answer1.UseVisualStyleBackColor = true;
            Q1Answer1.CheckedChanged += new System.EventHandler(this.Q1Box_CheckedChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Roboto", 18F);
            label1.Location = new Point(214, 94);
            label1.Name = "label1";
            label1.Size = new Size(73, 29);
            label1.TabIndex = 11;
            label1.Text = "Test2";
            // 
            // SendButton
            // 
            SendButton.BackColor = SystemColors.ControlLightLight;
            SendButton.FlatStyle = FlatStyle.Flat;
            SendButton.Location = new Point(12, 560);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(476, 72);
            SendButton.TabIndex = 18;
            SendButton.Text = "Send Answers";
            SendButton.UseVisualStyleBackColor = false;
            SendButton.Click += SendButton_Click;
            // 
            // Test2OOPCourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(SendButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Q3Box);
            Controls.Add(Q2Box);
            Controls.Add(Q1Box);
            Controls.Add(label1);
            Controls.Add(Question3Table);
            Controls.Add(Question2Table);
            Controls.Add(Question1Table);
            Name = "Test2OOPCourseForm";
            Text = "Test2OOPCourseForm";
            Controls.SetChildIndex(Question1Table, 0);
            Controls.SetChildIndex(Question2Table, 0);
            Controls.SetChildIndex(Question3Table, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(Q1Box, 0);
            Controls.SetChildIndex(Q2Box, 0);
            Controls.SetChildIndex(Q3Box, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(SendButton, 0);
            ((System.ComponentModel.ISupportInitialize)Question3Table).EndInit();
            ((System.ComponentModel.ISupportInitialize)Question2Table).EndInit();
            ((System.ComponentModel.ISupportInitialize)Question1Table).EndInit();
            Q3Box.ResumeLayout(false);
            Q3Box.PerformLayout();
            Q2Box.ResumeLayout(false);
            Q2Box.PerformLayout();
            Q1Box.ResumeLayout(false);
            Q1Box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Question3Table;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView Question2Table;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView Question1Table;
        private DataGridViewTextBoxColumn StudentName;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox Q3Box;
        private RadioButton Q3Answer3;
        private RadioButton Q3Answer2;
        private RadioButton Q3Answer1;
        private GroupBox Q2Box;
        private RadioButton Q2Answer3;
        private RadioButton Q2Answer2;
        private RadioButton Q2Answer1;
        private GroupBox Q1Box;
        private RadioButton Q1Answer3;
        private RadioButton Q1Answer2;
        private RadioButton Q1Answer1;
        private Label label1;
        private Button SendButton;
    }
}