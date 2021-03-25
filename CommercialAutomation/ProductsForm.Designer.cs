
namespace CommercialAutomation
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.updateProduct = new DevExpress.XtraEditors.SimpleButton();
            this.deleteProduct = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.textProductDetails = new System.Windows.Forms.RichTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textBuyingPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.nudProductAmount = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textProductModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textProductBrand = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.maskedProductYear = new System.Windows.Forms.MaskedTextBox();
            this.textProductId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.clearButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBuyingPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1669, 1059);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.clearButton);
            this.groupControl1.Controls.Add(this.updateProduct);
            this.groupControl1.Controls.Add(this.deleteProduct);
            this.groupControl1.Controls.Add(this.saveButton);
            this.groupControl1.Controls.Add(this.textProductDetails);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.textSalePrice);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.textBuyingPrice);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.nudProductAmount);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textProductModel);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textProductBrand);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textProductName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.maskedProductYear);
            this.groupControl1.Controls.Add(this.textProductId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1667, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(257, 1059);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // updateProduct
            // 
            this.updateProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateProduct.Appearance.Options.UseFont = true;
            this.updateProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateProduct.ImageOptions.Image")));
            this.updateProduct.Location = new System.Drawing.Point(49, 421);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(114, 28);
            this.updateProduct.TabIndex = 21;
            this.updateProduct.Text = "Güncelle";
            this.updateProduct.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteProduct.Appearance.Options.UseFont = true;
            this.deleteProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteProduct.ImageOptions.Image")));
            this.deleteProduct.Location = new System.Drawing.Point(49, 455);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(114, 28);
            this.deleteProduct.TabIndex = 20;
            this.deleteProduct.Text = "Sil";
            this.deleteProduct.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.Location = new System.Drawing.Point(49, 387);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 28);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Kaydet";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textProductDetails
            // 
            this.textProductDetails.Location = new System.Drawing.Point(79, 281);
            this.textProductDetails.Name = "textProductDetails";
            this.textProductDetails.Size = new System.Drawing.Size(147, 85);
            this.textProductDetails.TabIndex = 18;
            this.textProductDetails.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(24, 280);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 18);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Detay :";
            // 
            // textSalePrice
            // 
            this.textSalePrice.Location = new System.Drawing.Point(79, 247);
            this.textSalePrice.Name = "textSalePrice";
            this.textSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSalePrice.Properties.Appearance.Options.UseFont = true;
            this.textSalePrice.Size = new System.Drawing.Size(147, 24);
            this.textSalePrice.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(8, 250);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 18);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Satış Fiyat";
            // 
            // textBuyingPrice
            // 
            this.textBuyingPrice.Location = new System.Drawing.Point(79, 217);
            this.textBuyingPrice.Name = "textBuyingPrice";
            this.textBuyingPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBuyingPrice.Properties.Appearance.Options.UseFont = true;
            this.textBuyingPrice.Size = new System.Drawing.Size(147, 24);
            this.textBuyingPrice.TabIndex = 14;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(8, 223);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(66, 18);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "Alış Fiyat :";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(33, 199);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Adet :";
            // 
            // nudProductAmount
            // 
            this.nudProductAmount.Location = new System.Drawing.Point(79, 196);
            this.nudProductAmount.Name = "nudProductAmount";
            this.nudProductAmount.Size = new System.Drawing.Size(147, 21);
            this.nudProductAmount.TabIndex = 11;
            this.nudProductAmount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(49, 172);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Yıl :";
            // 
            // textProductModel
            // 
            this.textProductModel.Location = new System.Drawing.Point(79, 143);
            this.textProductModel.Name = "textProductModel";
            this.textProductModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textProductModel.Properties.Appearance.Options.UseFont = true;
            this.textProductModel.Size = new System.Drawing.Size(147, 24);
            this.textProductModel.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 140);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Model :";
            // 
            // textProductBrand
            // 
            this.textProductBrand.Location = new System.Drawing.Point(79, 113);
            this.textProductBrand.Name = "textProductBrand";
            this.textProductBrand.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textProductBrand.Properties.Appearance.Options.UseFont = true;
            this.textProductBrand.Size = new System.Drawing.Size(147, 24);
            this.textProductBrand.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Marka :";
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(79, 83);
            this.textProductName.Name = "textProductName";
            this.textProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textProductName.Properties.Appearance.Options.UseFont = true;
            this.textProductName.Size = new System.Drawing.Size(147, 24);
            this.textProductName.TabIndex = 4;
            this.textProductName.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ürün Adı :";
            // 
            // maskedProductYear
            // 
            this.maskedProductYear.Location = new System.Drawing.Point(79, 173);
            this.maskedProductYear.Mask = "0000";
            this.maskedProductYear.Name = "maskedProductYear";
            this.maskedProductYear.Size = new System.Drawing.Size(147, 21);
            this.maskedProductYear.TabIndex = 2;
            this.maskedProductYear.ValidatingType = typeof(int);
            // 
            // textProductId
            // 
            this.textProductId.Location = new System.Drawing.Point(79, 53);
            this.textProductId.Name = "textProductId";
            this.textProductId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textProductId.Properties.Appearance.Options.UseFont = true;
            this.textProductId.Size = new System.Drawing.Size(147, 24);
            this.textProductId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(49, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id :";
            // 
            // clearButton
            // 
            this.clearButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearButton.Appearance.Options.UseFont = true;
            this.clearButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.ImageOptions.Image")));
            this.clearButton.Location = new System.Drawing.Point(49, 489);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(114, 36);
            this.clearButton.TabIndex = 34;
            this.clearButton.Text = "Temizle";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.productsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBuyingPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textProductId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textProductName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox maskedProductYear;
        private DevExpress.XtraEditors.TextEdit textProductId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textSalePrice;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textBuyingPrice;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.NumericUpDown nudProductAmount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textProductModel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textProductBrand;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.RichTextBox textProductDetails;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton updateProduct;
        private DevExpress.XtraEditors.SimpleButton deleteProduct;
        private DevExpress.XtraEditors.SimpleButton clearButton;
    }
}