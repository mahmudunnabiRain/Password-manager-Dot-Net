using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CheckFirstTimeSetup();
        }

        private void CheckFirstTimeSetup()
        {
            //checking if core_password.txt is empty that means this is first time setup
            try
            {
                using (StreamReader sr = new StreamReader("core_password.txt"))
                {
                    string line = sr.ReadLine();
                    if(String.IsNullOrWhiteSpace(line))
                    {
                        signup_panel.Show();
                        login_panel.Hide();
                    }
                    else
                    {
                        signup_panel.Hide();
                        login_panel.Show();
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                signup_panel.Show();
                login_panel.Hide();
            }
        }

        private void Signup_submit_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show(signup_password_input.Text);
                using (StreamWriter sw = new StreamWriter("core_password.txt"))
                {
                    sw.WriteLine(signup_password_input.Text);
                }
                signup_panel.Hide();
            }
        }

        private void Main_password_input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Signup_submit_Click(sender, e);
            }
        }

      

        private void Main_password_input_Validating(object sender, CancelEventArgs e)
        {
            string password = signup_password_input.Text;
            if (String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("you must enter a password");
                e.Cancel = true;
               
            }
        }

        private void CheckBox_signup_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_signup_show_pass.Checked)
            {
                signup_password_input.UseSystemPasswordChar = false;
                signup_password_input.Focus();
            }
            else
            {
                signup_password_input.UseSystemPasswordChar = true;
                signup_password_input.Focus();
            }
        }


        private void CheckBox_show_login_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_login_pass.Checked)
            {
                login_pass_input.UseSystemPasswordChar = false;
                login_pass_input.Focus();
            }
            else
            {
                login_pass_input.UseSystemPasswordChar = true;
                login_pass_input.Focus();
            }
        }

        private void Login_pass_input_TextChanged(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("core_password.txt"))
            {
                string line = sr.ReadLine();
                if (line == login_pass_input.Text)
                {
                    login_panel.Hide();

                }
                
            }
        }
    }
}
