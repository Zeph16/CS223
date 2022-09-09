using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProdMgmtMSSQL.models
{
    internal class DB
    {
        static SqlConnection con;


        public static bool Initialize()
        {
            try
            {
                con = new SqlConnection("server =.; database = WinForms; Integrated security = true;");
                con.Open();
                MessageBox.Show("The Database WinForms exists");
                con.Close();
                return true;
            }
            catch
            {
                try
                {
                    con = new SqlConnection("server =.; database = master; Integrated security = true;");
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Make sure you have MSSQL Server installed and running on this system.");
                    return false;
                }
                
                string query = "CREATE Database WinForms";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Database WinForms Created Successfully");
                }
                catch (SqlException e)
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
                        "Price float," +
                        "Date nvarchar(50)," +
                        "Shipping nvarchar(10))";
                cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Products table created in WinForms");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Table Creation Failed\n" + ex.Message);
                    con.ChangeDatabase("master");
                    query = "DROP DATABASE WinForms";
                    cmd = new SqlCommand(query, con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't rollback changes, manually drop the WinForms database " +
                                        "before running MSSQL storage again to avoid runtime complications.");
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
            SqlCommand cmd;

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
            cmd = new SqlCommand("INSERT INTO Products VALUES ('" + product.Number + "', '" + product.Name + "'," +
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
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public static bool Update(Prod product)
        {
            string shipping = null;
            SqlCommand cmd;

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
            cmd = new SqlCommand("UPDATE PRODUCTS SET Name = '" + product.Name + "'," +
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
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool Delete(Prod product)
        {
            SqlCommand cmd;

            cmd = new SqlCommand("DELETE FROM PRODUCTS WHERE InventoryNumber = '" + product.InvNum + "'", con);
            try
            {
                con.Open();
                con.ChangeDatabase("WinForms");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted from the Database");
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static List<Prod> Retrieve()
        {
            SqlCommand cmd;
            SqlDataReader sdr;
            List<Prod> plist = new List<Prod>();

            cmd = new SqlCommand("SELECT * FROM PRODUCTS", con);
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

                con.Close();
                //MessageBox.Show("Retrieved from the Database");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return plist;
        }

        public static void Test()
        {
            try
            {
                con.Open();
                con.ChangeDatabase("WinForms");
                MessageBox.Show("Connection Open!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
        }
    }
}
