
using System.Runtime.InteropServices;

namespace PubsCRUD.Views.Dashboard
{
    public partial class frm_Dashboard : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void administrarAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Views.frm_Authors());
        }

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

        private void AbrirFormulario(Form formHijo)
        {
            lblBienvenida.Visible = false;

            ReleaseCapture();

            if (this.pnlContenido.Controls.Count > 0)
            {
                var actual = this.pnlContenido.Controls[0] as Form;
                if (actual != null)
                {
                    try
                    {
                        actual.Close();
                        actual.Dispose();
                    }
                    catch { /* ignorar errores de cierre */ }
                }
                this.pnlContenido.Controls.Clear();
            }
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(formHijo);
            this.pnlContenido.Tag = formHijo;
            formHijo.Show();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "¡Bienvenido al Sistema Pubs!";
            lblBienvenida.Visible = true;
        }
    }
}
