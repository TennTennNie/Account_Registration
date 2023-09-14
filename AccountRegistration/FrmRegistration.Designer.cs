namespace AccountRegistration
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            StudNo = new TextBox();
            LastName = new TextBox();
            FirstName = new TextBox();
            MiddleName = new TextBox();
            Age = new TextBox();
            ContactNo = new TextBox();
            Add = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Student No:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(256, 26);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(202, 105);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(381, 105);
            label5.Name = "label5";
            label5.Size = new Size(141, 23);
            label5.TabIndex = 4;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 192);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(288, 192);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 6;
            label7.Text = "Contact No:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 275);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 7;
            label8.Text = "Address:";
            // 
            // StudNo
            // 
            StudNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudNo.Location = new Point(16, 60);
            StudNo.Name = "StudNo";
            StudNo.Size = new Size(205, 29);
            StudNo.TabIndex = 8;
            // 
            // LastName
            // 
            LastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastName.Location = new Point(16, 131);
            LastName.Name = "LastName";
            LastName.Size = new Size(180, 29);
            LastName.TabIndex = 9;
            // 
            // FirstName
            // 
            FirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstName.Location = new Point(202, 131);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(173, 29);
            FirstName.TabIndex = 10;
            // 
            // MiddleName
            // 
            MiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleName.Location = new Point(381, 131);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(176, 29);
            MiddleName.TabIndex = 11;
            MiddleName.TextChanged += textBox4_TextChanged;
            // 
            // Age
            // 
            Age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Age.Location = new Point(16, 232);
            Age.Name = "Age";
            Age.Size = new Size(249, 29);
            Age.TabIndex = 12;
            // 
            // ContactNo
            // 
            ContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactNo.Location = new Point(288, 232);
            ContactNo.Name = "ContactNo";
            ContactNo.Size = new Size(269, 29);
            ContactNo.TabIndex = 13;
            ContactNo.TextChanged += ContactNo_TextChanged;
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(16, 301);
            Add.Multiline = true;
            Add.Name = "Add";
            Add.Size = new Size(541, 92);
            Add.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BS in Computer Science (BSCS)", "BS in Information Technology (BSIT)", "BS in Computer Engineering (BSCpE)", "BS in Business Administration (BSBA)", "BS in Accounting Information System (BSAIS)", "BS in Accountancy (BSA)", "BS in Hospitality Management (BSHM)", "BS in Psychology", "Bachelor of Multimedia Arts (BMMA)", "Bachelor in Secondary Education Major in Mathematics (BSED)" });
            comboBox1.Location = new Point(256, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(301, 29);
            comboBox1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(244, 399);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 434);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(Add);
            Controls.Add(ContactNo);
            Controls.Add(Age);
            Controls.Add(MiddleName);
            Controls.Add(FirstName);
            Controls.Add(LastName);
            Controls.Add(StudNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "Form1";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox StudNo;
        private TextBox LastName;
        private TextBox FirstName;
        private TextBox MiddleName;
        private TextBox Age;
        private TextBox ContactNo;
        private TextBox Add;
        private ComboBox comboBox1;
        private Button button1;
    }
}