using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFirstGUI.models
{
    internal class Prod
    {
        private static List<Prod> p = new List<Prod>() {
            new Prod() {
                Number = 1, Name = "Television", InvNum = 421, Count = 15, Price = 50000, 
                Date = DateTime.Today.ToString(), shipping = false, ship = false, plane = false, truck = false
            },
            new Prod()
            {
                Number = 2, Name = "Lamp", InvNum = 422, Count = 51, Price = 500,
                Date = DateTime.Today.ToString(), shipping = false, ship = false, plane = false, truck = false
            },
            new Prod()
            {
                Number = 3, Name = "Camera", InvNum = 423, Count = 151, Price = 5000,
                Date = DateTime.Today.ToString(), shipping = false, ship = false, plane = false, truck = false
            },
            new Prod()
            {
                Number = 4, Name = "Calculator", InvNum = 424, Count = 515, Price = 50,
                Date = DateTime.Today.ToString(), shipping = false, ship = false, plane = false, truck = false
            }
        };
        public int Number { get; set; }
        public string Name { get; set; }
        public int InvNum { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public string Date { get; set; }
        public bool shipping { get; set; }
        public bool ship { get; set; }
        public bool plane { get; set; }
        public bool truck { get; set; }

        public void Save()
        {
            MessageBox.Show("Product Number: " + Number + "\n" +
                            "Product Inventory Number: " + InvNum + "\n" +
                            "Product Name: " + Name + "\n" +
                            "Product Count: " + Count + "\n" +
                            "Product Price: " + Price + "\n" +
                            "Date: " + Date + "\n\n" +
                            "\tProduct Added!"
                            );
            p.Add(this);
        }
        static public List<Prod> GetProducts()
        {
            return p;
        }
        public static List<Prod> lookFor(string name)
        {
            return p.FindAll(match => match.Name == name);
        }

    }
}
