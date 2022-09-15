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
    public partial class DasboardForm : Form
    {
        public DasboardForm()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DasboardForm_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = btnHome.Top;
            panelMark.Height = btnHome.Height;

            ucontroll.UserControlHome b = new ucontroll.UserControlHome();
            panelContent.Controls.Add(b);
            b.BringToFront();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = btnInventory.Top;
            panelMark.Height = btnInventory.Height;

            ucontroll.UCInventory b = new ucontroll.UCInventory();
            panelContent.Controls.Add(b);
            b.BringToFront();
        }

        private void btnDispensing_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = btnDispensing.Top;
            panelMark.Height = btnDispensing.Height;

            ucontroll.UCDispensing b = new ucontroll.UCDispensing();
            panelContent.Controls.Add(b);
            b.BringToFront();
        }

        private void btnReceiving_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = btnReceiving.Top;
            panelMark.Height = btnReceiving.Height;

            ucontroll.UCReceiving b = new ucontroll.UCReceiving();
            panelContent.Controls.Add(b);
            b.BringToFront();
        }
    }
}
