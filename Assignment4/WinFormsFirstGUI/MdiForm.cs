using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFirstGUI
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
            AddProductForm addProductForm = new(user);
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
            ViewProductForm viewProductForm = new();
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
            this.Close();
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
    }
}
