using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }



        private void Main_password_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_submit_Click(object sender, EventArgs e)
        {    
            if(this.ValidateChildren())
            {
                MessageBox.Show(main_password_input.Text);
            }         
        }

        private void Main_password_input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login_submit_Click(sender, e);
            }
        }

        private void Main_password_input_Validating(object sender, CancelEventArgs e)
        {
            string password = main_password_input.Text;
            if (String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("you must enter a password");
                e.Cancel = true;
               
            }
        }
    }
}
