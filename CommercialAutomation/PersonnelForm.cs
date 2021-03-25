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
    public partial class PersonnelsForm : Form
    {
        public PersonnelsForm()
        {
            InitializeComponent();
        }
        CommercialAutomationContext context = new CommercialAutomationContext();
        void ListPersonnel()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Personnels", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        void Clear()
        {
            textPersonnelId.Text = "";
            textPersonnelFirstname.Text = "";
            textPersonnelLastName.Text = "";
            maskedPersonelPhoneNumber.Text = "";
            maskedPersonnelTc.Text = "";
            textPersonnelEmail.Text = "";
            cmbPersonnelCity.Text = "";
            cmbPersonnelDistrict.Text = "";
            textPersonnelStatu.Text = "";
        }

        void ListCity()
        {
            SqlCommand command = new SqlCommand("Select City From Citys", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbPersonnelCity.Properties.Items.Add(reader[0]);
            }
            context.connection().Close();
        }

        void Add()
        {
            SqlCommand command = new SqlCommand("insert into Personnels (FirstName,LastName,PhoneNumber,Tc,Email,City,District,Job)" +
                " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)" , context.connection());
            command.Parameters.AddWithValue("@p1", textPersonnelFirstname.Text);
            command.Parameters.AddWithValue("@p2", textPersonnelLastName.Text);
            command.Parameters.AddWithValue("@p3", maskedPersonelPhoneNumber.Text);
            command.Parameters.AddWithValue("@p4", maskedPersonnelTc.Text);
            command.Parameters.AddWithValue("@p5", textPersonnelEmail.Text);
            command.Parameters.AddWithValue("@p6", cmbPersonnelCity.Text);
            command.Parameters.AddWithValue("@p7", cmbPersonnelDistrict.Text);
            command.Parameters.AddWithValue("@p8", textPersonnelStatu.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Personel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListPersonnel();
        }
        void Update()
        {
            SqlCommand command = new SqlCommand("update Personnels set " +
                "FirstName=@P1,LastName=@P2,PhoneNumber=@P3,Tc=@P4,Email=@P5,City=@P6,District=@P7,Job=@P8 where Id=@P9",context.connection());
            command.Parameters.AddWithValue("@p1", textPersonnelFirstname.Text);
            command.Parameters.AddWithValue("@p2", textPersonnelLastName.Text);
            command.Parameters.AddWithValue("@p3", maskedPersonelPhoneNumber.Text);
            command.Parameters.AddWithValue("@p4", maskedPersonnelTc.Text);
            command.Parameters.AddWithValue("@p5", textPersonnelEmail.Text);
            command.Parameters.AddWithValue("@p6", cmbPersonnelCity.Text);
            command.Parameters.AddWithValue("@p7", cmbPersonnelDistrict.Text);
            command.Parameters.AddWithValue("@p8", textPersonnelStatu.Text);
            command.Parameters.AddWithValue("@p9", textPersonnelId.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListPersonnel();
        }

        void Delete()
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From Personnels where Id=@p1", context.connection());
            deleteCommand.Parameters.AddWithValue("@p1", textPersonnelId.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Personel silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ListPersonnel();
        }

        private void PersonnelsForm_Load(object sender, EventArgs e)
        {
            ListCity();
            ListPersonnel();
            
        }

        private void cmbPersonnelDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPersonnelCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPersonnelDistrict.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select District from Districts where CityId=@p1", context.connection());
            command.Parameters.AddWithValue("@p1", cmbPersonnelCity.SelectedIndex + 1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbPersonnelDistrict.Properties.Items.Add(reader[0]);
            }
            context.connection().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                textPersonnelId.Text = dataRow["Id"].ToString();
                textPersonnelFirstname.Text = dataRow["FirstName"].ToString();
                textPersonnelLastName.Text = dataRow["LastName"].ToString();
                maskedPersonelPhoneNumber.Text = dataRow["PhoneNumber"].ToString();
                maskedPersonnelTc.Text = dataRow["Tc"].ToString();
                textPersonnelEmail.Text = dataRow["Email"].ToString();
                cmbPersonnelCity.Text = dataRow["City"].ToString();
                cmbPersonnelDistrict.Text = dataRow["District"].ToString();
                textPersonnelStatu.Text = dataRow["Job"].ToString();

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
