using WinFormsFirstGUI.models;
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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            err.Clear();
            //Regex r = new Regex(@"^([^0-9]*)$");
            Regex r = new Regex(@"\d");

            if (string.IsNullOrEmpty(txt_num.Text) || string.IsNullOrEmpty(txt_invnum.Text) ||
                string.IsNullOrEmpty(txt_objname.Text) || string.IsNullOrEmpty(txt_count.Text) ||
                string.IsNullOrEmpty(txt_price.Text) || r.IsMatch(txt_objname.Text))
            {
                if (string.IsNullOrEmpty(txt_num.Text))
                    err.SetError(txt_num, "Number is required");
                if (string.IsNullOrEmpty(txt_invnum.Text))
                    err.SetError(txt_invnum, "Inventory Number is required");
                if (string.IsNullOrEmpty(txt_objname.Text))
                    err.SetError(txt_objname, "Object name is required");
                if (string.IsNullOrEmpty(txt_count.Text))
                    err.SetError(txt_count, "Count is required");
                if (string.IsNullOrEmpty(txt_price.Text))
                    err.SetError(txt_price, "Price is required");
                if (r.IsMatch(txt_objname.Text))
                    err.SetError(txt_objname, "Name should not include numbers");
                return;
            }

            Prod p = new Prod();
            try
            {
                p.Number = int.Parse(txt_num.Text);
                p.Name = txt_objname.Text;
                p.InvNum = int.Parse(txt_invnum.Text);
                p.Count = int.Parse(txt_count.Text);
                p.Price = Double.Parse(txt_price.Text);
                p.Date = dt_date.Text;
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
                
                return;
            }

            p.Save();
            dgv.DataSource = null;
            dgv.DataSource = Prod.GetProducts();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_num.Text = "";
            txt_objname.Text = "";
            txt_invnum.Text = "";
            txt_count.Text = "";
            txt_price.Text = "";
        }
    }
}
