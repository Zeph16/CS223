using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProdMgmtMYSQL.models;

namespace ProdMgmtMYSQL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            if (!DB.Initialize())
                throw new Exception();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MdiForm mdiForm = new MdiForm(txt_user.Text);
            mdiForm.Show();
            this.Hide();
        }
    }
}
