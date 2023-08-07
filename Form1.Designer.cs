namespace DemoWinformDAO
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
            dgvEmployee = new DataGridView();
            groupBox1 = new GroupBox();
            btDelete = new Button();
            btUpdate = new Button();
            btAdd = new Button();
            dtpBirthDate = new DateTimePicker();
            cbTitleOfCourtesy = new ComboBox();
            tbTitle = new TextBox();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbEmployeeId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(14, 16);
            dgvEmployee.Margin = new Padding(3, 4, 3, 4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 25;
            dgvEmployee.Size = new Size(712, 529);
            dgvEmployee.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btDelete);
            groupBox1.Controls.Add(btUpdate);
            groupBox1.Controls.Add(btAdd);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(cbTitleOfCourtesy);
            groupBox1.Controls.Add(tbTitle);
            groupBox1.Controls.Add(tbFirstName);
            groupBox1.Controls.Add(tbLastName);
            groupBox1.Controls.Add(tbEmployeeId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(774, 35);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(473, 511);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee's Details ";
            // 
            // btDelete
            // 
            btDelete.Location = new Point(295, 433);
            btDelete.Margin = new Padding(3, 4, 3, 4);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(88, 43);
            btDelete.TabIndex = 14;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(176, 429);
            btUpdate.Margin = new Padding(3, 4, 3, 4);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(90, 45);
            btUpdate.TabIndex = 13;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(40, 429);
            btAdd.Margin = new Padding(3, 4, 3, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 47);
            btAdd.TabIndex = 12;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(150, 384);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(233, 27);
            dtpBirthDate.TabIndex = 11;
            // 
            // cbTitleOfCourtesy
            // 
            cbTitleOfCourtesy.FormattingEnabled = true;
            cbTitleOfCourtesy.Items.AddRange(new object[] { "Ms.", "Mr.", "Dr.", "Mrs." });
            cbTitleOfCourtesy.Location = new Point(150, 324);
            cbTitleOfCourtesy.Margin = new Padding(3, 4, 3, 4);
            cbTitleOfCourtesy.Name = "cbTitleOfCourtesy";
            cbTitleOfCourtesy.Size = new Size(215, 28);
            cbTitleOfCourtesy.TabIndex = 10;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(150, 251);
            tbTitle.Margin = new Padding(3, 4, 3, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(215, 27);
            tbTitle.TabIndex = 9;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(153, 185);
            tbFirstName.Margin = new Padding(3, 4, 3, 4);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(215, 27);
            tbFirstName.TabIndex = 8;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(153, 113);
            tbLastName.Margin = new Padding(3, 4, 3, 4);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(215, 27);
            tbLastName.TabIndex = 7;
            // 
            // tbEmployeeId
            // 
            tbEmployeeId.Location = new Point(153, 39);
            tbEmployeeId.Margin = new Padding(3, 4, 3, 4);
            tbEmployeeId.Name = "tbEmployeeId";
            tbEmployeeId.Size = new Size(215, 27);
            tbEmployeeId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 395);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "BirthDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 335);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 4;
            label5.Text = "TitleOfCourtesy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 261);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 3;
            label4.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 196);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 124);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "EmployeeId:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 587);
            Controls.Add(groupBox1);
            Controls.Add(dgvEmployee);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "List Employee";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployee;
        private GroupBox groupBox1;
        private Button btDelete;
        private Button btUpdate;
        private Button btAdd;
        private DateTimePicker dtpBirthDate;
        private ComboBox cbTitleOfCourtesy;
        private TextBox tbTitle;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbEmployeeId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}