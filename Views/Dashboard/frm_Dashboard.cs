using System;
using System.Windows.Forms;

namespace PubsCRUD.Views.Dashboard
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void administrarAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Views.frm_Authors());
        }

        /*
                private void frm_Dashboard_Load(object sender, EventArgs e)
                {
                    lblBienvenida.Text = "Bienvenido al Sistema Pubs";
                }
                */

        private void administrarEditoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Views.frm_Publishers());
        }

        private void administrarTítulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Views.frm_Titles());
        }

        private void administrarTiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Views.frm_Stores());
        }

        private void administrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Views.frm_Employees());
        }

        private void administrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Views.frm_Sales());
        }

        private void administrarEmpleosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Views.frm_Jobs());
        }

        private void administrarDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Views.frm_Discounts());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método genérico para abrir formularios dentro del panel contenedor
        private void AbrirFormulario(Form formHijo)
        {
            if (this.pnlContenido.Controls.Count > 0)
                this.pnlContenido.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(formHijo);
            this.pnlContenido.Tag = formHijo;
            formHijo.Show();
        }
    }
}
