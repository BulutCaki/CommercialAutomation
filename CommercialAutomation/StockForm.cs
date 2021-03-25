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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        CommercialAutomationContext context = new CommercialAutomationContext();

        void List()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select ProductName, sum(Piece) as 'Miktar' from Products group by ProductName", context.connection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void ListChart()
        {
            SqlCommand command = new SqlCommand("Select ProductName, sum(Piece) as 'Miktar' from Products group by ProductName", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Stok Grafik"].Points.AddPoint(Convert.ToString(reader[0]),int.Parse(reader[1].ToString()));
            }
            context.connection().Close();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            List();
            ListChart();
        }
    }
}
