using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFirstGUI.models
{
    internal class Prod
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int InvNum { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public string Date { get; set; }

        public void save()
        {
            MessageBox.Show("Product Number: " + Number + "\n" +
                            "Product Inventory Number: " + InvNum + "\n" +
                            "Product Name: " + Name + "\n" +
                            "Product Count: " + Count + "\n" +
                            "Product Price: " + Price + "\n" +
                            "Date: " + Date + "\n\n" +
                            "\tProduct Added!"
                            );
        }

    }
}
