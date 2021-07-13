using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = null;

            dr = dt.NewRow();

            dr["ชื่อ"] = txtname.Text;
            dr["นามสกุล"] = txtsurname.Text;
            dr["ที่อยู่"] = txtAddress.Text;
            dr["เบอร์โทร"] = txtTel.Text;
            dr["อีเมลล์"] = txtMail.Text;

            dt.Rows.Add(dr);

            dgvData.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Text = null;
            txtsurname.Text = null;
            txtAddress.Text = null;
            txtTel.Text = null;
            txtMail.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(new DataColumn("ชื่อ", typeof(string)));
            dt.Columns.Add(new DataColumn("นามสกุล", typeof(string)));
            dt.Columns.Add(new DataColumn("ที่อยู่", typeof(string)));
            dt.Columns.Add(new DataColumn("เบอร์โทร", typeof(string)));
            dt.Columns.Add(new DataColumn("อีเมลล์", typeof(string)));
        }
    }
}
