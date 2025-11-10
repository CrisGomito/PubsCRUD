namespace PubsCRUD.Views
{
    partial class frm_Authors
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
            lblAuthorId = new Label();
            txtAuthorId = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblState = new Label();
            txtState = new TextBox();
            lblZip = new Label();
            txtZip = new TextBox();
            dgvAuthors = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();
            // 
            // lblAuthorId
            // 
            lblAuthorId.AutoSize = true;
            lblAuthorId.Location = new Point(105, 33);
            lblAuthorId.Name = "lblAuthorId";
            lblAuthorId.Size = new Size(86, 25);
            lblAuthorId.TabIndex = 0;
            lblAuthorId.Text = "Autor ID:";
            // 
            // txtAuthorId
            // 
            txtAuthorId.BackColor = Color.White;
            txtAuthorId.Location = new Point(205, 30);
            txtAuthorId.Name = "txtAuthorId";
            txtAuthorId.ReadOnly = true;
            txtAuthorId.Size = new Size(150, 32);
            txtAuthorId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(105, 68);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(85, 25);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "Nombre:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(205, 65);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(220, 32);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(105, 103);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 25);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Apellido:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(205, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(220, 32);
            txtLastName.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(105, 138);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(88, 25);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Teléfono:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(205, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(220, 32);
            txtPhone.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(105, 173);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(96, 25);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(205, 170);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(348, 32);
            txtAddress.TabIndex = 9;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(105, 208);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(76, 25);
            lblCity.TabIndex = 10;
            lblCity.Text = "Ciudad:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(205, 205);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 32);
            txtCity.TabIndex = 11;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(375, 208);
            lblState.Name = "lblState";
            lblState.Size = new Size(72, 25);
            lblState.TabIndex = 12;
            lblState.Text = "Estado:";
            // 
            // txtState
            // 
            txtState.Location = new Point(453, 208);
            txtState.Name = "txtState";
            txtState.Size = new Size(100, 32);
            txtState.TabIndex = 13;
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(573, 211);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(43, 25);
            lblZip.TabIndex = 14;
            lblZip.Text = "Zip:";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(613, 208);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(100, 32);
            txtZip.TabIndex = 15;
            // 
            // dgvAuthors
            // 
            dgvAuthors.AllowUserToAddRows = false;
            dgvAuthors.AllowUserToDeleteRows = false;
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(105, 263);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.ReadOnly = true;
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.Size = new Size(700, 200);
            dgvAuthors.TabIndex = 16;
            dgvAuthors.CellClick += dgvAuthors_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(105, 483);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 40);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(308, 483);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 40);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(494, 483);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 40);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(714, 483);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 40);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frm_Authors
            // 
            ClientSize = new Size(942, 550);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvAuthors);
            Controls.Add(txtZip);
            Controls.Add(lblZip);
            Controls.Add(txtState);
            Controls.Add(lblState);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtAuthorId);
            Controls.Add(lblAuthorId);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Authors";
            Text = "Gestión de Autores";
            Load += frm_Authors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblAuthorId;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}