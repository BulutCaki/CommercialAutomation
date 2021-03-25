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
    public partial class BillProductsForm : Form
    {
        public BillProductsForm()
        {
            InitializeComponent();
        }

        public string id;
        CommercialAutomationContext context = new CommercialAutomationContext();
        void List()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from BillDetails where BillId='" + id + "'", context.connection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void Delete()
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From BillDetails where BillDetailId=@p1", context.connection());
            deleteCommand.Parameters.AddWithValue("@p1", textProductId.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Fatura silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }

        void Update()
        {
            double amount, retailPrice, totalPrice;
            retailPrice = Convert.ToDouble(textRetailPrice.Text);
            amount = Convert.ToDouble(textProductAmount.Text);
            totalPrice = amount * retailPrice;
            textTotalPrice.Text = totalPrice.ToString();
            SqlCommand command = new SqlCommand("update BillDetails set " +
                "Product=@p0,ProductName=@p1,ProductModel=@p2,Amount=@p3,RetailPrice=@p4,TotalPrice=@p5,BillId=@p6 where BillDetailId=@p7", context.connection());
            command.Parameters.AddWithValue("@p0", cmbProduct.Text);
            command.Parameters.AddWithValue("@p1", textProductName.Text);
            command.Parameters.AddWithValue("@p2", textProductModel.Text);
            command.Parameters.AddWithValue("@p3", Convert.ToInt32(textProductAmount.Text));
            command.Parameters.AddWithValue("@p4", Convert.ToDecimal(textRetailPrice.Text));
            command.Parameters.AddWithValue("@p5", Convert.ToDecimal(textTotalPrice.Text));
            command.Parameters.AddWithValue("@p6", textBilId.Text);
            command.Parameters.AddWithValue("@p7", textProductId.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Faturaya ait ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }

        void Clear()
        {
            textProductId.Text = "";
            cmbProduct.Text = "";
            textProductName.Text = "";
            textProductModel.Text = "";
            textProductAmount.Text = "";
            textRetailPrice.Text = "";
            textTotalPrice.Text = "";
            textBilId.Text = "";
        }

        void ListProduct()
        {
            SqlCommand command = new SqlCommand("Select ProductName From Products", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbProduct.Properties.Items.Add(reader[0]);
            }
            context.connection().Close();
        }

        private void BillProductsForm_Load(object sender, EventArgs e)
        {
            List();
            ListProduct();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                textProductId.Text = dataRow["BillDetailId"].ToString();
                cmbProduct.Text = dataRow["Product"].ToString();
                textProductName.Text = dataRow["ProductName"].ToString();
                textProductModel.Text = dataRow["ProductModel"].ToString();
                textProductAmount.Text = dataRow["Amount"].ToString();
                textRetailPrice.Text = dataRow["RetailPrice"].ToString();
                textTotalPrice.Text = dataRow["TotalPrice"].ToString();
                textBilId.Text = dataRow["BillId"].ToString();
            }
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            textProductModel.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select Model from Products where Id=@p1", context.connection());
            command.Parameters.AddWithValue("@p1", textProductName.SelectedIndex + 1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textProductModel.Properties.Items.Add(reader[0]);
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            textProductName.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select Brand from Products where Id=@p1", context.connection());
            command.Parameters.AddWithValue("@p1", cmbProduct.SelectedIndex + 1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textProductName.Properties.Items.Add(reader[0]);
            }
        }
    }
}
