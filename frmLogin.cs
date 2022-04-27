using System;
using System.Windows.Forms;

namespace Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUser.Text.Trim() == "admin" && txtPass.Text.Trim() == "admin")
            {
                MessageBox.Show("Login success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtUser.Text = "";
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
