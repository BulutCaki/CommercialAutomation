using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CommercialAutomation
{
    public partial class GuideForm : Form
    {
        public GuideForm()
        {
            InitializeComponent();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        CommercialAutomationContext context = new CommercialAutomationContext();
        void ListCustomers()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select FirstName,LastName,PhoneNumber,PhoneNumber2,Email From Customers", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void ListCompany()
        {
            DataTable dataTable2 = new DataTable();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter
                ("Select CompanyName,CommissionerName,PhoneNumber1,PhoneNumber2,PhoneNumber3,Email,Fax From Companies", context.connection());
            sqlDataAdapter2.Fill(dataTable2);
            gridControl3.DataSource = dataTable2;
        }

        private void GuideForm_Load(object sender, EventArgs e)
        {
            ListCustomers();
            ListCompany();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListCustomers();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ListCompany();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MailForm mailForm = new MailForm();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                mailForm.mail = dataRow["Email"].ToString();
            }
            mailForm.Show();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            MailForm mailForm = new MailForm();
            DataRow dataRow = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dataRow != null)
            {
                mailForm.mail = dataRow["Email"].ToString();
            }
            mailForm.Show();
        }
    }
}
