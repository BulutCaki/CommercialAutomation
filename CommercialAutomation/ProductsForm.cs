using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        CommercialAutomationContext context = new CommercialAutomationContext();
        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Products",context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        void Clear()
        {
            textProductId.Text = "";
            textProductName.Text = "";
            textProductBrand.Text = "";
            textProductModel.Text = "";
            maskedProductYear.Text = "";
            nudProductAmount.Text = "";
            textBuyingPrice.Text = "";
            textSalePrice.Text = "";
            textProductDetails.Text = "";
        }
        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void productsForm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Products (ProductName,Brand,Model,Year,Piece,BuyingPrice,SalePrice,Details) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", context.connection());
            command.Parameters.AddWithValue("@p1",textProductName.Text);
            command.Parameters.AddWithValue("@p2", textProductBrand.Text);
            command.Parameters.AddWithValue("@p3", textProductModel.Text);
            command.Parameters.AddWithValue("@p4", maskedProductYear.Text);
            command.Parameters.AddWithValue("@p5", nudProductAmount.Value);
            command.Parameters.AddWithValue("@p6", decimal.Parse(textBuyingPrice.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(textSalePrice.Text));
            command.Parameters.AddWithValue("@p8", textProductDetails.Text);
              command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Ürün sisteme eklendi." , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            List();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From Products where Id=@p1",context.connection());
            deleteCommand.Parameters.AddWithValue("@p1" , textProductId.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textProductId.Text = dataRow["Id"].ToString();
            textProductName.Text = dataRow["ProductName"].ToString();
            textProductBrand.Text = dataRow["Brand"].ToString();
            textProductModel.Text = dataRow["Model"].ToString();
            maskedProductYear.Text = dataRow["Year"].ToString();
            nudProductAmount.Text =  dataRow["Piece"].ToString();
            textBuyingPrice.Text =  dataRow["BuyingPrice"].ToString();
            textSalePrice.Text =  dataRow["SalePrice"].ToString();
            textProductDetails.Text =  dataRow["Details"].ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Products set " +
                "ProductName=@p1,Brand=@p2,Model=@p3,Year=@p4,Piece=@p5,BuyingPrice=@p6,SalePrice=@p7,Details=@p8 where Id=@p9",context.connection());
            command.Parameters.AddWithValue("@p1", textProductName.Text);
            command.Parameters.AddWithValue("@p2", textProductBrand.Text);
            command.Parameters.AddWithValue("@p3", textProductModel.Text);
            command.Parameters.AddWithValue("@p4", maskedProductYear.Text);
            command.Parameters.AddWithValue("@p5", nudProductAmount.Value);
            command.Parameters.AddWithValue("@p6", decimal.Parse(textBuyingPrice.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(textSalePrice.Text));
            command.Parameters.AddWithValue("@p8", textProductDetails.Text);
            command.Parameters.AddWithValue("@p9", textProductId.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Ürün güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
