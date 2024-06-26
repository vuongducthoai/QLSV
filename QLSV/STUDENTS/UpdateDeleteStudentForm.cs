﻿using QLSV.COURSESOCRE;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        // Initialize student object
        private STUDENT student = new STUDENT();

        // Initialize dataset object
        private LoginFormDbDataSet loginFormDbDataSet = new LoginFormDbDataSet();

        // Declare studentTableAdapter with the correct type
        private LoginFormDbDataSetTableAdapters.studentTableAdapter studentTableAdapter;

        // Declare DataGridView1 as a DataGridView control
        public DataGridView DataGridView1 { get; private set; }

        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
            this.TextBoxId.KeyPress += new KeyPressEventHandler(TextBoxID_KeyPress);
          //  this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBoxId.Text);
                // Sử dụng SqlParameter để tránh SQL Injection
                string query = "SELECT id, fname, lname, bdate, gender, email, phone, address, picture FROM student WHERE id = @id";
                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Thiết lập tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    con.Open();
                    adapter.Fill(table); // Điền dữ liệu vào table

                    if (table.Rows.Count > 0)
                    {
                        TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                        TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                        DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                        textBox_email.Text = table.Rows[0]["email"].ToString();
                        if (table.Rows[0]["gender"].ToString() == "Female")
                        {
                            RadioButtonFemale.Checked = true;
                        }
                        else
                        {
                            RadioButtonMale.Checked = true;
                        }
                        TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                        TextBoxAddress.Text = table.Rows[0]["address"].ToString();
                        if (table.Rows[0]["picture"] != DBNull.Value)
                        {
                            byte[] pic = (byte[])table.Rows[0]["picture"];
                            MemoryStream picture = new MemoryStream(pic);
                            PictureBoxStudentImage.Image = Image.FromStream(picture);
                        }
                        else
                        {
                            PictureBoxStudentImage.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE student SET fname = @fname, lname = @lname, bdate = @bdate, email = @email ,gender = @gender, phone = @phone, address = @address, picture = @picture WHERE id = @id";
                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", int.Parse(TextBoxId.Text));
                    command.Parameters.AddWithValue("@fname", TextBoxFname.Text);
                    command.Parameters.AddWithValue("@lname", TextBoxLname.Text);
                    command.Parameters.AddWithValue("@bdate", DateTimePicker1.Value);
                    command.Parameters.AddWithValue("@email", textBox_email.Text);    
                    command.Parameters.AddWithValue("@gender", RadioButtonFemale.Checked ? "Female" : "Male");
                    command.Parameters.AddWithValue("@phone", TextBoxPhone.Text);
                    command.Parameters.AddWithValue("@address", TextBoxAddress.Text);
                    if (PictureBoxStudentImage.Image != null)
                    {
                        byte[] pictureData = ConvertImageToByteArray(PictureBoxStudentImage.Image);
                        command.Parameters.AddWithValue("@picture", pictureData);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@picture", DBNull.Value);
                    }

                    con.Open();
                    int result = command.ExecuteNonQuery(); // Executes update and returns number of affected rows

                    if (result > 0)
                    {
                        MessageBox.Show("Student updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student not found or update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void ButtonRemoveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBoxId.Text);
                string query = "DELETE FROM student WHERE id = @id";

                using (SqlConnection con = new SqlConnection(@"Data Source=Vuong-Duc-Thoai\SQLEXPRESS;User ID=sa;Password=********;Initial Catalog=LoginFormDb;Integrated Security=True;"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Clear input fields after successful deletion
                        TextBoxId.Text = "";
                        TextBoxFname.Text = "";
                        TextBoxLname.Text = "";
                        DateTimePicker1.Value = DateTime.Now; // You can set it to default value
                        textBox_email.Text = "";
                        RadioButtonFemale.Checked = false; // Uncheck both radio buttons
                        RadioButtonMale.Checked = false;
                        TextBoxPhone.Text = "";
                        TextBoxAddress.Text = "";
                        PictureBoxStudentImage.Image = null;
                        // Optional: Clear form or perform other actions after deletion.
                        MessageBox.Show("Student deleted successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student not found", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception for debugging and security purposes.
            }
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

       

        // Helper method to get the index of the image column
        private int GetImageColumnIndex(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
                    return column.Index;
                }
            }
            return -1; // Return -1 if no image column is found
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AddCourseStudent addCourseFrm = new AddCourseStudent(Convert.ToInt32(TextBoxId.Text));
                addCourseFrm.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddCourse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
