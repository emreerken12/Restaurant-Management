using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranYeni
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Giriş formuna geri dönmek istediğinize emin misiniz?"
                , "Evet Hayır?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            if (check == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void cashierOrder1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashBoardForm1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierOrder1.Visible = false;
            cashierCustomerForm1.Visible = false;
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashBoardForm1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierOrder1.Visible = false;
            cashierCustomerForm1.Visible = false;
        }

        private void adminDashBoardForm1_Load(object sender, EventArgs e)
        {

        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            adminDashBoardForm1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierOrder1.Visible = true;
            cashierCustomerForm1.Visible = false;
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            adminDashBoardForm1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierOrder1.Visible = false;
            cashierCustomerForm1.Visible = true;
        }

        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }
    }
}
