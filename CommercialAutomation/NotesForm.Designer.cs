
namespace CommercialAutomation
{
    partial class NotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            this.textNoteOwner = new DevExpress.XtraEditors.TextEdit();
            this.maskedTime = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.updateButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.textNote = new System.Windows.Forms.RichTextBox();
            this.textTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textNoteCollocutor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.maskedDate = new System.Windows.Forms.MaskedTextBox();
            this.textNoteId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNoteOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNoteCollocutor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNoteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1619, 1058);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clearButton
            // 
            this.clearButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearButton.Appearance.Options.UseFont = true;
            this.clearButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.ImageOptions.Image")));
            this.clearButton.Location = new System.Drawing.Point(47, 577);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(114, 36);
            this.clearButton.TabIndex = 30;
            this.clearButton.Text = "Temizle";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // textNoteOwner
            // 
            this.textNoteOwner.Location = new System.Drawing.Point(98, 148);
            this.textNoteOwner.Name = "textNoteOwner";
            this.textNoteOwner.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNoteOwner.Properties.Appearance.Options.UseFont = true;
            this.textNoteOwner.Size = new System.Drawing.Size(189, 24);
            this.textNoteOwner.TabIndex = 23;
            // 
            // maskedTime
            // 
            this.maskedTime.Location = new System.Drawing.Point(81, 93);
            this.maskedTime.Mask = "00:00";
            this.maskedTime.Name = "maskedTime";
            this.maskedTime.Size = new System.Drawing.Size(206, 21);
            this.maskedTime.TabIndex = 26;
            this.maskedTime.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(15, 208);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 18);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Not :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(5, 151);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(90, 18);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Notun Sahibi :";
            // 
            // updateButton
            // 
            this.updateButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateButton.Appearance.Options.UseFont = true;
            this.updateButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.ImageOptions.Image")));
            this.updateButton.Location = new System.Drawing.Point(47, 493);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(114, 36);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Güncelle";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.Appearance.Options.UseFont = true;
            this.deleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.ImageOptions.Image")));
            this.deleteButton.Location = new System.Drawing.Point(47, 535);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 36);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Sil";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.Location = new System.Drawing.Point(47, 451);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 36);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Kaydet";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textNote
            // 
            this.textNote.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNote.Location = new System.Drawing.Point(54, 209);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(233, 223);
            this.textNote.TabIndex = 18;
            this.textNote.Text = "";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(81, 118);
            this.textTitle.Name = "textTitle";
            this.textTitle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTitle.Properties.Appearance.Options.UseFont = true;
            this.textTitle.Size = new System.Drawing.Size(206, 24);
            this.textTitle.TabIndex = 14;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(30, 120);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 18);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "Başlık :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(36, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Saat :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = " Tarih :";
            // 
            // textNoteCollocutor
            // 
            this.textNoteCollocutor.Location = new System.Drawing.Point(98, 178);
            this.textNoteCollocutor.Name = "textNoteCollocutor";
            this.textNoteCollocutor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNoteCollocutor.Properties.Appearance.Options.UseFont = true;
            this.textNoteCollocutor.Size = new System.Drawing.Size(189, 24);
            this.textNoteCollocutor.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Hitap Edilen :";
            // 
            // maskedDate
            // 
            this.maskedDate.Location = new System.Drawing.Point(81, 66);
            this.maskedDate.Mask = "00/00/0000";
            this.maskedDate.Name = "maskedDate";
            this.maskedDate.Size = new System.Drawing.Size(206, 21);
            this.maskedDate.TabIndex = 2;
            this.maskedDate.ValidatingType = typeof(System.DateTime);
            // 
            // textNoteId
            // 
            this.textNoteId.Location = new System.Drawing.Point(80, 36);
            this.textNoteId.Name = "textNoteId";
            this.textNoteId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNoteId.Properties.Appearance.Options.UseFont = true;
            this.textNoteId.Size = new System.Drawing.Size(206, 24);
            this.textNoteId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.clearButton);
            this.groupControl1.Controls.Add(this.textNoteOwner);
            this.groupControl1.Controls.Add(this.maskedTime);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.updateButton);
            this.groupControl1.Controls.Add(this.deleteButton);
            this.groupControl1.Controls.Add(this.saveButton);
            this.groupControl1.Controls.Add(this.textNote);
            this.groupControl1.Controls.Add(this.textTitle);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textNoteCollocutor);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.maskedDate);
            this.groupControl1.Controls.Add(this.textNoteId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1625, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(300, 1058);
            this.groupControl1.TabIndex = 5;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNoteOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNoteCollocutor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNoteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton clearButton;
        private DevExpress.XtraEditors.TextEdit textNoteOwner;
        private System.Windows.Forms.MaskedTextBox maskedTime;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private System.Windows.Forms.RichTextBox textNote;
        private DevExpress.XtraEditors.TextEdit textTitle;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textNoteCollocutor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox maskedDate;
        private DevExpress.XtraEditors.TextEdit textNoteId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}