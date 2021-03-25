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
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
        }
        CommercialAutomationContext context = new CommercialAutomationContext();

        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Notes", context.connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void Clear()
        {
            textNoteId.Text = "";
            maskedDate.Text = "";
            maskedTime.Text = "";
            textTitle.Text = "";
            textNote.Text = "";
            textNoteOwner.Text = "";
            textNoteCollocutor.Text = "";
        }

        void Delete()
        {
            SqlCommand deleteCommand = new SqlCommand("Delete From Notes where Id=@p1", context.connection());
            deleteCommand.Parameters.AddWithValue("@p1", textNoteId.Text);
            deleteCommand.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Not silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }

        void Update()
        {
            SqlCommand command = new SqlCommand("update Notes set " +
                " NoteDate=@p1,NoteHour=@p2,NoteTitle=@p3,NoteContent=@p4,NoteOwner=@p5,NoteCollocutor=@p6 where NoteId=@p7", context.connection()) ;
            command.Parameters.AddWithValue("@p1", maskedDate.Text);
            command.Parameters.AddWithValue("@p2", maskedTime.Text);
            command.Parameters.AddWithValue("@p3", textTitle.Text);
            command.Parameters.AddWithValue("@p4", textNote.Text);
            command.Parameters.AddWithValue("@p5", textNoteOwner.Text);
            command.Parameters.AddWithValue("@p6", textNoteCollocutor.Text);
            command.Parameters.AddWithValue("@p7", textNoteId.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Not Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        void Add()
        {
            SqlCommand command = new SqlCommand("insert into Notes (NoteDate,NoteHour,NoteTitle,NoteContent,NoteOwner,NoteCollocutor) " +
                " values (@p1,@p2,@p3,@p4,@p5,@p6)",context.connection());
            command.Parameters.AddWithValue("@p1",maskedDate.Text);
            command.Parameters.AddWithValue("@p2",maskedTime.Text);
            command.Parameters.AddWithValue("@p3",textTitle.Text);
            command.Parameters.AddWithValue("@p4",textNote.Text);
            command.Parameters.AddWithValue("@p5",textNoteOwner.Text);
            command.Parameters.AddWithValue("@p6",textNoteCollocutor.Text);
            command.ExecuteNonQuery();
            context.connection().Close();
            MessageBox.Show("Not Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                textNoteId.Text = dataRow["NoteId"].ToString();
                maskedDate.Text = dataRow["NoteDate"].ToString();
                maskedTime.Text = dataRow["NoteHour"].ToString();
                textTitle.Text = dataRow["NoteTitle"].ToString();
                textNote.Text = dataRow["NoteContent"].ToString();
                textNoteOwner.Text = dataRow["NoteOwner"].ToString();
                textNoteCollocutor.Text = dataRow["NoteCollocutor"].ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
