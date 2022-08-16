using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsFirstGUI
{
    public partial class ViewProductForm : Form
    {
        public ViewProductForm()
        {
            InitializeComponent();
            dgv.DataSource = null;
            dgv.DataSource = models.Prod.GetProducts();
        }

        private void ViewProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string searchString = txt_search.Text;
            if (searchString == "")
                return;

            Regex r = new Regex(@"^(?i)" + searchString);
            dgv.DataSource = null;
            dgv.DataSource = models.Prod.GetProducts().FindAll(match => r.IsMatch(match.Name));
            if (searchString.Length > 5)
                lbl_search.Text = "Search results for " + txt_search.Text.Substring(0, 5) + "...:";
            else
                lbl_search.Text = "Search results for " + txt_search.Text + ":";

            btn_showall.Enabled = true;
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = models.Prod.GetProducts();

            lbl_search.Text = "";
            btn_showall.Enabled = false;
            txt_search.Text = "";
        }
    }
}
