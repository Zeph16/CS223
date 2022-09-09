using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdMgmtMYSQL
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var bottomLeft = new Point(e.CellBounds.Left, e.CellBounds.Bottom);
            var bottomRight = new Point(e.CellBounds.Right, e.CellBounds.Bottom);
            Pen p = new Pen(Color.WhiteSmoke, (float)1.5);
            e.Graphics.DrawLine(p, bottomLeft, bottomRight);
        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var bottomLeft = new Point(e.CellBounds.Left, e.CellBounds.Bottom);
            var bottomRight = new Point(e.CellBounds.Right, e.CellBounds.Bottom);
            Pen p = new Pen(Color.WhiteSmoke, (float)1.5);
            e.Graphics.DrawLine(p, bottomLeft, bottomRight);
        }

        private void tableLayoutPanel3_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var bottomLeft = new Point(e.CellBounds.Left, e.CellBounds.Bottom);
            var bottomRight = new Point(e.CellBounds.Right, e.CellBounds.Bottom);
            Pen p = new Pen(Color.WhiteSmoke, (float)1.5);
            e.Graphics.DrawLine(p, bottomLeft, bottomRight);
        }

        private void tableLayoutPanel4_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var bottomLeft = new Point(e.CellBounds.Left, e.CellBounds.Bottom);
            var bottomRight = new Point(e.CellBounds.Right, e.CellBounds.Bottom);
            Pen p = new Pen(Color.WhiteSmoke, (float)1.5);
            e.Graphics.DrawLine(p, bottomLeft, bottomRight);
        }
    }
}
