using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class Bankalar : Form
    {
        public Bankalar()
        {
            InitializeComponent();
        }

        CommercialAutomationContext context = new CommercialAutomationContext();

        void ListBanks()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Execute BanksInfo", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void ListCompany()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Id,CompanyName from Companies", context.connection());
            sqlDataAdapter.Fill(dataTable);
            lookUpEdit1.Properties.ValueMember = "Id";
            lookUpEdit1.Properties.DisplayMember = "CompanyName";
            lookUpEdit1.Properties.DataSource = dataTable;
        }

        void Update()
        {
            SqlCommand command = new SqlCommand("update Banks set " +
                "BankName=@P1,Branch=@P2,PhoneNumber=@P3,City=@P4,District=@P5,IBAN=@P6,AccountCode=@P7,Commissioner=@P8,Date=@P9,AccountType=@P10,CompanyId=@P11 where Id=@P12", context.connection());
            command.Parameters.AddWithValue("@P1", textBankName.Text);
            command.Parameters.AddWithValue("@P2", textBankBranchName.Text);
            command.Parameters.AddWithValue("@P3", PhoneNumber.Text);
            command.Parameters.AddWithValue("@P4", cmbCity.Text);
            command.Parameters.AddWithValue("@P5", cmbDistrict.Text);
            command.Parameters.AddWithValue("@P6", textIBAN.Text);
            command.Parameters.AddWithValue("@P7", textAccountCode.Text);
            command.Parameters.AddWithValue("@P8", textCommisionerName.Text);
            command.Parameters.AddWithValue("@P9", maskedDate.Text);
            command.Parameters.AddWithValue("@P10", textAccountType.Text);
            command.Parameters.AddWithValue("@P11", lookUpEdit1.EditValue);
            command.Parameters.AddWithValue("@P12", textBankId.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Banka  Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListBanks();
        }
        
        void Add()
        {
            SqlCommand command = new SqlCommand("insert into Banks (BankName,Branch,PhoneNumber,City,District,IBAN,AccountCode,Commissioner,Date,AccountType,CompanyId) " +
                " values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",context.connection());
            command.Parameters.AddWithValue("@p1",textBankName.Text);
            command.Parameters.AddWithValue("@p2",textBankBranchName.Text);
            command.Parameters.AddWithValue("@p3",PhoneNumber.Text);
            command.Parameters.AddWithValue("@p4",cmbCity.Text);
            command.Parameters.AddWithValue("@p5",cmbDistrict.Text);
            command.Parameters.AddWithValue("@p6",textIBAN.Text);
            command.Parameters.AddWithValue("@p7",textAccountCode.Text);
            command.Parameters.AddWithValue("@p8",textCommisionerName.Text);
            command.Parameters.AddWithValue("@p9",maskedDate.Text);
            command.Parameters.AddWithValue("@p10",textAccountType.Text);
            command.Parameters.AddWithValue("@p11",lookUpEdit1.EditValue);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Banka Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListBanks();
        }

        void Delete()
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From Banks where Id=@p1", context.connection());
            deleteCommand.Parameters.AddWithValue("@p1", textBankId.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Müşteri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ListBanks();
        }

        void Clear()
        {
            textBankId.Text = "";
            textBankName.Text = "";
            textBankBranchName.Text = "";
            PhoneNumber.Text = "";
            cmbCity.Text = "";
            cmbDistrict.Text = "";
            textIBAN.Text = "";
            textAccountCode.Text = "";
            textCommisionerName.Text = "";
            maskedDate.Text = "";
            textAccountType.Text = "";
        }

        void ListCity()
        {
            SqlCommand command = new SqlCommand("Select City From Citys", context.connection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbCity.Properties.Items.Add(reader[0]);
            }
            context.connection().Close();
        }

        private void Bankalar_Load(object sender, EventArgs e)
        {
            ListBanks();
            ListCity();
            ListCompany();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select District from Districts where CityId=@p1", context.connection());
            command.Parameters.AddWithValue("@p1", cmbCity.SelectedIndex + 1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbDistrict.Properties.Items.Add(reader[0]);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListBanks();
            ListCity();
            ListCompany();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                textBankId.Text = dataRow["Id"].ToString();
                textBankName.Text = dataRow["BankName"].ToString();
                textBankBranchName.Text = dataRow["Branch"].ToString();
                PhoneNumber.Text = dataRow["PhoneNumber"].ToString();
                cmbCity.Text = dataRow["City"].ToString();
                cmbDistrict.Text = dataRow["District"].ToString();
                textIBAN.Text = dataRow["IBAN"].ToString();
                textAccountCode.Text = dataRow["AccountCode"].ToString();
                textCommisionerName.Text = dataRow["Commissioner"].ToString();
                maskedDate.Text = dataRow["Date"].ToString();
                textAccountType.Text = dataRow["AccountType"].ToString();    
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        
    }
}
