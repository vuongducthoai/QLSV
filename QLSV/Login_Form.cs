﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{
    public partial class Login_Form : Form
    {

        bool flag = true;
        public Login_Form()
        {
            InitializeComponent();
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_Form_KeyPress);

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../images/user.png");
        }

        private void btt_Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command;

            if(radioButtonStudent.Checked == true)
            {
                 flag = true;
                 command = new SqlCommand("SELECT * FROM log_in WHERE UserName = @User AND PassWord = @Pass AND Accept = 1", db.getConnection);

                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;



                adapter.SelectCommand = command;

                adapter.Fill(table);
                if (TextBoxUsername.Text.Trim() != "" || TextBoxPassword.Text.Trim() != "")
                {
                    if (table.Rows.Count > 0)
                    {
                        this.Hide(); // Hide the login form
                        Progress progress = new Progress(flag);
                        progress.FormClosed += (s, args) => this.Close(); // Ensure the login form closes when progress form closes
                        progress.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                flag = false;
                command = new SqlCommand("SELECT * FROM hr WHERE uname = @usn AND pwd = @pass", db.getConnection);
                command.Parameters.Add("@usn", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;



                adapter.SelectCommand = command;

                adapter.Fill(table);
                if (TextBoxUsername.Text.Trim() != "" && TextBoxPassword.Text.Trim() != "")
                {
                    if (table.Rows.Count > 0)
                    {
                        int userid = Convert.ToInt32(table.Rows[0][0].ToString());
                        GlobalIdUser.SetGlobalUserId(userid);
                        this.DialogResult = DialogResult.OK;

                        this.Hide(); // Hide the login form
                        Progress progress = new Progress(flag);
                        progress.FormClosed += (s, args) => this.Close(); // Ensure the login form closes when progress form closes
                        progress.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void linkLabel_NewUser(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(radioButtonStudent.Checked == true)
            {
                Form_NewUser form_NewUser = new Form_NewUser();
                form_NewUser.Show(this);
            } else
            {
                CreateNewAccount createNewAccount = new CreateNewAccount();
                createNewAccount.Show(this);
            }
        }


        private void Login_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btt_Login_Click(sender, e);
                e.Handled = true;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_passWord.Checked == true)
            {
                TextBoxPassword.PasswordChar = '\0';
            }
            else
            {
                TextBoxPassword.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {
            TextBoxUsername.Text = "";
            TextBoxPassword.Text = "";
        }
    }
}
