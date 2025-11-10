using PubsCRUD.Controllers;
using PubsCRUD.Models;
using PubsCRUD.Views.Dashboard;
using System;
using System.Windows.Forms;

namespace PubsCRUD.Views
{
    public partial class frm_Login : Form
    {
        private Login_Controller loginController = new Login_Controller();

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User_Model user = new User_Model(txtUsuario.Text, txtContrasena.Text);

            string mensaje;
            bool acceso = loginController.IntentarLogin(user, out mensaje);
            MessageBox.Show(mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (acceso)
            {
                this.Hide();
                frm_Dashboard dashboard = new frm_Dashboard();
                dashboard.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
