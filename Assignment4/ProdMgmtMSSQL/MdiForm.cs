using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProdMgmtMSSQL.models;

namespace ProdMgmtMSSQL
{
    public partial class MdiForm : Form
    {
        public string user { get; set; }
        public MdiForm(string name)
        {
            InitializeComponent();
            
            user = name;
            this.Text = "Product Management - " + user;
            HelpForm helpForm = new();
            helpForm.MdiParent = this;
            helpForm.Dock = DockStyle.Fill;
            helpForm.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            AddProductForm addProductForm = new(null, true, this);
            addProductForm.MdiParent = this;
            addProductForm.Dock = DockStyle.Fill;
            addProductForm.Show();
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren)
            {
                f.Close();
            }
            ViewProductForm viewProductForm = new(this);
            viewProductForm.MdiParent = this;
            viewProductForm.Dock = DockStyle.Fill;
            viewProductForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren)
            {
                f.Close();
            }
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in MdiChildren)
            {
                f.Close();
            }
            HelpForm helpForm = new();
            helpForm.MdiParent = this;
            helpForm.Dock = DockStyle.Fill;
            helpForm.Show();
        }

        public void ShowDetails(Prod obj)
        {
            DetailsForm details = new DetailsForm(obj, this);
            details.MdiParent = this;
            details.Dock = DockStyle.Fill;
            details.Show();
        }
        
        public void EditProduct(Prod obj)
        {
            AddProductForm addProductForm = new(obj, false, this);
            addProductForm.MdiParent = this;
            addProductForm.Dock = DockStyle.Fill;
            addProductForm.Show();
        }

        public void RefreshView()
        {
            foreach (var f in MdiChildren)
            {
                f.Close();
            }
            ViewProductForm viewProductForm = new(this);
            viewProductForm.MdiParent = this;
            viewProductForm.Dock = DockStyle.Fill;
            viewProductForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
