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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }
        
        void Update()
        {
            SqlCommand command = new SqlCommand("update Customers set " +
                "FirstName=@P1,LastName=@P2,PhoneNumber=@P3,PhoneNumber2=@P4,TC=@P5,Email=@P6,City=@P7,District=@P8,Adress=@P9,TaxAdministration=@P10 where Id=@P11", context.connection());
            command.Parameters.AddWithValue("@p1", textCustomerFirstname.Text);
            command.Parameters.AddWithValue("@p2", textCustomerLastName.Text);
            command.Parameters.AddWithValue("@p3", maskedCustomerPhoneNumber1.Text);
            command.Parameters.AddWithValue("@p4", maskedCustomerPhoneNumber2.Text);
            command.Parameters.AddWithValue("@p5", maskedCustomerTc.Text);
            command.Parameters.AddWithValue("@p6", textCustomerEmail.Text);
            command.Parameters.AddWithValue("@p7", cmbCustomerCity.Text);
            command.Parameters.AddWithValue("@p8", cmbCustomerDistrict.Text);
            command.Parameters.AddWithValue("@p9", textCustomerAdress.Text);
            command.Parameters.AddWithValue("@p10", textCustomerTaxAdministiration.Text);
            command.Parameters.AddWithValue("@p11", textCustomerId.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }

        void Add()
        {
            SqlCommand command = new SqlCommand("insert into Customers (FirstName,LastName,PhoneNumber,PhoneNumber2,TC,Email,City,District,Adress,TaxAdministration)" +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", context.connection());
            command.Parameters.AddWithValue("@p1", textCustomerFirstname.Text);
            command.Parameters.AddWithValue("@p2", textCustomerLastName.Text);
            command.Parameters.AddWithValue("@p3", maskedCustomerPhoneNumber1.Text);
            command.Parameters.AddWithValue("@p4", maskedCustomerPhoneNumber2.Text);
            command.Parameters.AddWithValue("@p5", maskedCustomerTc.Text);
            command.Parameters.AddWithValue("@p6", textCustomerEmail.Text);
            command.Parameters.AddWithValue("@p7", cmbCustomerCity.Text);
            command.Parameters.AddWithValue("@p8", cmbCustomerDistrict.Text);
            command.Parameters.AddWithValue("@p9", textCustomerAdress.Text);
            command.Parameters.AddWithValue("@p10", textCustomerTaxAdministiration.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        void Delete()
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From Customers where Id=@p1", context.connection());
            deleteCommand.Parameters.AddWithValue("@p1", textCustomerId.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Müşteri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Customers", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void Clear()
        {
            textCustomerId.Text = "";
            textCustomerFirstname.Text = "";
            textCustomerLastName.Text = "";
            maskedCustomerPhoneNumber1.Text = "";
            maskedCustomerPhoneNumber2.Text = "";
            maskedCustomerTc.Text = "";
            textCustomerEmail.Text = "";
            cmbCustomerCity.Text = "";
            cmbCustomerDistrict.Text = "";
            textCustomerAdress.Text = "";
            textCustomerTaxAdministiration.Text = "";
        }

        void ListCity()
        {
            SqlCommand command = new SqlCommand("Select City From Citys",context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbCustomerCity.Properties.Items.Add(reader[0]);
            }
            context.connection().Close();
        }

        CommercialAutomationContext context = new CommercialAutomationContext();
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            List();
            ListCity();
        }

        private void cmbCustomerCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomerDistrict.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select District from Districts where CityId=@p1",context.connection());
            command.Parameters.AddWithValue("@p1" , cmbCustomerCity.SelectedIndex + 1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbCustomerDistrict.Properties.Items.Add(reader[0]);
            }
            context.connection().Close();
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
                textCustomerId.Text = dataRow["Id"].ToString();
                textCustomerFirstname.Text = dataRow["FirstName"].ToString();
                textCustomerLastName.Text = dataRow["LastName"].ToString();
                maskedCustomerPhoneNumber1.Text = dataRow["PhoneNumber"].ToString();
                maskedCustomerPhoneNumber2.Text = dataRow["PhoneNumber2"].ToString();
                maskedCustomerTc.Text = dataRow["TC"].ToString();
                textCustomerEmail.Text = dataRow["Email"].ToString();
                cmbCustomerCity.Text = dataRow["City"].ToString();
                cmbCustomerDistrict.Text = dataRow["District"].ToString();
                textCustomerAdress.Text = dataRow["Adress"].ToString();
                textCustomerTaxAdministiration.Text = dataRow["TaxAdministration"].ToString();
            }
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
