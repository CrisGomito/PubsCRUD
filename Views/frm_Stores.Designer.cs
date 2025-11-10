namespace PubsCRUD.Views
{
    partial class frm_Stores
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
            lblTituloPrincipal = new Label();
            lblStoreId = new Label();
            txtStoreId = new TextBox();
            lblStoreName = new Label();
            txtStoreName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblState = new Label();
            txtState = new TextBox();
            lblZip = new Label();
            txtZip = new TextBox();
            dgvStores = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStores).BeginInit();
            SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloPrincipal.Location = new Point(320, 18);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(180, 25);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Gestión de Tiendas";
            // 
            // lblStoreId
            // 
            lblStoreId.AutoSize = true;
            lblStoreId.Font = new Font("Segoe UI", 14.25F);
            lblStoreId.Location = new Point(66, 79);
            lblStoreId.Name = "lblStoreId";
            lblStoreId.Size = new Size(96, 25);
            lblStoreId.TabIndex = 1;
            lblStoreId.Text = "Tienda ID:";
            // 
            // txtStoreId
            // 
            txtStoreId.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtStoreId.Location = new Point(194, 79);
            txtStoreId.Name = "txtStoreId";
            txtStoreId.Size = new Size(180, 29);
            txtStoreId.TabIndex = 2;
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Font = new Font("Segoe UI", 14.25F);
            lblStoreName.Location = new Point(66, 114);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(85, 25);
            lblStoreName.TabIndex = 3;
            lblStoreName.Text = "Nombre:";
            // 
            // txtStoreName
            // 
            txtStoreName.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtStoreName.Location = new Point(194, 114);
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Size = new Size(460, 29);
            txtStoreName.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 14.25F);
            lblAddress.Location = new Point(66, 149);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(96, 25);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtAddress.Location = new Point(194, 149);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(460, 29);
            txtAddress.TabIndex = 6;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 14.25F);
            lblCity.Location = new Point(66, 184);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(76, 25);
            lblCity.TabIndex = 7;
            lblCity.Text = "Ciudad:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtCity.Location = new Point(194, 184);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(180, 29);
            txtCity.TabIndex = 8;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 14.25F);
            lblState.Location = new Point(390, 188);
            lblState.Name = "lblState";
            lblState.Size = new Size(72, 25);
            lblState.TabIndex = 9;
            lblState.Text = "Estado:";
            lblState.Click += lblState_Click;
            // 
            // txtState
            // 
            txtState.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtState.Location = new Point(484, 184);
            txtState.Name = "txtState";
            txtState.Size = new Size(170, 29);
            txtState.TabIndex = 10;
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Font = new Font("Segoe UI", 14.25F);
            lblZip.Location = new Point(66, 219);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(107, 25);
            lblZip.TabIndex = 11;
            lblZip.Text = "Código zip:";
            // 
            // txtZip
            // 
            txtZip.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtZip.Location = new Point(194, 219);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(180, 29);
            txtZip.TabIndex = 12;
            // 
            // dgvStores
            // 
            dgvStores.AllowUserToAddRows = false;
            dgvStores.AllowUserToDeleteRows = false;
            dgvStores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStores.Location = new Point(64, 282);
            dgvStores.Name = "dgvStores";
            dgvStores.ReadOnly = true;
            dgvStores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStores.Size = new Size(623, 201);
            dgvStores.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.Location = new Point(138, 512);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 36);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 14F);
            btnEditar.Location = new Point(264, 512);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 36);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14F);
            btnEliminar.Location = new Point(390, 512);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 36);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14F);
            btnLimpiar.Location = new Point(516, 512);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 36);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frm_Stores
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 580);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvStores);
            Controls.Add(txtZip);
            Controls.Add(lblZip);
            Controls.Add(txtState);
            Controls.Add(lblState);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtStoreName);
            Controls.Add(lblStoreName);
            Controls.Add(txtStoreId);
            Controls.Add(lblStoreId);
            Controls.Add(lblTituloPrincipal);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Stores";
            Text = "Gestión de Tiendas";
            ((System.ComponentModel.ISupportInitialize)dgvStores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label lblStoreId;
        private System.Windows.Forms.TextBox txtStoreId;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}