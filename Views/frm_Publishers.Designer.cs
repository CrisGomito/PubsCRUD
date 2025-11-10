namespace PubsCRUD.Views
{
    partial class frm_Publishers
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
            lblTitulo = new Label();
            lblPubId = new Label();
            lblPubName = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblCountry = new Label();
            txtPubId = new TextBox();
            txtPubName = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtCountry = new TextBox();
            dgvPublishers = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPublishers).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(276, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Editores";
            // 
            // lblPubId
            // 
            lblPubId.AutoSize = true;
            lblPubId.Font = new Font("Segoe UI", 14F);
            lblPubId.Location = new Point(42, 79);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(72, 25);
            lblPubId.TabIndex = 1;
            lblPubId.Text = "Pub ID:";
            // 
            // lblPubName
            // 
            lblPubName.AutoSize = true;
            lblPubName.Font = new Font("Segoe UI", 14F);
            lblPubName.Location = new Point(38, 134);
            lblPubName.Name = "lblPubName";
            lblPubName.Size = new Size(85, 25);
            lblPubName.TabIndex = 3;
            lblPubName.Text = "Nombre:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 14F);
            lblCity.Location = new Point(38, 195);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(76, 25);
            lblCity.TabIndex = 5;
            lblCity.Text = "Ciudad:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 14F);
            lblState.Location = new Point(450, 76);
            lblState.Name = "lblState";
            lblState.Size = new Size(72, 25);
            lblState.TabIndex = 7;
            lblState.Text = "Estado:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 14F);
            lblCountry.Location = new Point(450, 141);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(49, 25);
            lblCountry.TabIndex = 9;
            lblCountry.Text = "País:";
            // 
            // txtPubId
            // 
            txtPubId.Font = new Font("Segoe UI", 14F);
            txtPubId.Location = new Point(132, 76);
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(200, 32);
            txtPubId.TabIndex = 2;
            // 
            // txtPubName
            // 
            txtPubName.Font = new Font("Segoe UI", 14F);
            txtPubName.Location = new Point(129, 134);
            txtPubName.Name = "txtPubName";
            txtPubName.Size = new Size(250, 32);
            txtPubName.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 14F);
            txtCity.Location = new Point(132, 192);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(250, 32);
            txtCity.TabIndex = 6;
            // 
            // txtState
            // 
            txtState.Font = new Font("Segoe UI", 14F);
            txtState.Location = new Point(558, 79);
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 32);
            txtState.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 14F);
            txtCountry.Location = new Point(555, 134);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(153, 32);
            txtCountry.TabIndex = 10;
            // 
            // dgvPublishers
            // 
            dgvPublishers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublishers.Location = new Point(43, 259);
            dgvPublishers.Name = "dgvPublishers";
            dgvPublishers.Size = new Size(712, 205);
            dgvPublishers.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.Location = new Point(172, 480);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 35);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 14F);
            btnEditar.Location = new Point(282, 480);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 35);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14F);
            btnEliminar.Location = new Point(392, 480);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14F);
            btnLimpiar.Location = new Point(502, 480);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frm_Publishers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 527);
            Controls.Add(lblTitulo);
            Controls.Add(lblPubId);
            Controls.Add(txtPubId);
            Controls.Add(lblPubName);
            Controls.Add(txtPubName);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(lblState);
            Controls.Add(txtState);
            Controls.Add(lblCountry);
            Controls.Add(txtCountry);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvPublishers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Publishers";
            Text = "Gestión de Editores";
            ((System.ComponentModel.ISupportInitialize)dgvPublishers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPubId;
        private Label lblPubName;
        private Label lblCity;
        private Label lblState;
        private Label lblCountry;
        private TextBox txtPubId;
        private TextBox txtPubName;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtCountry;
        private DataGridView dgvPublishers;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}