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

namespace WinFormsFirstGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Prod p = new Prod();
            try
            {
                p.Number = int.Parse(txt_num.Text);
                p.Name = txt_objname.Text;
                p.InvNum = int.Parse(txt_invnum.Text);
                p.Count = int.Parse(txt_count.Text);
                p.Price = Double.Parse(txt_price.Text);
                p.Date = dt_date.Text;
                p.save();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                txt_num.Text = "";
                txt_objname.Text = "";
                txt_invnum.Text = "";
                txt_count.Text = "";
                txt_price.Text = "";

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
