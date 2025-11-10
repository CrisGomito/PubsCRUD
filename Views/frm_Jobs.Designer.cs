namespace PubsCRUD.Views
{
    partial class frm_Jobs
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
            dgvJobs = new DataGridView();
            lblJobId = new Label();
            lblJobDesc = new Label();
            lblMinLvl = new Label();
            lblMaxLvl = new Label();
            txtJobId = new TextBox();
            txtJobDesc = new TextBox();
            txtMinLvl = new TextBox();
            txtMaxLvl = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(253, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de Puestos de Trabajo";
            // 
            // dgvJobs
            // 
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(25, 260);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.Size = new Size(760, 250);
            dgvJobs.TabIndex = 1;
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Location = new Point(25, 80);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(42, 15);
            lblJobId.TabIndex = 2;
            lblJobId.Text = "Job ID:";
            // 
            // lblJobDesc
            // 
            lblJobDesc.AutoSize = true;
            lblJobDesc.Location = new Point(25, 110);
            lblJobDesc.Name = "lblJobDesc";
            lblJobDesc.Size = new Size(72, 15);
            lblJobDesc.TabIndex = 3;
            lblJobDesc.Text = "Descripción:";
            // 
            // lblMinLvl
            // 
            lblMinLvl.AutoSize = true;
            lblMinLvl.Location = new Point(25, 140);
            lblMinLvl.Name = "lblMinLvl";
            lblMinLvl.Size = new Size(82, 15);
            lblMinLvl.TabIndex = 4;
            lblMinLvl.Text = "Nivel Mínimo:";
            // 
            // lblMaxLvl
            // 
            lblMaxLvl.AutoSize = true;
            lblMaxLvl.Location = new Point(25, 170);
            lblMaxLvl.Name = "lblMaxLvl";
            lblMaxLvl.Size = new Size(84, 15);
            lblMaxLvl.TabIndex = 5;
            lblMaxLvl.Text = "Nivel Máximo:";
            // 
            // txtJobId
            // 
            txtJobId.Location = new Point(150, 80);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(200, 23);
            txtJobId.TabIndex = 6;
            // 
            // txtJobDesc
            // 
            txtJobDesc.Location = new Point(150, 110);
            txtJobDesc.Name = "txtJobDesc";
            txtJobDesc.Size = new Size(400, 23);
            txtJobDesc.TabIndex = 7;
            // 
            // txtMinLvl
            // 
            txtMinLvl.Location = new Point(150, 140);
            txtMinLvl.Name = "txtMinLvl";
            txtMinLvl.Size = new Size(200, 23);
            txtMinLvl.TabIndex = 8;
            // 
            // txtMaxLvl
            // 
            txtMaxLvl.Location = new Point(150, 170);
            txtMaxLvl.Name = "txtMaxLvl";
            txtMaxLvl.Size = new Size(200, 23);
            txtMaxLvl.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(25, 210);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 35);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(150, 210);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 35);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(275, 210);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(400, 210);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            // 
            // frm_Jobs
            // 
            ClientSize = new Size(820, 540);
            Controls.Add(lblTitle);
            Controls.Add(dgvJobs);
            Controls.Add(lblJobId);
            Controls.Add(lblJobDesc);
            Controls.Add(lblMinLvl);
            Controls.Add(lblMaxLvl);
            Controls.Add(txtJobId);
            Controls.Add(txtJobDesc);
            Controls.Add(txtMinLvl);
            Controls.Add(txtMaxLvl);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frm_Jobs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Puestos de Trabajo";
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Label lblJobDesc;
        private System.Windows.Forms.Label lblMinLvl;
        private System.Windows.Forms.Label lblMaxLvl;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.TextBox txtJobDesc;
        private System.Windows.Forms.TextBox txtMinLvl;
        private System.Windows.Forms.TextBox txtMaxLvl;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}