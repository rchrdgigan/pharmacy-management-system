using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Loginfrm : Form
    {
        UserClass uc = new UserClass();

        public static string _username;
        public static string _role;
        public static string _fname;
        public static string _log_id;

        public Loginfrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void loginFunc()
        {

            if (usernameTxtBox.Text == "" && passwordTxtBox.Text == "")
            {
                usernameTxtBox.BackColor = Color.MistyRose;
                passwordTxtBox.BackColor = Color.MistyRose;
                MessageBox.Show("Please input username and password...", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (usernameTxtBox.Text == "")
                {
                    usernameTxtBox.BackColor = Color.MistyRose;
                    passwordTxtBox.BackColor = DefaultBackColor;
                    MessageBox.Show("Please input username...", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (passwordTxtBox.Text == "")
                {
                    passwordTxtBox.BackColor = Color.MistyRose;
                    usernameTxtBox.BackColor = DefaultBackColor;
                    MessageBox.Show("Please input password...", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    uc.username = usernameTxtBox.Text;
                    uc.password = passwordTxtBox.Text;
                    bool verify = uc.userVerification();
                    if (verify == true)
                    {
                        MessageBox.Show("Successfully Login!", "Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _role = uc.role;
                        _username = uc.username;
                        _fname = uc.fname;
                        _log_id = uc._id;
                        this.Hide();

                        DasboardForm dsboard = new DasboardForm();
                        dsboard.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User does not exist!", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameTxtBox.Clear();
                        passwordTxtBox.Clear();
                        usernameTxtBox.BackColor = DefaultBackColor;
                        passwordTxtBox.BackColor = DefaultBackColor;
                    }
                }

            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            loginFunc();
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginFunc();
            }
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {
            this.passwordTxtBox.KeyPress += new
           System.Windows.Forms.KeyPressEventHandler(CheckEnter);
        }
    }
}
