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
    public partial class DetailsForm : Form
    {
        public MdiForm parent { get; set; }
        public Prod p { get; set; }
        public DetailsForm(Prod p, MdiForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.p = p;
            string numprefix = "";
            string invprefix = "";
            for (int i = p.Number; i < 100; i *= 10)
                numprefix += "0";
            for (int i = p.InvNum; i < 100; i *= 10)
                invprefix += "0";

            lbl_details.Text += p.Name;
            lbl_num.Text = "PRD-" + numprefix + p.Number.ToString();
            lbl_invnum.Text = "INV-" + invprefix + p.InvNum.ToString();
            lbl_price.Text = p.Price.ToString();
            lbl_count.Text = p.Count.ToString();
            lbl_date.Text = p.Date.ToString();
            if (p.truck)
                lbl_shipping.Text = "Truck";
            else if (p.plane)
                lbl_shipping.Text = "Plane";
            else if (p.ship)
                lbl_shipping.Text = "Cargo Ship";
            else
                lbl_shipping.Text = "None";

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tableLayoutPanel1_CellPaint_1(object sender, TableLayoutCellPaintEventArgs e)
        {
            var bottomLeft = new Point(e.CellBounds.Left, e.CellBounds.Bottom);
            var bottomRight = new Point(e.CellBounds.Right, e.CellBounds.Bottom);
            Pen p = new Pen(Color.WhiteSmoke, (float)1.5);
            e.Graphics.DrawLine(p, bottomLeft, bottomRight);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            parent.EditProduct(p);
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DB.Delete(p);
            this.Close();
            parent.RefreshView();
        }
    }
}
