using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsFirstGUI.models;

namespace WinFormsFirstGUI
{
    public partial class ProductCard : UserControl
    {
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; lbl_name.Text = _name; }
        }
        private string _price;

        public string price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = "$" + _price; }
        }

        public Prod obj { get; set; }
        public MdiForm parent { get; set; }


        public ProductCard(MdiForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            parent.ShowDetails(obj);
        }
    }
}
