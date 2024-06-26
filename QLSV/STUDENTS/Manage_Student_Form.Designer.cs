﻿namespace QLSV
{
    partial class Manage_Student_Form
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
            this.components = new System.ComponentModel.Container();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.Label7 = new System.Windows.Forms.Label();
            this.ButtonAddStudent = new System.Windows.Forms.Button();
            this.ButtonEditStudent = new System.Windows.Forms.Button();
            this.ButtonUploadImage = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.buttonDownloadImage = new System.Windows.Forms.Button();
            this.ButtonRemoveStudent = new System.Windows.Forms.Button();
            this.ButtonResetStudent = new System.Windows.Forms.Button();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.loginFormDbDataSet2 = new QLSV.LoginFormDbDataSet2();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new QLSV.LoginFormDbDataSet2TableAdapters.studentTableAdapter();
            this.dataGridView_Search = new System.Windows.Forms.DataGridView();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginFormDbDataSet3 = new QLSV.LoginFormDbDataSet3();
            this.LabelStudentTotal = new System.Windows.Forms.Label();
            this.studentTableAdapter1 = new QLSV.LoginFormDbDataSet3TableAdapters.studentTableAdapter();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.Button_AddCourse = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButtonFemale);
            this.GroupBox1.Controls.Add(this.RadioButtonMale);
            this.GroupBox1.Location = new System.Drawing.Point(152, 234);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(305, 53);
            this.GroupBox1.TabIndex = 33;
            this.GroupBox1.TabStop = false;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.ForeColor = System.Drawing.Color.White;
            this.RadioButtonFemale.Location = new System.Drawing.Point(149, 16);
            this.RadioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(104, 29);
            this.RadioButtonFemale.TabIndex = 1;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.ForeColor = System.Drawing.Color.White;
            this.RadioButtonMale.Location = new System.Drawing.Point(13, 17);
            this.RadioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(80, 29);
            this.RadioButtonMale.TabIndex = 0;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(28, 250);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(90, 25);
            this.Label7.TabIndex = 32;
            this.Label7.Text = "Gender:";
            // 
            // ButtonAddStudent
            // 
            this.ButtonAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.ButtonAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddStudent.ForeColor = System.Drawing.Color.White;
            this.ButtonAddStudent.Location = new System.Drawing.Point(24, 721);
            this.ButtonAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddStudent.Name = "ButtonAddStudent";
            this.ButtonAddStudent.Size = new System.Drawing.Size(132, 49);
            this.ButtonAddStudent.TabIndex = 31;
            this.ButtonAddStudent.Text = "Add";
            this.ButtonAddStudent.UseVisualStyleBackColor = false;
            this.ButtonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // ButtonEditStudent
            // 
            this.ButtonEditStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.ButtonEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditStudent.ForeColor = System.Drawing.Color.White;
            this.ButtonEditStudent.Location = new System.Drawing.Point(199, 721);
            this.ButtonEditStudent.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEditStudent.Name = "ButtonEditStudent";
            this.ButtonEditStudent.Size = new System.Drawing.Size(141, 49);
            this.ButtonEditStudent.TabIndex = 30;
            this.ButtonEditStudent.Text = "Edit";
            this.ButtonEditStudent.UseVisualStyleBackColor = false;
            this.ButtonEditStudent.Click += new System.EventHandler(this.ButtonEditStudent_Click);
            // 
            // ButtonUploadImage
            // 
            this.ButtonUploadImage.Location = new System.Drawing.Point(140, 606);
            this.ButtonUploadImage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUploadImage.Name = "ButtonUploadImage";
            this.ButtonUploadImage.Size = new System.Drawing.Size(161, 28);
            this.ButtonUploadImage.TabIndex = 29;
            this.ButtonUploadImage.Text = "Upload";
            this.ButtonUploadImage.UseVisualStyleBackColor = true;
            this.ButtonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(32, 428);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 25);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "Picture:";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.Location = new System.Drawing.Point(152, 360);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(304, 60);
            this.TextBoxAddress.TabIndex = 26;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(22, 360);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(99, 25);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Address:";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhone.Location = new System.Drawing.Point(156, 306);
            this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(304, 30);
            this.TextBoxPhone.TabIndex = 24;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(27, 292);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(81, 25);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Phone:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(152, 170);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(304, 22);
            this.DateTimePicker1.TabIndex = 22;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(13, 168);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(108, 25);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "BirthDate:";
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLname.Location = new System.Drawing.Point(152, 116);
            this.TextBoxLname.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(301, 30);
            this.TextBoxLname.TabIndex = 20;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(12, 119);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(122, 25);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Last Name:";
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFname.Location = new System.Drawing.Point(152, 64);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(301, 30);
            this.TextBoxFname.TabIndex = 18;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(13, 68);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(123, 25);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(14, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(157, 25);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(152, 22);
            this.txtStudentID.TabIndex = 35;
            // 
            // buttonDownloadImage
            // 
            this.buttonDownloadImage.Location = new System.Drawing.Point(308, 606);
            this.buttonDownloadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownloadImage.Name = "buttonDownloadImage";
            this.buttonDownloadImage.Size = new System.Drawing.Size(158, 25);
            this.buttonDownloadImage.TabIndex = 36;
            this.buttonDownloadImage.Text = "Download";
            this.buttonDownloadImage.UseVisualStyleBackColor = true;
            this.buttonDownloadImage.Click += new System.EventHandler(this.buttonDownloadImage_Click);
            // 
            // ButtonRemoveStudent
            // 
            this.ButtonRemoveStudent.BackColor = System.Drawing.Color.DeepPink;
            this.ButtonRemoveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveStudent.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveStudent.Location = new System.Drawing.Point(371, 721);
            this.ButtonRemoveStudent.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRemoveStudent.Name = "ButtonRemoveStudent";
            this.ButtonRemoveStudent.Size = new System.Drawing.Size(125, 49);
            this.ButtonRemoveStudent.TabIndex = 38;
            this.ButtonRemoveStudent.Text = "Remove";
            this.ButtonRemoveStudent.UseVisualStyleBackColor = false;
            this.ButtonRemoveStudent.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // ButtonResetStudent
            // 
            this.ButtonResetStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonResetStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonResetStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResetStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResetStudent.ForeColor = System.Drawing.Color.White;
            this.ButtonResetStudent.Location = new System.Drawing.Point(542, 721);
            this.ButtonResetStudent.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonResetStudent.Name = "ButtonResetStudent";
            this.ButtonResetStudent.Size = new System.Drawing.Size(159, 49);
            this.ButtonResetStudent.TabIndex = 39;
            this.ButtonResetStudent.Text = "Reset";
            this.ButtonResetStudent.UseVisualStyleBackColor = false;
            this.ButtonResetStudent.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(152, 428);
            this.PictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(316, 175);
            this.PictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxStudentImage.TabIndex = 28;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(367, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(361, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Search StudentId,Fname, Lname, Address";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(792, 23);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(345, 30);
            this.textBox_Search.TabIndex = 41;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.Chartreuse;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Search.Location = new System.Drawing.Point(1163, 18);
            this.button_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(139, 39);
            this.button_Search.TabIndex = 42;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // loginFormDbDataSet2
            // 
            this.loginFormDbDataSet2.DataSetName = "LoginFormDbDataSet2";
            this.loginFormDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.loginFormDbDataSet2;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_Search
            // 
            this.dataGridView_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Search.Location = new System.Drawing.Point(491, 61);
            this.dataGridView_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Search.Name = "dataGridView_Search";
            this.dataGridView_Search.RowHeadersWidth = 51;
            this.dataGridView_Search.RowTemplate.Height = 50;
            this.dataGridView_Search.Size = new System.Drawing.Size(811, 609);
            this.dataGridView_Search.TabIndex = 43;
            this.dataGridView_Search.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Search_CellDoubleClick);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.loginFormDbDataSet3;
            // 
            // loginFormDbDataSet3
            // 
            this.loginFormDbDataSet3.DataSetName = "LoginFormDbDataSet3";
            this.loginFormDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LabelStudentTotal
            // 
            this.LabelStudentTotal.AutoSize = true;
            this.LabelStudentTotal.BackColor = System.Drawing.Color.Moccasin;
            this.LabelStudentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelStudentTotal.Location = new System.Drawing.Point(1112, 684);
            this.LabelStudentTotal.Name = "LabelStudentTotal";
            this.LabelStudentTotal.Size = new System.Drawing.Size(190, 29);
            this.LabelStudentTotal.TabIndex = 44;
            this.LabelStudentTotal.Text = "TotalStudent:   ";
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Email.Location = new System.Drawing.Point(43, 207);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(72, 25);
            this.label_Email.TabIndex = 45;
            this.label_Email.Text = "Email:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(157, 202);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(296, 30);
            this.textBox_Email.TabIndex = 46;
            // 
            // Button_AddCourse
            // 
            this.Button_AddCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_AddCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_AddCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_AddCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_AddCourse.FillColor = System.Drawing.Color.Lime;
            this.Button_AddCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddCourse.ForeColor = System.Drawing.Color.Black;
            this.Button_AddCourse.Location = new System.Drawing.Point(1117, 746);
            this.Button_AddCourse.Name = "Button_AddCourse";
            this.Button_AddCourse.Size = new System.Drawing.Size(180, 45);
            this.Button_AddCourse.TabIndex = 47;
            this.Button_AddCourse.Text = "Add Course";
            this.Button_AddCourse.Click += new System.EventHandler(this.Button_AddCourse_Click);
            // 
            // Manage_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1329, 816);
            this.Controls.Add(this.Button_AddCourse);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.LabelStudentTotal);
            this.Controls.Add(this.dataGridView_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ButtonResetStudent);
            this.Controls.Add(this.ButtonRemoveStudent);
            this.Controls.Add(this.buttonDownloadImage);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.ButtonAddStudent);
            this.Controls.Add(this.ButtonEditStudent);
            this.Controls.Add(this.ButtonUploadImage);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manage_Student_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.Load += new System.EventHandler(this.Manage_Student_Form_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormDbDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RadioButtonFemale;
        internal System.Windows.Forms.RadioButton RadioButtonMale;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button ButtonAddStudent;
        internal System.Windows.Forms.Button ButtonEditStudent;
        internal System.Windows.Forms.Button ButtonUploadImage;
        internal System.Windows.Forms.PictureBox PictureBoxStudentImage;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBoxAddress;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBoxPhone;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBoxLname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxFname;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button buttonDownloadImage;
        internal System.Windows.Forms.Button ButtonRemoveStudent;
        internal System.Windows.Forms.Button ButtonResetStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private LoginFormDbDataSet2 loginFormDbDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private LoginFormDbDataSet2TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_Search;
        private System.Windows.Forms.Label LabelStudentTotal;
        private LoginFormDbDataSet3 loginFormDbDataSet3;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private LoginFormDbDataSet3TableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Email;
        private Guna.UI2.WinForms.Guna2Button Button_AddCourse;
    }
}
