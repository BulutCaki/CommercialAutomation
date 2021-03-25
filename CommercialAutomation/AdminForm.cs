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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        CommercialAutomationContext context = new CommercialAutomationContext();
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Users where UserName=@p1 and Password=@p2",context.connection());
            command.Parameters.AddWithValue("@p1",textUserName.Text);
            command.Parameters.AddWithValue("@p2",textPassword.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                HomeForm form = new HomeForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            context.connection().Close();
        }
    }
}
