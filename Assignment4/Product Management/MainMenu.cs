namespace Product_Management
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void btn_mssql_Click(object sender, EventArgs e)
        {
            lbl_status.Text = "Initializing MSSQL Database...";
            try
            {
                ProdMgmtMSSQL.LoginForm mssql = new ProdMgmtMSSQL.LoginForm();
                mssql.Show();
                this.Hide();
            }
            catch
            {
                lbl_status.Text = "MSSQL initialization failed.";
                return;
            }
        }
        private void btn_mysql_Click(object sender, EventArgs e)
        {
            lbl_status.Text = "Initializing MySQL Database...";
            try
            {
                ProdMgmtMYSQL.LoginForm mysql = new ProdMgmtMYSQL.LoginForm();
                mysql.Show();
                this.Hide();
            }
            catch
            {
                lbl_status.Text = "MySQL initialization failed.";
                return;
            }
        }
        private void btn_ram_Click(object sender, EventArgs e)
        {
            ProdMgmtRAM.LoginForm mssql = new ProdMgmtRAM.LoginForm();
            mssql.Show();
            this.Hide();
        }

        private void btn_mssql_MouseEnter(object sender, EventArgs e)
        {
            btn_mssql.Size = new Size(btn_mssql.Width + 4, btn_mssql.Height + 4);
            btn_mssql.Top = btn_mssql.Top - 2;
            btn_mssql.Left = btn_mssql.Left - 2;
        }

        private void btn_mssql_MouseLeave(object sender, EventArgs e)
        {
            btn_mssql.Size = new Size(btn_mssql.Width - 4, btn_mssql.Height - 4);
            btn_mssql.Top = btn_mssql.Top + 2;
            btn_mssql.Left = btn_mssql.Left + 2;
        }

        private void btn_mysql_MouseEnter(object sender, EventArgs e)
        {
            btn_mysql.Size = new Size(btn_mysql.Width + 4, btn_mysql.Height + 4);
            btn_mysql.Top = btn_mysql.Top - 2;
            btn_mysql.Left = btn_mysql.Left - 2;
        }

        private void btn_mysql_MouseLeave(object sender, EventArgs e)
        {
            btn_mysql.Size = new Size(btn_mysql.Width - 4, btn_mysql.Height - 4);
            btn_mysql.Top = btn_mysql.Top + 2;
            btn_mysql.Left = btn_mysql.Left + 2;
        }

        

        private void btn_ram_MouseEnter(object sender, EventArgs e)
        {
            btn_ram.Size = new Size(btn_ram.Width + 4, btn_ram.Height + 4);
            btn_ram.Top = btn_ram.Top - 2;
            btn_ram.Left = btn_ram.Left - 2;
        }

        private void btn_ram_MouseLeave(object sender, EventArgs e)
        {
            btn_ram.Size = new Size(btn_ram.Width - 4, btn_ram.Height - 4);
            btn_ram.Top = btn_ram.Top + 2;
            btn_ram.Left = btn_ram.Left + 2;
        }

        
    }
}