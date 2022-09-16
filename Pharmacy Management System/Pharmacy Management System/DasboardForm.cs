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

        private void btnMedCategory_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = btnMedCategory.Top;
            panelMark.Height = btnMedCategory.Height;

            ucontroll.UCCategory b = new ucontroll.UCCategory();
            panelContent.Controls.Add(b);
            b.BringToFront();
        }

        private void btnMedType_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = btnMedType.Top;
            panelMark.Height = btnMedType.Height;

            ucontroll.UCType b = new ucontroll.UCType();
            panelContent.Controls.Add(b);
            b.BringToFront();
        }

        private void btnMedList_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = btnMedList.Top;
            panelMark.Height = btnMedList.Height;

            ucontroll.UCMedicine b = new ucontroll.UCMedicine();
            panelContent.Controls.Add(b);
            b.BringToFront();
        }

        private void btnSupplierList_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = btnSupplierList.Top;
            panelMark.Height = btnSupplierList.Height;

            ucontroll.UCSupplier b = new ucontroll.UCSupplier();
            panelContent.Controls.Add(b);
            b.BringToFront();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = btnCustomerList.Top;
            panelMark.Height = btnCustomerList.Height;

            ucontroll.UCCustomer b = new ucontroll.UCCustomer();
            panelContent.Controls.Add(b);
            b.BringToFront();
        }
    }
}
