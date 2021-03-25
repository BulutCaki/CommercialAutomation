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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        CommercialAutomationContext context = new CommercialAutomationContext();

        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Users", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void Update()
        {
            SqlCommand command = new SqlCommand("update Users set " +
                "UserName=@p1,Password=@p2,UserStatu=@p3 where Id=@p4", context.connection());
            command.Parameters.AddWithValue("@p1", username.Text);
            command.Parameters.AddWithValue("@p2", password.Text);
            command.Parameters.AddWithValue("@p3", Statu.Text);
            command.Parameters.AddWithValue("@p4", Id.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Kullanıcı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }

        void Add()
        {
            SqlCommand command = new SqlCommand("insert into Users (UserName,Password,UserStatu)" +
                "values(@p1,@p2,@p3)", context.connection());
            command.Parameters.AddWithValue("@p1", username.Text);
            command.Parameters.AddWithValue("@p2", password.Text);
            command.Parameters.AddWithValue("@p3", Statu.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Kullanıcı Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        void Clear()
        {
            username.Text = "";
            password.Text = "";
            Statu.Text = "";
            Id.Text = "";
        }

        void Delete()
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From Users where Id=@p1", context.connection());
            deleteCommand.Parameters.AddWithValue("@p1", Id.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Kullanıcı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                Id.Text = dataRow["Id"].ToString();
                username.Text = dataRow["UserName"].ToString();
                password.Text = dataRow["Password"].ToString();
                Statu.Text = dataRow["UserStatu"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
