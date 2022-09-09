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
using ProdMgmtMYSQL.models;

namespace ProdMgmtMYSQL
{
    public partial class ViewProductForm : Form
    {
        public MdiForm parent { get; set; }
        public ViewProductForm(MdiForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            List<Prod> plist = Prod.GetProducts();
            foreach (var p in plist)
            {
                ProductCard pcard = new ProductCard(parent);
                pcard.name = p.Name;
                pcard.price = p.Price.ToString();
                pcard.obj = p;
                panel.Controls.Add(pcard);
            }
        }

        public void Repopulate(List<Prod> plist = null)
        {
            if (plist == null)
                plist = DB.Retrieve();
            panel.Controls.Clear();
            foreach (var p in plist)
            {
                ProductCard pcard = new ProductCard(parent);
                pcard.name = p.Name;
                pcard.price = p.Price.ToString();
                pcard.obj = p;
                panel.Controls.Add(pcard);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string searchString = txt_search.Text;
            if (searchString == "")
                return;

            Regex r = new Regex(@"^(?i)" + searchString);
            List<Prod> p_list = models.Prod.GetProducts().FindAll(match => r.IsMatch(match.Name));
            Repopulate(p_list);
            if (p_list.Count == 0)
                lbl_search.Text = "No results found.";
            else if (searchString.Length > 5)
                lbl_search.Text = "Search results for " + txt_search.Text.Substring(0, 5) + "...:";
            else
                lbl_search.Text = "Search results for " + txt_search.Text + ":";

            btn_showall.Visible = true;
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            Repopulate();

            lbl_search.Text = "";
            btn_showall.Visible = false;
            txt_search.Text = "";
            
        }
    }
}
