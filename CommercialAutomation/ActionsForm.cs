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
    public partial class ActionsForm : Form
    {
        public ActionsForm()
        {
            InitializeComponent();
        }
        CommercialAutomationContext context = new CommercialAutomationContext();

        void ListCustomerActions()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Execute CustomerActionsJoin", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        void ListCompanyActions()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Execute CompanyActionsJoin", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl3.DataSource = dataTable;
        }

        private void ActionsForm_Load(object sender, EventArgs e)
        {
            ListCustomerActions();
            ListCompanyActions();        
        }
    }
}
