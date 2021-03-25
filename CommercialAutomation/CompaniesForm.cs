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
    public partial class CompaniesForm : Form
    {
        public CompaniesForm()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupControl6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void companyName_Click(object sender, EventArgs e)
        {

        }

        private void companySector_Click(object sender, EventArgs e)
        {

        }
        CommercialAutomationContext context = new CommercialAutomationContext();
        void ListCompany()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Companies", context.connection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        void ListCity()
        {
            SqlCommand command = new SqlCommand("Select City From Citys", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbCompanyCity.Properties.Items.Add(reader[0]);
            }
            context.connection().Close();
        }

        void CodeContent()
        {
            SqlCommand command = new SqlCommand("Select SpecialCode1 from Codes" , context.connection());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                specialCode1Content.Text = dataReader[0].ToString();
            }
            context.connection().Close();
        }
        void Delete()
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From Companies where Id=@p1", context.connection());
            deleteCommand.Parameters.AddWithValue("@p1", companyId.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Müşteri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ListCompany();
        }
        void Clear()
        {
            companyId.Text = "";
            companyName.Text = "";
            companySector.Text = "";
            CommisionerStatu.Text = "";
            Commisioner.Text = "";
            maskedCuommisionerTc.Text = "";
            maskedCompanyPhoneNumber1.Text = "";
            maskedCompanyPhoneNumber2.Text = "";
            maskedCompanyPhoneNumber3.Text = "";
            textCompanyEmail.Text = "";
            maskedFax.Text = "";
            cmbCompanyCity.Text = "";
            cmbCompanyDistrict.Text = "";
            textCompanyTaxAdministiration.Text = "";
            textCompanyAdress.Text = "";
            specialCode1.Text = "";
            specialCode2.Text = "";
            specialCode3.Text = "";
        }
        void Add()
        {
            SqlCommand command = new SqlCommand("insert into Companies " +
                "(CompanyName,Sector,CommissionerJob ,CommissionerName ,CommisionerTc ,PhoneNumber1, PhoneNumber2 ,PhoneNumber3, Email, Fax, City, District ,TaxAdministration ,Adress ,SpecialCode1 ,SpecialCode2 ,SpecialCode3)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", context.connection());
            command.Parameters.AddWithValue("@p1", companyName.Text);
            command.Parameters.AddWithValue("@p2", companySector.Text);
            command.Parameters.AddWithValue("@p3", CommisionerStatu.Text);
            command.Parameters.AddWithValue("@p4", Commisioner.Text);
            command.Parameters.AddWithValue("@p5", maskedCuommisionerTc.Text);
            command.Parameters.AddWithValue("@p6", maskedCompanyPhoneNumber1.Text);
            command.Parameters.AddWithValue("@p7", maskedCompanyPhoneNumber2.Text);
            command.Parameters.AddWithValue("@p8", maskedCompanyPhoneNumber3.Text);
            command.Parameters.AddWithValue("@p9", textCompanyEmail.Text);
            command.Parameters.AddWithValue("@p10", maskedFax.Text);
            command.Parameters.AddWithValue("@p11", cmbCompanyCity.Text);
            command.Parameters.AddWithValue("@p12", cmbCompanyDistrict.Text);
            command.Parameters.AddWithValue("@p13", textCompanyTaxAdministiration.Text);
            command.Parameters.AddWithValue("@p14", textCompanyAdress.Text);
            command.Parameters.AddWithValue("@p15", specialCode1.Text);
            command.Parameters.AddWithValue("@p16", specialCode2.Text);
            command.Parameters.AddWithValue("@p17", specialCode3.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Firma sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ListCompany();
        }
        void Update()
        {
            SqlCommand command = new SqlCommand("Update Companies set" +
                " CompanyName=@p1,Sector=@p2,CommissionerJob =@p3,CommissionerName=@p4 ,CommisionerTc=@p5 ,PhoneNumber1=@p6, PhoneNumber2 =@p7,PhoneNumber3=@p8, Email=@p9, Fax=@p10, City=@p11, District=@p12 ,TaxAdministration =@p13,Adress =@p14,SpecialCode1 =@p15,SpecialCode2=@p16 ,SpecialCode3=@p17 where Id=@p18"
                , context.connection());
            command.Parameters.AddWithValue("@p1", companyName.Text);
            command.Parameters.AddWithValue("@p2", companySector.Text);
            command.Parameters.AddWithValue("@p3", CommisionerStatu.Text);
            command.Parameters.AddWithValue("@p4", Commisioner.Text);
            command.Parameters.AddWithValue("@p5", maskedCuommisionerTc.Text);
            command.Parameters.AddWithValue("@p6", maskedCompanyPhoneNumber1.Text);
            command.Parameters.AddWithValue("@p7", maskedCompanyPhoneNumber2.Text);
            command.Parameters.AddWithValue("@p8", maskedCompanyPhoneNumber3.Text);
            command.Parameters.AddWithValue("@p9", textCompanyEmail.Text);
            command.Parameters.AddWithValue("@p10", maskedFax.Text);
            command.Parameters.AddWithValue("@p11", cmbCompanyCity.Text);
            command.Parameters.AddWithValue("@p12", cmbCompanyDistrict.Text);
            command.Parameters.AddWithValue("@p13", textCompanyTaxAdministiration.Text);
            command.Parameters.AddWithValue("@p14", textCompanyAdress.Text);
            command.Parameters.AddWithValue("@p15", specialCode1.Text);
            command.Parameters.AddWithValue("@p16", specialCode2.Text);
            command.Parameters.AddWithValue("@p17", specialCode3.Text);
            command.Parameters.AddWithValue("@p18", companyId.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Firma güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ListCompany();
        }
        private void CompaniesForm_Load(object sender, EventArgs e)
        {
            ListCompany();
            ListCity();
            CodeContent();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                companyId.Text = dataRow["Id"].ToString();
                companyName.Text = dataRow["CompanyName"].ToString();
                companySector.Text = dataRow["Sector"].ToString();
                CommisionerStatu.Text = dataRow["CommissionerJob"].ToString();
                Commisioner.Text = dataRow["CommissionerName"].ToString();
                maskedCuommisionerTc.Text = dataRow["CommisionerTc"].ToString();
                maskedCompanyPhoneNumber1.Text = dataRow["PhoneNumber1"].ToString();
                maskedCompanyPhoneNumber2.Text = dataRow["PhoneNumber2"].ToString();
                maskedCompanyPhoneNumber3.Text = dataRow["PhoneNumber3"].ToString();
                textCompanyEmail.Text = dataRow["Email"].ToString();
                maskedFax.Text = dataRow["Fax"].ToString();
                cmbCompanyCity.Text = dataRow["City"].ToString();
                cmbCompanyDistrict.Text = dataRow["District"].ToString();
                textCompanyTaxAdministiration.Text = dataRow["TaxAdministration"].ToString();
                textCompanyAdress.Text = dataRow["Adress"].ToString();
                specialCode1.Text = dataRow["SpecialCode1"].ToString();
                specialCode2.Text = dataRow["SpecialCode2"].ToString();
                specialCode3.Text = dataRow["SpecialCode3"].ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Add();
            Clear();
        }
        

        private void cmbCompanyDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCompanyDistrict.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select District from Districts where CityId=@P1", context.connection());
            command.Parameters.AddWithValue("@P1", cmbCompanyCity.SelectedIndex + 1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbCompanyDistrict.Properties.Items.Add(reader[0]);
            }
            context.connection().Close();
        }

        private void cmbCompanyCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCompanyDistrict.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select District from Districts where CityId=@p1", context.connection());
            command.Parameters.AddWithValue("@p1", cmbCompanyCity.SelectedIndex + 1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbCompanyDistrict.Properties.Items.Add(reader[0]);
            }
            context.connection().Close();
        }
        

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            Delete();
            Clear();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            Update();
            Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
