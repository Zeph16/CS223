using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace ProdMgmtMYSQL.models
{
    internal class DB
    {
        static MySqlConnection con;


        public static bool Initialize()
        {
            try
            {
                con = new MySqlConnection("server = localhost; database = WinForms; uid = root; pwd = root;");
                con.Open();
                MessageBox.Show("The Database WinForms exists");
                con.Close();
                return true;
            }
            catch
            {
                try
                {
                    con = new MySqlConnection("server = localhost; database = mysql; uid = root; pwd = root;");
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Make sure you have MySQL Server installed and running on this system.");
                    return false;
                }
                string query = "CREATE Database WinForms;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Database WinForms Created Successfully");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Database creation failed");
                    con.Close();
                    return false;
                }
                con.ChangeDatabase("WinForms");
                query = "CREATE TABLE Products (" +
                        "Number int UNIQUE," +
                        "Name nvarchar(50)," +
                        "InventoryNumber int UNIQUE," +
                        "Count int," +
                        "Price double," +
                        "Date nvarchar(50)," +
                        "Shipping nvarchar(10))";
                cmd = new MySqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Products table created in WinForms");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Table Creation Failed\n" + ex.Message);
                    
                    query = "DROP DATABASE WinForms";
                    cmd = new MySqlCommand(query, con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        con.ChangeDatabase("mysql");
                        MessageBox.Show("Couldn't rollback changes, manually drop the WinForms database " +
                                        "before running MySQL storage again to avoid runtime complications.");
                    }
                    con.Close();
                    return false;
                }
                con.Close();

                Prod.Initialize();
                return true;

            }
        }

        public static bool Insert(Prod product)
        {
            string shipping = null;
            MySqlCommand cmd;

            if (product.shipping == true)
            {
                if (product.plane)
                    shipping = "Plane";
                else if (product.ship)
                    shipping = "Cargo Ship";
                else if (product.truck)
                    shipping = "Truck";
            }
            else
                shipping = "None";
            cmd = new MySqlCommand("INSERT INTO Products VALUES ('" + product.Number + "', '" + product.Name + "'," +
                                   " '" + product.InvNum + "', '" + product.Count + "', '" + product.Price + "'," +
                                   " '" + product.Date + "', '" + shipping + "')", con);

            List<Prod> prodList = DB.Retrieve();
            foreach (var p in prodList)
                if (p.InvNum == product.InvNum || p.Number == product.Number)
                    return false;

            try
            {
                con.Open();
                con.ChangeDatabase("WinForms");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Product into the Database");
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public static bool Update(Prod product)
        {
            string shipping = null;
            MySqlCommand cmd;

            if (product.shipping == true)
            {
                if (product.plane)
                    shipping = "Plane";
                else if (product.ship)
                    shipping = "Cargo Ship";
                else if (product.truck)
                    shipping = "Truck";
            }
            else
                shipping = "None";
            cmd = new MySqlCommand("UPDATE PRODUCTS SET Name = '" + product.Name + "'," +
                                    "Count = '" + product.Count + "'," +
                                    "Price = '" + product.Price + "', Date = '" + product.Date + "', Shipping = '" + shipping + "' " +
                                    "WHERE InventoryNumber = '" + product.InvNum + "'", con);
            try
            {
                con.Open();
                con.ChangeDatabase("WinForms");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated the Database");
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool Delete(Prod product)
        {
            MySqlCommand cmd;

            cmd = new MySqlCommand("DELETE FROM PRODUCTS WHERE InventoryNumber = '" + product.InvNum + "'", con);
            try
            {
                con.Open();
                con.ChangeDatabase("WinForms");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted from the Database");
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static List<Prod> Retrieve()
        {
            MySqlCommand cmd;
            MySqlDataReader sdr;
            List<Prod> plist = new List<Prod>();

            cmd = new MySqlCommand("SELECT * FROM PRODUCTS", con);
            try
            {
                con.Open();
                con.ChangeDatabase("WinForms");
                sdr = cmd.ExecuteReader();
                string ship;
                
                while (sdr.Read())
                {
                    Prod p = new Prod();
                    p.Number = (int)sdr["Number"];
                    p.InvNum = (int)sdr["InventoryNumber"];
                    p.Name = (string)sdr["Name"];
                    p.Count = (int)sdr["Count"];
                    p.Price = (double)sdr["Price"];
                    p.Date = (string)sdr["Date"];
                    ship = (string)sdr["Shipping"];
                    if (ship != "None")
                        p.shipping = true;
                    if (ship == "Truck")
                        p.truck = true;
                    else if (ship == "Plane")
                        p.plane = true;
                    else if (ship == "Cargo Ship")
                        p.ship = true;
                    plist.Add(p);
                }

                
                //MessageBox.Show("Retrieved from the Database");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            con.Close();
            return plist;
        }

        public static void Test()
        {
            try
            {
                con.Open();
                con.ChangeDatabase("WinForms");
                MessageBox.Show("Connection Open!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
            con.Close();
        }
    }
}
