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
using DevExpress.Charts;

namespace CommercialAutomation
{
    public partial class SafeForm : Form
    {
        public SafeForm()
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
            gridControl2.DataSource = dataTable;
        }

        void ListExpenses()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Expenses", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl4.DataSource = dataTable;
        }

        void CalculateTotalAmount()
        {
            SqlCommand command = new SqlCommand("Select sum(TotalPrice) from BillDetails", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TotalAmount.Text = reader[0].ToString() + " TL";
            }
            context.connection().Close();
        }

        void CalculateLastMonthPayment()
        {
            SqlCommand command = new SqlCommand("Select  (ElectricExpense+WaterExpense+GasExpense+InternetExpense) from Expenses order by Id", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Payment.Text = reader[0].ToString() + " TL";
            }
            context.connection().Close();
        }

        void CalculatePersonelSalary()
        {
            SqlCommand command = new SqlCommand("Select  SalaryExpense from Expenses order by Id", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PersonelSalary.Text = reader[0].ToString() + " TL";
            }
            context.connection().Close();
        }

        void CalculateCustomerAmount()
        {
            SqlCommand command = new SqlCommand("Select COUNT(Id) from Customers", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CustomerAmount.Text = reader[0].ToString();
            }
            context.connection().Close();
        }

        void CalculateCompanyAmount()
        {
            SqlCommand command = new SqlCommand("Select COUNT(Id) from Companies", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CompanyAmount.Text = reader[0].ToString();
            }
            context.connection().Close();
        }

        void CalculateCompanyCity() 
        {
            SqlCommand command = new SqlCommand("Select COUNT(Distinct(City)) from Companies", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CityAmount.Text = reader[0].ToString();
            }
            context.connection().Close();
        }

        void CalculatePersonnelAmount()
        {
            SqlCommand command = new SqlCommand("Select COUNT(Id) from Personnels", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PersonelAmount.Text = reader[0].ToString();
            }
            context.connection().Close();
        }

        void CalculateStockAmount() 
        {
            SqlCommand command = new SqlCommand("Select SUM(Piece) from Products", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                StockAmount.Text = reader[0].ToString();
            }
            context.connection().Close();
        }

        void CalculateElectricChart()
        {
            SqlCommand command = new SqlCommand("Select top 4 Month,ElectricExpense from Expenses order by Id asc", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0],reader[1]));
            }
            context.connection().Close();
        }

        void CalculateWaterChart()
        {
            SqlCommand command = new SqlCommand("Select top 4 Month,WaterExpense from Expenses order by Id asc", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
            }
            context.connection().Close();
        }

        void CalculateGasChart()
        {
            SqlCommand command = new SqlCommand("Select top 4 Month,GasExpense from Expenses order by Id asc", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
            }
            context.connection().Close();
        }

        void CalculateInternetExpense()
        {
            SqlCommand command = new SqlCommand("Select top 4 Month,InternetExpense from Expenses order by Id asc", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
            }
            context.connection().Close();
        }

        void CalculateExtraExpense()
        {
            SqlCommand command = new SqlCommand("Select top 4 Month,ExtraExpense from Expenses order by Id asc", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
            }
            context.connection().Close();
        }

        

        private void SafeForm_Load(object sender, EventArgs e)
        {
            ListCustomerActions();
            ListCompanyActions();
            ListExpenses();
            CalculateTotalAmount();
            CalculateLastMonthPayment();
            CalculatePersonelSalary();
            CalculateCustomerAmount();
            CalculateCompanyAmount();
            CalculateCompanyCity();
            CalculatePersonnelAmount();
            CalculateStockAmount();
            CalculateElectricChart();
            CalculateWaterChart();
            CalculateGasChart();
            CalculateInternetExpense();
            CalculateExtraExpense();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > 0 && counter <= 7)
            {
                groupControl9.Text = "Elektrik";
                chartControl1.Series["Aylar"].Points.Clear();
                CalculateElectricChart();
            }
            if (counter > 7 && counter <=14)
            {
                groupControl9.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                CalculateWaterChart();
            }
            if (counter > 14 && counter <= 21)
            {
                groupControl9.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                CalculateGasChart();
            }
            if (counter > 21 && counter <= 28)
            {
                groupControl9.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                CalculateInternetExpense();
            }
            if (counter > 28 && counter <= 35)
            {
                groupControl9.Text = "Ekstralar";
                chartControl1.Series["Aylar"].Points.Clear();
                CalculateExtraExpense();
            }
            if (counter == 35)
            {
                counter = 0;
            }
            
            
        }
    }
}
