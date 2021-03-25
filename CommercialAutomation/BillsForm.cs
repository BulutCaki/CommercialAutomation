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
    public partial class BillsForm : Form
    {
        public BillsForm()
        {
            InitializeComponent();
        }
        CommercialAutomationContext context = new CommercialAutomationContext();

        void ListBillInfo()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from InfoBill", context.connection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void Clear()
        {
            billId.Text = "";
            textSerialNo.Text = "";
            textOrderNo.Text = "";
            maskedBillDate.Text = "";
            maskedBillTime.Text = "";
            textTaxAdministiration.Text = "";
            textReceiver.Text = "";
            textSender.Text = "";
            textReceiverPerson.Text = "";
        }

        void Delete()
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From InfoBill where BillId=@p1", context.connection());
            deleteCommand.Parameters.AddWithValue("@p1", textBillId.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Fatura silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ListBillInfo();
        }

        void Update()
        {
            SqlCommand command = new SqlCommand("update InfoBill set " +
                    " SerialNo=@p1,OrderNumber=@p2,Date=@p3,Hour=@p4,TaxAdministration=@p5,Receiver=@p6,Sender=@p7,ReceiverPerson=@p8 where BillId=@p9 ", context.connection());
            command.Parameters.AddWithValue("@p1", textSerialNo.Text);
            command.Parameters.AddWithValue("@p2", textOrderNo.Text);
            command.Parameters.AddWithValue("@p3", maskedBillDate.Text);
            command.Parameters.AddWithValue("@p4", maskedBillTime.Text);
            command.Parameters.AddWithValue("@p5", textTaxAdministiration.Text);
            command.Parameters.AddWithValue("@p6", textReceiver.Text);
            command.Parameters.AddWithValue("@p7", textSender.Text);
            command.Parameters.AddWithValue("@p8", textReceiverPerson.Text);
            command.Parameters.AddWithValue("@p9", billId.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Fatura güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ListBillInfo();
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
        
        void Add()
        {
            if (textBillId.Text == "")
            {
                SqlCommand command = new SqlCommand("insert into InfoBill " +
                    " (SerialNo,OrderNumber,Date,Hour,TaxAdministration,Receiver,Sender,ReceiverPerson)" +
                    " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", context.connection());
                command.Parameters.AddWithValue("@p1", textSerialNo.Text);
                command.Parameters.AddWithValue("@p2", textOrderNo.Text);
                command.Parameters.AddWithValue("@p3", maskedBillDate.Text);
                command.Parameters.AddWithValue("@p4", maskedBillTime.Text);
                command.Parameters.AddWithValue("@p5", textTaxAdministiration.Text);
                command.Parameters.AddWithValue("@p6", textReceiver.Text);
                command.Parameters.AddWithValue("@p7", textSender.Text);
                command.Parameters.AddWithValue("@p8", textReceiverPerson.Text);
                command.ExecuteNonQuery();
                context.connection().Close();
                MessageBox.Show("Fatura sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ListBillInfo();
            }
            if (textBillId.Text != "")
            {
                double amount, retailPrice, totalPrice;
                retailPrice = Convert.ToDouble(textRetailPrice.Text);
                amount = Convert.ToDouble(textProductAmount.Text);
                totalPrice = amount * retailPrice;
                textTotalPrice.Text = totalPrice.ToString(); 
                SqlCommand command2 = new SqlCommand("insert into BillDetails " +
                    " (ProductName,ProductModel,Amount,RetailPrice,TotalPrice,BillId)" +
                    " values (@p1,@p2,@p3,@p4,@p5,@p6)", context.connection());
                command2.Parameters.AddWithValue("@p1", cmbProductName.Text);
                command2.Parameters.AddWithValue("@p2", cmbProductModel.Text);
                command2.Parameters.AddWithValue("@p3", textProductAmount.Text);
                command2.Parameters.AddWithValue("@p4", textRetailPrice.Text);
                command2.Parameters.AddWithValue("@p5", textTotalPrice.Text);
                command2.Parameters.AddWithValue("@p6", textBillId.Text);
                command2.ExecuteNonQuery();
                context.connection().Close();
                MessageBox.Show("Faturaya ait ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ListBillInfo();
            }
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            ListBillInfo();
            ListProduct();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
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
                billId.Text = dataRow["BillId"].ToString();
                textSerialNo.Text = dataRow["SerialNo"].ToString();
                textOrderNo.Text = dataRow["OrderNumber"].ToString();
                maskedBillDate.Text = dataRow["Date"].ToString();
                maskedBillTime.Text = dataRow["Hour"].ToString();
                textTaxAdministiration.Text = dataRow["TaxAdministration"].ToString();
                textReceiver.Text = dataRow["Receiver"].ToString();
                textSender.Text = dataRow["Sender"].ToString();
                textReceiverPerson.Text = dataRow["ReceiverPerson"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListBillInfo();
            ListProduct();
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            BillProductsForm billProductsForm = new BillProductsForm();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                billProductsForm.id = dataRow["BillId"].ToString();
            }
            billProductsForm.Show();
        }

        private void label8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProductModel.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select Model from Products where Id=@p1", context.connection());
            command.Parameters.AddWithValue("@p1", cmbProductName.SelectedIndex + 1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbProductModel.Properties.Items.Add(reader[0]);
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProductName.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select Brand from Products where Id=@p1", context.connection());
            command.Parameters.AddWithValue("@p1", cmbProduct.SelectedIndex + 1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbProductName.Properties.Items.Add(reader[0]);
            }
        }
    }
}
