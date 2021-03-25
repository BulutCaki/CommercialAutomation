
namespace CommercialAutomation
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.products = new DevExpress.XtraBars.BarButtonItem();
            this.stock = new DevExpress.XtraBars.BarButtonItem();
            this.customers = new DevExpress.XtraBars.BarButtonItem();
            this.companies = new DevExpress.XtraBars.BarButtonItem();
            this.homePage = new DevExpress.XtraBars.BarButtonItem();
            this.personnels = new DevExpress.XtraBars.BarButtonItem();
            this.expenses = new DevExpress.XtraBars.BarButtonItem();
            this.safe = new DevExpress.XtraBars.BarButtonItem();
            this.notes = new DevExpress.XtraBars.BarButtonItem();
            this.banks = new DevExpress.XtraBars.BarButtonItem();
            this.guide = new DevExpress.XtraBars.BarButtonItem();
            this.bills = new DevExpress.XtraBars.BarButtonItem();
            this.settings = new DevExpress.XtraBars.BarButtonItem();
            this.Actions = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.products,
            this.stock,
            this.customers,
            this.companies,
            this.homePage,
            this.personnels,
            this.expenses,
            this.safe,
            this.notes,
            this.banks,
            this.guide,
            this.bills,
            this.settings,
            this.Actions,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1924, 150);
            // 
            // products
            // 
            this.products.Caption = "ÜRÜNLER";
            this.products.Id = 1;
            this.products.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("products.ImageOptions.Image")));
            this.products.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("products.ImageOptions.LargeImage")));
            this.products.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.products.ItemAppearance.Normal.Options.UseFont = true;
            this.products.Name = "products";
            this.products.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.products_ItemClick);
            // 
            // stock
            // 
            this.stock.Caption = "STOKLAR";
            this.stock.Id = 2;
            this.stock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stock.ImageOptions.Image")));
            this.stock.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("stock.ImageOptions.LargeImage")));
            this.stock.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stock.ItemAppearance.Normal.Options.UseFont = true;
            this.stock.Name = "stock";
            this.stock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stock_ItemClick);
            // 
            // customers
            // 
            this.customers.Caption = "MÜŞTERİLER";
            this.customers.Id = 3;
            this.customers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("customers.ImageOptions.Image")));
            this.customers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("customers.ImageOptions.LargeImage")));
            this.customers.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customers.ItemAppearance.Normal.Options.UseFont = true;
            this.customers.Name = "customers";
            this.customers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.customers_ItemClick);
            // 
            // companies
            // 
            this.companies.Caption = "FİRMALAR";
            this.companies.Id = 4;
            this.companies.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("companies.ImageOptions.Image")));
            this.companies.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("companies.ImageOptions.LargeImage")));
            this.companies.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companies.ItemAppearance.Normal.Options.UseFont = true;
            this.companies.Name = "companies";
            this.companies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.companies_ItemClick);
            // 
            // homePage
            // 
            this.homePage.Caption = "ANA SAYFA";
            this.homePage.Id = 5;
            this.homePage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("homePage.ImageOptions.Image")));
            this.homePage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("homePage.ImageOptions.LargeImage")));
            this.homePage.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homePage.ItemAppearance.Normal.Options.UseFont = true;
            this.homePage.Name = "homePage";
            this.homePage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.homePage_ItemClick);
            // 
            // personnels
            // 
            this.personnels.Caption = "PERSONELLER";
            this.personnels.Id = 6;
            this.personnels.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("personnels.ImageOptions.Image")));
            this.personnels.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("personnels.ImageOptions.LargeImage")));
            this.personnels.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personnels.ItemAppearance.Normal.Options.UseFont = true;
            this.personnels.Name = "personnels";
            this.personnels.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // expenses
            // 
            this.expenses.Caption = "GİDERLER";
            this.expenses.Id = 7;
            this.expenses.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("expenses.ImageOptions.Image")));
            this.expenses.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("expenses.ImageOptions.LargeImage")));
            this.expenses.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.expenses.ItemAppearance.Normal.Options.UseFont = true;
            this.expenses.Name = "expenses";
            this.expenses.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.expenses_ItemClick);
            // 
            // safe
            // 
            this.safe.Caption = "KASA";
            this.safe.Id = 8;
            this.safe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("safe.ImageOptions.Image")));
            this.safe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("safe.ImageOptions.LargeImage")));
            this.safe.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.safe.ItemAppearance.Normal.Options.UseFont = true;
            this.safe.Name = "safe";
            this.safe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.safe_ItemClick);
            // 
            // notes
            // 
            this.notes.Caption = "NOTLAR";
            this.notes.Id = 9;
            this.notes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("notes.ImageOptions.Image")));
            this.notes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("notes.ImageOptions.LargeImage")));
            this.notes.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notes.ItemAppearance.Normal.Options.UseFont = true;
            this.notes.Name = "notes";
            this.notes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.notes_ItemClick);
            // 
            // banks
            // 
            this.banks.Caption = "BANKALAR";
            this.banks.Id = 11;
            this.banks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("banks.ImageOptions.Image")));
            this.banks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("banks.ImageOptions.LargeImage")));
            this.banks.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.banks.ItemAppearance.Normal.Options.UseFont = true;
            this.banks.Name = "banks";
            this.banks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // guide
            // 
            this.guide.Caption = "REHBER";
            this.guide.Id = 12;
            this.guide.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guide.ImageOptions.Image")));
            this.guide.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("guide.ImageOptions.LargeImage")));
            this.guide.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guide.ItemAppearance.Normal.Options.UseFont = true;
            this.guide.Name = "guide";
            this.guide.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.guide_ItemClick);
            // 
            // bills
            // 
            this.bills.Caption = "FATURALAR";
            this.bills.Id = 13;
            this.bills.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bills.ImageOptions.Image")));
            this.bills.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bills.ImageOptions.LargeImage")));
            this.bills.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bills.ItemAppearance.Normal.Options.UseFont = true;
            this.bills.Name = "bills";
            this.bills.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bills_ItemClick);
            // 
            // settings
            // 
            this.settings.Caption = "AYARLAR";
            this.settings.Id = 15;
            this.settings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("settings.ImageOptions.Image")));
            this.settings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("settings.ImageOptions.LargeImage")));
            this.settings.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settings.ItemAppearance.Normal.Options.UseFont = true;
            this.settings.Name = "settings";
            this.settings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.settings_ItemClick);
            // 
            // Actions
            // 
            this.Actions.Caption = "HAREKETLER";
            this.Actions.Id = 16;
            this.Actions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Actions.ImageOptions.Image")));
            this.Actions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Actions.ImageOptions.LargeImage")));
            this.Actions.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Actions.ItemAppearance.Normal.Options.UseFont = true;
            this.Actions.Name = "Actions";
            this.Actions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Actions_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "RAPORLAR";
            this.barButtonItem2.Id = 17;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ticari Otomasyon Sistemi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.homePage);
            this.ribbonPageGroup1.ItemLinks.Add(this.products);
            this.ribbonPageGroup1.ItemLinks.Add(this.stock);
            this.ribbonPageGroup1.ItemLinks.Add(this.customers);
            this.ribbonPageGroup1.ItemLinks.Add(this.companies);
            this.ribbonPageGroup1.ItemLinks.Add(this.personnels);
            this.ribbonPageGroup1.ItemLinks.Add(this.expenses);
            this.ribbonPageGroup1.ItemLinks.Add(this.safe);
            this.ribbonPageGroup1.ItemLinks.Add(this.notes);
            this.ribbonPageGroup1.ItemLinks.Add(this.banks);
            this.ribbonPageGroup1.ItemLinks.Add(this.guide);
            this.ribbonPageGroup1.ItemLinks.Add(this.bills);
            this.ribbonPageGroup1.ItemLinks.Add(this.Actions);
            this.ribbonPageGroup1.ItemLinks.Add(this.settings);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem products;
        private DevExpress.XtraBars.BarButtonItem stock;
        private DevExpress.XtraBars.BarButtonItem customers;
        private DevExpress.XtraBars.BarButtonItem companies;
        private DevExpress.XtraBars.BarButtonItem homePage;
        private DevExpress.XtraBars.BarButtonItem personnels;
        private DevExpress.XtraBars.BarButtonItem expenses;
        private DevExpress.XtraBars.BarButtonItem safe;
        private DevExpress.XtraBars.BarButtonItem notes;
        private DevExpress.XtraBars.BarButtonItem banks;
        private DevExpress.XtraBars.BarButtonItem guide;
        private DevExpress.XtraBars.BarButtonItem bills;
        private DevExpress.XtraBars.BarButtonItem settings;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem Actions;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}

