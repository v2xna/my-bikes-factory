using MyBikesFactory.Business; // Don't Forget
using MyBikesFactory.Data; // Don't Forget
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactory.UI
{
    public partial class LoginForm : Form
    {
        // Soon as it runs, checks login
        private List<User> listOfUsers = UserSequentialData.Load(); // Step 1

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) // Step 2
        {
            bool existingUser = false;

            foreach (var user in listOfUsers)
            {
                if (user.Username == txtUsername.Text && user.Password == txtPassword.Text)
                {
                    existingUser = true;
                    break;
                }
            }

            // Make sure to create in .UI -> bin -> Debug -> net -> Create login.txt THEN ADD USER IN TEXT FILE
            if (existingUser)
            {
                var frmMainForm = new MainForm();
                frmMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
