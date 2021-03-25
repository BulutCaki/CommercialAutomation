
namespace CommercialAutomation
{
    partial class Bankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bankalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDistrict = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textAccountType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.update = new DevExpress.XtraEditors.SimpleButton();
            this.delete = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textBankBranchName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textBankName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textBankId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textIBAN = new DevExpress.XtraEditors.TextEdit();
            this.textAccountCode = new DevExpress.XtraEditors.TextEdit();
            this.reloadButton = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.maskedDate = new System.Windows.Forms.MaskedTextBox();
            this.textCommisionerName = new DevExpress.XtraEditors.TextEdit();
            this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankBranchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textIBAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommisionerName.Properties)).BeginInit();
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
            this.gridControl1.Size = new System.Drawing.Size(1650, 1058);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clearButton
            // 
            this.clearButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearButton.Appearance.Options.UseFont = true;
            this.clearButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.ImageOptions.Image")));
            this.clearButton.Location = new System.Drawing.Point(72, 538);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(114, 36);
            this.clearButton.TabIndex = 30;
            this.clearButton.Text = "Temizle";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Location = new System.Drawing.Point(99, 185);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDistrict.Properties.Appearance.Options.UseFont = true;
            this.cmbDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDistrict.Size = new System.Drawing.Size(148, 24);
            this.cmbDistrict.TabIndex = 29;
            // 
            // cmbCity
            // 
            this.cmbCity.Location = new System.Drawing.Point(99, 156);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCity.Properties.Appearance.Options.UseFont = true;
            this.cmbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCity.Size = new System.Drawing.Size(148, 24);
            this.cmbCity.TabIndex = 28;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // textAccountType
            // 
            this.textAccountType.Location = new System.Drawing.Point(99, 332);
            this.textAccountType.Name = "textAccountType";
            this.textAccountType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAccountType.Properties.Appearance.Options.UseFont = true;
            this.textAccountType.Size = new System.Drawing.Size(147, 24);
            this.textAccountType.TabIndex = 23;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(43, 357);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 18);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Firma :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(3, 329);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(87, 18);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Hesap Türü :";
            // 
            // update
            // 
            this.update.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update.Appearance.Options.UseFont = true;
            this.update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("update.ImageOptions.Image")));
            this.update.Location = new System.Drawing.Point(72, 454);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(114, 36);
            this.update.TabIndex = 21;
            this.update.Text = "Güncelle";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete.Appearance.Options.UseFont = true;
            this.delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("delete.ImageOptions.Image")));
            this.delete.Location = new System.Drawing.Point(72, 496);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(114, 36);
            this.delete.TabIndex = 20;
            this.delete.Text = "Sil";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.Location = new System.Drawing.Point(72, 412);
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
            this.labelControl7.Location = new System.Drawing.Point(59, 184);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 18);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "İlçe :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(51, 158);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 18);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Şehir :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(47, 299);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(43, 18);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "Tarih :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(44, 268);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Yetkili :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(16, 244);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Hesap No :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(46, 218);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "IBAN :";
            // 
            // textBankBranchName
            // 
            this.textBankBranchName.Location = new System.Drawing.Point(101, 100);
            this.textBankBranchName.Name = "textBankBranchName";
            this.textBankBranchName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBankBranchName.Properties.Appearance.Options.UseFont = true;
            this.textBankBranchName.Size = new System.Drawing.Size(147, 24);
            this.textBankBranchName.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(56, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Şube :";
            // 
            // textBankName
            // 
            this.textBankName.Location = new System.Drawing.Point(100, 70);
            this.textBankName.Name = "textBankName";
            this.textBankName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBankName.Properties.Appearance.Options.UseFont = true;
            this.textBankName.Size = new System.Drawing.Size(147, 24);
            this.textBankName.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Banka Adı :";
            // 
            // textBankId
            // 
            this.textBankId.Location = new System.Drawing.Point(100, 40);
            this.textBankId.Name = "textBankId";
            this.textBankId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBankId.Properties.Appearance.Options.UseFont = true;
            this.textBankId.Size = new System.Drawing.Size(147, 24);
            this.textBankId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(72, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textIBAN);
            this.groupControl1.Controls.Add(this.textAccountCode);
            this.groupControl1.Controls.Add(this.reloadButton);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.maskedDate);
            this.groupControl1.Controls.Add(this.textCommisionerName);
            this.groupControl1.Controls.Add(this.PhoneNumber);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.clearButton);
            this.groupControl1.Controls.Add(this.cmbDistrict);
            this.groupControl1.Controls.Add(this.cmbCity);
            this.groupControl1.Controls.Add(this.textAccountType);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.update);
            this.groupControl1.Controls.Add(this.delete);
            this.groupControl1.Controls.Add(this.saveButton);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textBankBranchName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textBankName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textBankId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1656, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(269, 1058);
            this.groupControl1.TabIndex = 5;
            // 
            // textIBAN
            // 
            this.textIBAN.Location = new System.Drawing.Point(99, 215);
            this.textIBAN.Name = "textIBAN";
            this.textIBAN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textIBAN.Properties.Appearance.Options.UseFont = true;
            this.textIBAN.Size = new System.Drawing.Size(147, 24);
            this.textIBAN.TabIndex = 38;
            // 
            // textAccountCode
            // 
            this.textAccountCode.Location = new System.Drawing.Point(98, 245);
            this.textAccountCode.Name = "textAccountCode";
            this.textAccountCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAccountCode.Properties.Appearance.Options.UseFont = true;
            this.textAccountCode.Size = new System.Drawing.Size(147, 24);
            this.textAccountCode.TabIndex = 37;
            // 
            // reloadButton
            // 
            this.reloadButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reloadButton.Appearance.Options.UseFont = true;
            this.reloadButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("reloadButton.ImageOptions.Image")));
            this.reloadButton.Location = new System.Drawing.Point(101, 580);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(38, 36);
            this.reloadButton.TabIndex = 36;
            this.reloadButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(98, 362);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Lütfen Bir Seçim Yapınız.";
            this.lookUpEdit1.Size = new System.Drawing.Size(147, 24);
            this.lookUpEdit1.TabIndex = 35;
            // 
            // maskedDate
            // 
            this.maskedDate.Location = new System.Drawing.Point(99, 305);
            this.maskedDate.Mask = "00/00/0000";
            this.maskedDate.Name = "maskedDate";
            this.maskedDate.Size = new System.Drawing.Size(147, 21);
            this.maskedDate.TabIndex = 34;
            this.maskedDate.ValidatingType = typeof(System.DateTime);
            // 
            // textCommisionerName
            // 
            this.textCommisionerName.Location = new System.Drawing.Point(98, 275);
            this.textCommisionerName.Name = "textCommisionerName";
            this.textCommisionerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textCommisionerName.Properties.Appearance.Options.UseFont = true;
            this.textCommisionerName.Size = new System.Drawing.Size(147, 24);
            this.textCommisionerName.TabIndex = 33;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(101, 129);
            this.PhoneNumber.Mask = "(999) 000-0000";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(147, 21);
            this.PhoneNumber.TabIndex = 32;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(37, 129);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(59, 18);
            this.labelControl12.TabIndex = 31;
            this.labelControl12.Text = "Telefon :";
            // 
            // Bankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Bankalar";
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.Bankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankBranchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textIBAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommisionerName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton clearButton;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDistrict;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCity;
        private DevExpress.XtraEditors.TextEdit textAccountType;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton update;
        private DevExpress.XtraEditors.SimpleButton delete;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textBankBranchName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textBankName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textBankId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.MaskedTextBox maskedDate;
        private DevExpress.XtraEditors.TextEdit textCommisionerName;
        private System.Windows.Forms.MaskedTextBox PhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton reloadButton;
        private DevExpress.XtraEditors.TextEdit textIBAN;
        private DevExpress.XtraEditors.TextEdit textAccountCode;
    }
}