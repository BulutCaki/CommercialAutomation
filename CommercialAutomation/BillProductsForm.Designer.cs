
namespace CommercialAutomation
{
    partial class BillProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillProductsForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label8 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            this.updateCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.deleteCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.textRetailPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textBilId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textProductId = new DevExpress.XtraEditors.TextEdit();
            this.label78 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textProductAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textProductModel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textProductName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbProduct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            this.label8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRetailPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBilId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(648, 713);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // label8
            // 
            this.label8.Controls.Add(this.cmbProduct);
            this.label8.Controls.Add(this.labelControl7);
            this.label8.Controls.Add(this.textProductName);
            this.label8.Controls.Add(this.textProductModel);
            this.label8.Controls.Add(this.labelControl6);
            this.label8.Controls.Add(this.simpleButton1);
            this.label8.Controls.Add(this.clearButton);
            this.label8.Controls.Add(this.updateCustomer);
            this.label8.Controls.Add(this.deleteCustomer);
            this.label8.Controls.Add(this.textRetailPrice);
            this.label8.Controls.Add(this.labelControl3);
            this.label8.Controls.Add(this.textTotalPrice);
            this.label8.Controls.Add(this.labelControl4);
            this.label8.Controls.Add(this.textBilId);
            this.label8.Controls.Add(this.labelControl5);
            this.label8.Controls.Add(this.textProductId);
            this.label8.Controls.Add(this.label78);
            this.label8.Controls.Add(this.labelControl2);
            this.label8.Controls.Add(this.textProductAmount);
            this.label8.Controls.Add(this.labelControl1);
            this.label8.Location = new System.Drawing.Point(654, 0);
            this.label8.Name = "label8";
            this.label8.ShowCaption = false;
            this.label8.Size = new System.Drawing.Size(276, 713);
            this.label8.TabIndex = 3;
            this.label8.Text = "groupControl8";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(95, 411);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(35, 37);
            this.simpleButton1.TabIndex = 40;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearButton.Appearance.Options.UseFont = true;
            this.clearButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.ImageOptions.Image")));
            this.clearButton.Location = new System.Drawing.Point(49, 368);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(146, 37);
            this.clearButton.TabIndex = 39;
            this.clearButton.Text = "Temizle";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateCustomer.Appearance.Options.UseFont = true;
            this.updateCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateCustomer.ImageOptions.Image")));
            this.updateCustomer.Location = new System.Drawing.Point(49, 284);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(146, 37);
            this.updateCustomer.TabIndex = 38;
            this.updateCustomer.Text = "Güncelle";
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteCustomer.Appearance.Options.UseFont = true;
            this.deleteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteCustomer.ImageOptions.Image")));
            this.deleteCustomer.Location = new System.Drawing.Point(49, 326);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(146, 37);
            this.deleteCustomer.TabIndex = 37;
            this.deleteCustomer.Text = "Sil";
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // textRetailPrice
            // 
            this.textRetailPrice.Location = new System.Drawing.Point(95, 184);
            this.textRetailPrice.Name = "textRetailPrice";
            this.textRetailPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textRetailPrice.Properties.Appearance.Options.UseFont = true;
            this.textRetailPrice.Size = new System.Drawing.Size(148, 24);
            this.textRetailPrice.TabIndex = 35;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(48, 187);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 18);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Fiyat :";
            // 
            // textTotalPrice
            // 
            this.textTotalPrice.Location = new System.Drawing.Point(95, 212);
            this.textTotalPrice.Name = "textTotalPrice";
            this.textTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.textTotalPrice.Size = new System.Drawing.Size(148, 24);
            this.textTotalPrice.TabIndex = 33;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(43, 218);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 18);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Tutar :";
            // 
            // textBilId
            // 
            this.textBilId.Location = new System.Drawing.Point(95, 242);
            this.textBilId.Name = "textBilId";
            this.textBilId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBilId.Properties.Appearance.Options.UseFont = true;
            this.textBilId.Size = new System.Drawing.Size(148, 24);
            this.textBilId.TabIndex = 31;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 245);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 18);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Fatura Id :";
            // 
            // textProductId
            // 
            this.textProductId.Location = new System.Drawing.Point(95, 35);
            this.textProductId.Name = "textProductId";
            this.textProductId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textProductId.Properties.Appearance.Options.UseFont = true;
            this.textProductId.Size = new System.Drawing.Size(148, 24);
            this.textProductId.TabIndex = 29;
            // 
            // label78
            // 
            this.label78.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label78.Appearance.Options.UseFont = true;
            this.label78.Location = new System.Drawing.Point(24, 38);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(65, 18);
            this.label78.TabIndex = 28;
            this.label78.Text = "Ürün Id  :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(48, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 18);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Ürün :";
            // 
            // textProductAmount
            // 
            this.textProductAmount.Location = new System.Drawing.Point(95, 154);
            this.textProductAmount.Name = "textProductAmount";
            this.textProductAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textProductAmount.Properties.Appearance.Options.UseFont = true;
            this.textProductAmount.Size = new System.Drawing.Size(148, 24);
            this.textProductAmount.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 160);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 18);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Miktar :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 127);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 18);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "Ürün Model :";
            // 
            // textProductModel
            // 
            this.textProductModel.Location = new System.Drawing.Point(95, 125);
            this.textProductModel.Name = "textProductModel";
            this.textProductModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textProductModel.Properties.Appearance.Options.UseFont = true;
            this.textProductModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textProductModel.Size = new System.Drawing.Size(148, 24);
            this.textProductModel.TabIndex = 43;
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(97, 95);
            this.textProductName.Name = "textProductName";
            this.textProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textProductName.Properties.Appearance.Options.UseFont = true;
            this.textProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textProductName.Size = new System.Drawing.Size(148, 24);
            this.textProductName.TabIndex = 44;
            this.textProductName.SelectedIndexChanged += new System.EventHandler(this.textProductName_SelectedIndexChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.Location = new System.Drawing.Point(97, 65);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProduct.Properties.Appearance.Options.UseFont = true;
            this.cmbProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProduct.Size = new System.Drawing.Size(148, 24);
            this.cmbProduct.TabIndex = 46;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(26, 98);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 18);
            this.labelControl7.TabIndex = 45;
            this.labelControl7.Text = "Ürün Adı :";
            // 
            // BillProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 717);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridControl1);
            this.Name = "BillProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturaya Ait Ürünler";
            this.Load += new System.EventHandler(this.BillProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            this.label8.ResumeLayout(false);
            this.label8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRetailPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBilId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl label8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton clearButton;
        private DevExpress.XtraEditors.SimpleButton updateCustomer;
        private DevExpress.XtraEditors.SimpleButton deleteCustomer;
        private DevExpress.XtraEditors.TextEdit textRetailPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textBilId;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textProductId;
        private DevExpress.XtraEditors.LabelControl label78;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textProductAmount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit textProductName;
        private DevExpress.XtraEditors.ComboBoxEdit textProductModel;
        private DevExpress.XtraEditors.ComboBoxEdit cmbProduct;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}