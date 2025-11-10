namespace PubsCRUD.Views
{
    partial class frm_Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvEmployees = new DataGridView();
            lblEmpId = new Label();
            lblFname = new Label();
            lblMinit = new Label();
            lblLname = new Label();
            lblJobId = new Label();
            lblJobLvl = new Label();
            lblPubId = new Label();
            lblHireDate = new Label();
            txtEmpId = new TextBox();
            txtFname = new TextBox();
            txtMinit = new TextBox();
            txtLname = new TextBox();
            txtJobId = new TextBox();
            txtJobLvl = new TextBox();
            txtPubId = new TextBox();
            dtpHireDate = new DateTimePicker();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(275, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de Empleados";
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(25, 310);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(783, 212);
            dgvEmployees.TabIndex = 1;
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Font = new Font("Segoe UI", 14F);
            lblEmpId.Location = new Point(25, 80);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(123, 25);
            lblEmpId.TabIndex = 2;
            lblEmpId.Text = "Empleado ID:";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Segoe UI", 14F);
            lblFname.Location = new Point(26, 129);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(85, 25);
            lblFname.TabIndex = 3;
            lblFname.Text = "Nombre:";
            // 
            // lblMinit
            // 
            lblMinit.AutoSize = true;
            lblMinit.Font = new Font("Segoe UI", 14F);
            lblMinit.Location = new Point(25, 222);
            lblMinit.Name = "lblMinit";
            lblMinit.Size = new Size(60, 25);
            lblMinit.TabIndex = 4;
            lblMinit.Text = "Minit:";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Segoe UI", 14F);
            lblLname.Location = new Point(25, 177);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(86, 25);
            lblLname.TabIndex = 5;
            lblLname.Text = "Apellido:";
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Font = new Font("Segoe UI", 14F);
            lblJobId.Location = new Point(404, 80);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(102, 25);
            lblJobId.TabIndex = 6;
            lblJobId.Text = "Empleo ID:";
            // 
            // lblJobLvl
            // 
            lblJobLvl.AutoSize = true;
            lblJobLvl.Font = new Font("Segoe UI", 14F);
            lblJobLvl.Location = new Point(404, 129);
            lblJobLvl.Name = "lblJobLvl";
            lblJobLvl.Size = new Size(153, 25);
            lblJobLvl.TabIndex = 7;
            lblJobLvl.Text = "Nivel de Empleo:";
            // 
            // lblPubId
            // 
            lblPubId.AutoSize = true;
            lblPubId.Font = new Font("Segoe UI", 14F);
            lblPubId.Location = new Point(400, 176);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(133, 25);
            lblPubId.TabIndex = 8;
            lblPubId.Text = "Publicación ID";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Segoe UI", 14F);
            lblHireDate.Location = new Point(404, 222);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(179, 25);
            lblHireDate.TabIndex = 9;
            lblHireDate.Text = "Fecha Contratación:";
            // 
            // txtEmpId
            // 
            txtEmpId.Font = new Font("Segoe UI", 14F);
            txtEmpId.Location = new Point(150, 80);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(200, 32);
            txtEmpId.TabIndex = 10;
            // 
            // txtFname
            // 
            txtFname.Font = new Font("Segoe UI", 14F);
            txtFname.Location = new Point(150, 126);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(200, 32);
            txtFname.TabIndex = 11;
            // 
            // txtMinit
            // 
            txtMinit.Font = new Font("Segoe UI", 14F);
            txtMinit.Location = new Point(150, 174);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(200, 32);
            txtMinit.TabIndex = 12;
            // 
            // txtLname
            // 
            txtLname.Font = new Font("Segoe UI", 14F);
            txtLname.Location = new Point(150, 219);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(200, 32);
            txtLname.TabIndex = 13;
            // 
            // txtJobId
            // 
            txtJobId.Font = new Font("Segoe UI", 14F);
            txtJobId.Location = new Point(583, 77);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(200, 32);
            txtJobId.TabIndex = 14;
            // 
            // txtJobLvl
            // 
            txtJobLvl.Font = new Font("Segoe UI", 14F);
            txtJobLvl.Location = new Point(583, 126);
            txtJobLvl.Name = "txtJobLvl";
            txtJobLvl.Size = new Size(200, 32);
            txtJobLvl.TabIndex = 15;
            // 
            // txtPubId
            // 
            txtPubId.Font = new Font("Segoe UI", 14F);
            txtPubId.Location = new Point(583, 174);
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(200, 32);
            txtPubId.TabIndex = 16;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Font = new Font("Segoe UI", 14F);
            dtpHireDate.Location = new Point(583, 222);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(200, 32);
            dtpHireDate.TabIndex = 17;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.Location = new Point(25, 533);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 35);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 14F);
            btnEditar.Location = new Point(231, 533);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 35);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14F);
            btnEliminar.Location = new Point(430, 533);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14F);
            btnLimpiar.Location = new Point(708, 533);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            // 
            // frm_Employees
            // 
            ClientSize = new Size(840, 580);
            Controls.Add(lblTitle);
            Controls.Add(dgvEmployees);
            Controls.Add(lblEmpId);
            Controls.Add(lblFname);
            Controls.Add(lblMinit);
            Controls.Add(lblLname);
            Controls.Add(lblJobId);
            Controls.Add(lblJobLvl);
            Controls.Add(lblPubId);
            Controls.Add(lblHireDate);
            Controls.Add(txtEmpId);
            Controls.Add(txtFname);
            Controls.Add(txtMinit);
            Controls.Add(txtLname);
            Controls.Add(txtJobId);
            Controls.Add(txtJobLvl);
            Controls.Add(txtPubId);
            Controls.Add(dtpHireDate);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frm_Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Empleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblMinit;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Label lblJobLvl;
        private System.Windows.Forms.Label lblPubId;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMinit;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.TextBox txtJobLvl;
        private System.Windows.Forms.TextBox txtPubId;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}