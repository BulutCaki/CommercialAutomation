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
    public partial class ExpensesForm : Form
    {
        public ExpensesForm()
        {
            InitializeComponent();
        }
        CommercialAutomationContext context = new CommercialAutomationContext();
        void ListExpense()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Expenses", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        void Add()
        {
            SqlCommand command = new SqlCommand("insert into Expenses " +
                "(Month,Year,ElectricExpense,WaterExpense,GasExpense,InternetExpense,SalaryExpense,ExtraExpense,ExtraDetails)" +
                " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", context.connection());
            command.Parameters.AddWithValue("@p1",cmbMonth.Text);
            command.Parameters.AddWithValue("@p2",cmbYear.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(textElectricExpense.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(textWaterExpense.Text));
            command.Parameters.AddWithValue("@p5", decimal.Parse(textGasExpense.Text));
            command.Parameters.AddWithValue("@p6", decimal.Parse(textInternetExpense.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(textSalaryExpense.Text));
            command.Parameters.AddWithValue("@p8", decimal.Parse(textExtra.Text));
            command.Parameters.AddWithValue("@p9",richTextExtraDetails.Text); 
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Gider Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListExpense();
        }

        void Update()
        {
            SqlCommand command = new SqlCommand("update Expenses set " +
                "Month=@P1,Year=@P2,ElectricExpense=@P3,WaterExpense=@P4,GasExpense=@P5,InternetExpense=@P6,SalaryExpense=@P7,ExtraExpense=@P8,ExtraDetails=@P9 where Id=@P10", context.connection());
            command.Parameters.AddWithValue("@P1", cmbMonth.Text);
            command.Parameters.AddWithValue("@P2", cmbYear.Text);
            command.Parameters.AddWithValue("@P3", decimal.Parse(textElectricExpense.Text));
            command.Parameters.AddWithValue("@P4", decimal.Parse(textWaterExpense.Text));
            command.Parameters.AddWithValue("@P5", decimal.Parse(textGasExpense.Text));
            command.Parameters.AddWithValue("@P6", decimal.Parse(textInternetExpense.Text));
            command.Parameters.AddWithValue("@P7", decimal.Parse(textSalaryExpense.Text));
            command.Parameters.AddWithValue("@P8", decimal.Parse(textExtra.Text));
            command.Parameters.AddWithValue("@P9", richTextExtraDetails.Text);
            command.Parameters.AddWithValue("@P10", textExpenseId.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Gider Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListExpense();
        }

        void Delete()
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From Expenses where Id=@p1", context.connection());
            deleteCommand.Parameters.AddWithValue("@p1", textExpenseId.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Gider silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ListExpense();
        }

        void Clear()
        {
            textExpenseId.Text = "";
            cmbMonth.Text = "";
            cmbYear.Text = "";
            textElectricExpense.Text = "";
            textWaterExpense.Text = "";
            textGasExpense.Text = "";
            textInternetExpense.Text = "";
            textSalaryExpense.Text = "";
            textExtra.Text = "";
            richTextExtraDetails.Text = "";
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            ListExpense();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                textExpenseId.Text = dataRow["Id"].ToString();
                cmbMonth.Text = dataRow["Month"].ToString();
                cmbYear.Text = dataRow["Year"].ToString();
                textElectricExpense.Text = dataRow["ElectricExpense"].ToString();
                textWaterExpense.Text = dataRow["WaterExpense"].ToString();
                textGasExpense.Text = dataRow["GasExpense"].ToString();
                textInternetExpense.Text = dataRow["InternetExpense"].ToString();
                textSalaryExpense.Text = dataRow["SalaryExpense"].ToString();
                textExtra.Text = dataRow["ExtraExpense"].ToString();
                richTextExtraDetails.Text = dataRow["ExtraDetails"].ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
