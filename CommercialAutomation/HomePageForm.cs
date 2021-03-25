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
using System.Xml;

namespace CommercialAutomation
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }
        CommercialAutomationContext context = new CommercialAutomationContext();
        
        void ListDecraisingStock()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select ProductName, SUM(Piece) from Products group by ProductName having SUM(Piece)<=20 order by SUM(Piece)", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void ListCustomerLastTenActions()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Execute CustomerActionsOrder", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl2.DataSource = dataTable;
        }
        void ListCompanyLastTenActions()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Execute CompanyActionsOrder", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl5.DataSource = dataTable;
        }

        void ListAgenda()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select NoteDate,NoteHour,NoteTitle,NoteOwner,NoteCollocutor from Notes", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl3.DataSource = dataTable;
        }

        void ListCompanyGuide()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select CompanyName,PhoneNumber1,PhoneNumber3,Email from Companies", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl4.DataSource = dataTable;
        }

        void News()
        {
            XmlTextReader xmlTextReader = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlTextReader.Read())
            {
                if (xmlTextReader.Name == "title")
                {
                    listBox1.Items.Add(xmlTextReader.ReadString());
                }
            }
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            ListDecraisingStock();
            ListCustomerLastTenActions();
            ListCompanyLastTenActions();
            ListAgenda();
            ListCompanyGuide();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            News();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListDecraisingStock();
            ListCustomerLastTenActions();
            ListCompanyLastTenActions();
            ListAgenda();
            ListCompanyGuide();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            News();
        }
    }
}
