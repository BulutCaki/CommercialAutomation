
namespace CommercialAutomation
{
    partial class PersonnelsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelsForm));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cmbPersonnelDistrict = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbPersonnelCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.maskedPersonnelTc = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.updateCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.deleteCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textPersonnelEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textPersonnelLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textPersonnelFirstname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.maskedPersonelPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textPersonnelId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textPersonnelStatu = new DevExpress.XtraEditors.TextEdit();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonnelDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonnelCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelStatu.Properties)).BeginInit();
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
            this.gridControl1.Size = new System.Drawing.Size(1639, 1058);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmbPersonnelDistrict
            // 
            this.cmbPersonnelDistrict.Location = new System.Drawing.Point(105, 246);
            this.cmbPersonnelDistrict.Name = "cmbPersonnelDistrict";
            this.cmbPersonnelDistrict.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPersonnelDistrict.Properties.Appearance.Options.UseFont = true;
            this.cmbPersonnelDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPersonnelDistrict.Size = new System.Drawing.Size(148, 24);
            this.cmbPersonnelDistrict.TabIndex = 29;
            this.cmbPersonnelDistrict.SelectedIndexChanged += new System.EventHandler(this.cmbPersonnelDistrict_SelectedIndexChanged);
            // 
            // cmbPersonnelCity
            // 
            this.cmbPersonnelCity.Location = new System.Drawing.Point(104, 214);
            this.cmbPersonnelCity.Name = "cmbPersonnelCity";
            this.cmbPersonnelCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPersonnelCity.Properties.Appearance.Options.UseFont = true;
            this.cmbPersonnelCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPersonnelCity.Size = new System.Drawing.Size(148, 24);
            this.cmbPersonnelCity.TabIndex = 28;
            this.cmbPersonnelCity.SelectedIndexChanged += new System.EventHandler(this.cmbPersonnelCity_SelectedIndexChanged);
            // 
            // maskedPersonnelTc
            // 
            this.maskedPersonnelTc.Location = new System.Drawing.Point(104, 157);
            this.maskedPersonnelTc.Mask = "00000000000";
            this.maskedPersonnelTc.Name = "maskedPersonnelTc";
            this.maskedPersonnelTc.Size = new System.Drawing.Size(147, 21);
            this.maskedPersonnelTc.TabIndex = 27;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(55, 279);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(44, 18);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Statü :";
            // 
            // updateCustomer
            // 
            this.updateCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateCustomer.Appearance.Options.UseFont = true;
            this.updateCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateCustomer.ImageOptions.Image")));
            this.updateCustomer.Location = new System.Drawing.Point(71, 384);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(114, 36);
            this.updateCustomer.TabIndex = 21;
            this.updateCustomer.Text = "Güncelle";
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteCustomer.Appearance.Options.UseFont = true;
            this.deleteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteCustomer.ImageOptions.Image")));
            this.deleteCustomer.Location = new System.Drawing.Point(71, 426);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(114, 36);
            this.deleteCustomer.TabIndex = 20;
            this.deleteCustomer.Text = "Sil";
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.Location = new System.Drawing.Point(71, 342);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 36);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Kaydet";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(39, 249);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 18);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Distcrict :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(64, 219);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 18);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "City :";
            // 
            // textPersonnelEmail
            // 
            this.textPersonnelEmail.Location = new System.Drawing.Point(105, 184);
            this.textPersonnelEmail.Name = "textPersonnelEmail";
            this.textPersonnelEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPersonnelEmail.Properties.Appearance.Options.UseFont = true;
            this.textPersonnelEmail.Size = new System.Drawing.Size(147, 24);
            this.textPersonnelEmail.TabIndex = 14;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(52, 187);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 18);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "E-Mail :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(71, 156);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Tc :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = " Telefon :";
            // 
            // textPersonnelLastName
            // 
            this.textPersonnelLastName.Location = new System.Drawing.Point(105, 95);
            this.textPersonnelLastName.Name = "textPersonnelLastName";
            this.textPersonnelLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPersonnelLastName.Properties.Appearance.Options.UseFont = true;
            this.textPersonnelLastName.Size = new System.Drawing.Size(147, 24);
            this.textPersonnelLastName.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(32, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Soy İsim :";
            // 
            // textPersonnelFirstname
            // 
            this.textPersonnelFirstname.Location = new System.Drawing.Point(105, 65);
            this.textPersonnelFirstname.Name = "textPersonnelFirstname";
            this.textPersonnelFirstname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPersonnelFirstname.Properties.Appearance.Options.UseFont = true;
            this.textPersonnelFirstname.Size = new System.Drawing.Size(147, 24);
            this.textPersonnelFirstname.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(61, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "İsim :";
            // 
            // maskedPersonelPhoneNumber
            // 
            this.maskedPersonelPhoneNumber.Location = new System.Drawing.Point(105, 125);
            this.maskedPersonelPhoneNumber.Mask = "(999) 000-0000";
            this.maskedPersonelPhoneNumber.Name = "maskedPersonelPhoneNumber";
            this.maskedPersonelPhoneNumber.Size = new System.Drawing.Size(147, 21);
            this.maskedPersonelPhoneNumber.TabIndex = 2;
            // 
            // textPersonnelId
            // 
            this.textPersonnelId.Location = new System.Drawing.Point(104, 35);
            this.textPersonnelId.Name = "textPersonnelId";
            this.textPersonnelId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPersonnelId.Properties.Appearance.Options.UseFont = true;
            this.textPersonnelId.Size = new System.Drawing.Size(147, 24);
            this.textPersonnelId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(74, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.clearButton);
            this.groupControl1.Controls.Add(this.textPersonnelStatu);
            this.groupControl1.Controls.Add(this.cmbPersonnelDistrict);
            this.groupControl1.Controls.Add(this.cmbPersonnelCity);
            this.groupControl1.Controls.Add(this.maskedPersonnelTc);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.updateCustomer);
            this.groupControl1.Controls.Add(this.deleteCustomer);
            this.groupControl1.Controls.Add(this.saveButton);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.textPersonnelEmail);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textPersonnelLastName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textPersonnelFirstname);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.maskedPersonelPhoneNumber);
            this.groupControl1.Controls.Add(this.textPersonnelId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1645, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(280, 1058);
            this.groupControl1.TabIndex = 5;
            // 
            // textPersonnelStatu
            // 
            this.textPersonnelStatu.Location = new System.Drawing.Point(105, 276);
            this.textPersonnelStatu.Name = "textPersonnelStatu";
            this.textPersonnelStatu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPersonnelStatu.Properties.Appearance.Options.UseFont = true;
            this.textPersonnelStatu.Size = new System.Drawing.Size(149, 24);
            this.textPersonnelStatu.TabIndex = 30;
            // 
            // clearButton
            // 
            this.clearButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearButton.Appearance.Options.UseFont = true;
            this.clearButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.ImageOptions.Image")));
            this.clearButton.Location = new System.Drawing.Point(71, 468);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(114, 36);
            this.clearButton.TabIndex = 34;
            this.clearButton.Text = "Temizle";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PersonnelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "PersonnelsForm";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.PersonnelsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonnelDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonnelCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonnelStatu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPersonnelDistrict;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPersonnelCity;
        private System.Windows.Forms.MaskedTextBox maskedPersonnelTc;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton updateCustomer;
        private DevExpress.XtraEditors.SimpleButton deleteCustomer;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textPersonnelEmail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textPersonnelLastName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textPersonnelFirstname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox maskedPersonelPhoneNumber;
        private DevExpress.XtraEditors.TextEdit textPersonnelId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textPersonnelStatu;
        private DevExpress.XtraEditors.SimpleButton clearButton;
    }
}