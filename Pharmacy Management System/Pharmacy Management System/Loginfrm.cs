using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
                error_lbl.Visible = false;
                usernameTxtBox.BackColor = Color.MistyRose;
                passwordTxtBox.BackColor = Color.MistyRose;
                MessageBox.Show("Please input username and password...", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (usernameTxtBox.Text == "")
                {
                    error_lbl.Visible = false;
                    usernameTxtBox.BackColor = Color.MistyRose;
                    passwordTxtBox.BackColor = DefaultBackColor;
                    MessageBox.Show("Please input username...", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (passwordTxtBox.Text == "")
                {
                    error_lbl.Visible = false;
                    passwordTxtBox.BackColor = Color.MistyRose;
                    usernameTxtBox.BackColor = DefaultBackColor;
                    MessageBox.Show("Please input password...", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var isHasSymbols = new Regex(@"^[a-zA-Z0-9/_]+$");
                    if (!isHasSymbols.IsMatch(usernameTxtBox.Text))
                    {
                        MessageBox.Show("Username allowed underscore symbol only!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (usernameTxtBox.Text.Length < 6)
                    {
                        MessageBox.Show("Username must be 6 characters and above!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!isHasSymbols.IsMatch(passwordTxtBox.Text))
                        {
                            MessageBox.Show("Password allowed underscore symbol only!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (passwordTxtBox.Text.Length < 7)
                        {
                            MessageBox.Show("Password must be 7 to 16 length!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            uc.username = usernameTxtBox.Text;
                            uc.password = passwordTxtBox.Text;
                            bool verify = uc.userVerification();
                            if (verify == true)
                            {
                                error_lbl.Visible = false;
                                _role = uc.role;
                                _username = uc.username;
                                _fname = uc.fname;
                                _log_id = uc._id;
                                progressBar1.Visible = true;
                                timer1.Enabled = true;
                            }
                            else
                            {
                                error_lbl.Visible = true;
                                usernameTxtBox.Clear();
                                passwordTxtBox.Clear();
                                usernameTxtBox.BackColor = DefaultBackColor;
                                passwordTxtBox.BackColor = DefaultBackColor;
                            }

                        }
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
            TransitionAPI.AnimateWindow(this.Handle, 300, TransitionAPI.fadeIN);
            this.passwordTxtBox.KeyPress += new
           System.Windows.Forms.KeyPressEventHandler(CheckEnter);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 3;
            if(progressBar1.Value > 98)
            {
                timer1.Enabled = false;
                this.Hide();
                DasboardForm dsboard = new DasboardForm();
                dsboard.ShowDialog();
            }
        }
    }
}
