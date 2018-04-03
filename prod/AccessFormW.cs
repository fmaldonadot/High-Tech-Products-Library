using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_Tech_Products_Library
{
    public partial class AccessFormW : Form
    {
        public AccessFormW()
        {
            InitializeComponent();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            HighTechForm f = new HighTechForm();

           if (txtLogin.Text == "admin")
                if (txtPass.Text == "123")
                    f.ShowDialog();
                else
                    MessageBox.Show("Wrong Password", "Access Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Wrong User Name", "Access Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AccessFormW_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titlelab_Click(object sender, EventArgs e)
        {

        }
    }
}
