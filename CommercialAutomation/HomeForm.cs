using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        HomePageForm homePageForm;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (homePageForm == null || homePageForm.IsDisposed)
            {
                homePageForm = new HomePageForm();
                homePageForm.MdiParent = this;
                homePageForm.Show();
            }
        }
        PersonnelsForm personnelsForm;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personnelsForm == null || personnelsForm.IsDisposed)
            {
                personnelsForm = new PersonnelsForm();
                personnelsForm.MdiParent = this;
                personnelsForm.Show();
            }
        }
        Bankalar banksForm;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (banksForm == null || banksForm.IsDisposed)
            {
                banksForm = new Bankalar();
                banksForm.MdiParent = this;
                banksForm.Show();
            }
        }
        ProductsForm productsform;
        private void products_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            if (productsform == null || productsform.IsDisposed)
            {
                productsform = new ProductsForm();
                productsform.MdiParent = this;
                productsform.Show();
            }
        }
        CustomersForm customersForm;
        private void customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customersForm == null || customersForm.IsDisposed)
            {
                customersForm = new CustomersForm();
                customersForm.MdiParent = this;
                customersForm.Show();
            }
        }
        CompaniesForm companiesForm;
        private void companies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (companiesForm == null || companiesForm.IsDisposed)
            {
                companiesForm = new CompaniesForm();
                companiesForm.MdiParent = this;
                companiesForm.Show();
            }
        }
        GuideForm guideForm;
        private void guide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (guideForm == null || guideForm.IsDisposed)
            {
                guideForm = new GuideForm();
                guideForm.MdiParent = this;
                guideForm.Show();
            }
        }
        ExpensesForm expensesForm;
        private void expenses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (expensesForm == null || expensesForm.IsDisposed)
            {
                expensesForm = new ExpensesForm();
                expensesForm.MdiParent = this;
                expensesForm.Show();
            }
        }
        BillsForm billsForm;
        private void bills_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (billsForm == null || billsForm.IsDisposed)
            {
                billsForm = new BillsForm();
                billsForm.MdiParent = this;
                billsForm.Show();
            }
        }
        NotesForm notesForm;
        private void notes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (notesForm == null || notesForm.IsDisposed)
            {
                notesForm = new NotesForm();
                notesForm.MdiParent = this;
                notesForm.Show();
            }
        }
        ActionsForm actionsForm;
        private void Actions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (actionsForm == null || actionsForm.IsDisposed)
            {
                actionsForm = new ActionsForm();
                actionsForm.MdiParent = this;
                actionsForm.Show();
            }
        }
        StockForm stockForm;
        private void stock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stockForm == null || stockForm.IsDisposed)
            {
                stockForm = new StockForm();
                stockForm.MdiParent = this;
                stockForm.Show();
            }
        }
        SettingsForm settingsForm;
        private void settings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new SettingsForm();
                settingsForm.Show();
            }
        }
        SafeForm safeForm;
        private void safe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (safeForm == null || safeForm.IsDisposed)
            {
                safeForm = new SafeForm();
                safeForm.MdiParent = this;
                safeForm.Show();
            }
        }
        
        private void homePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (homePageForm == null || homePageForm.IsDisposed)
            {
                homePageForm = new HomePageForm();
                homePageForm.MdiParent = this;
                homePageForm.Show();
            }
        }
    }
}
