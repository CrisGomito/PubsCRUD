namespace PubsCRUD.Views
{
    partial class frm_Titles
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
            lblTitleId = new Label();
            txtTitleId = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblType = new Label();
            cbType = new ComboBox();
            lblPubId = new Label();
            cbPubId = new ComboBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblAdvance = new Label();
            txtAdvance = new TextBox();
            lblRoyalty = new Label();
            txtRoyalty = new TextBox();
            lblYtd = new Label();
            txtYtd = new TextBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            lblPubDate = new Label();
            dtpPubDate = new DateTimePicker();
            dgvTitles = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTitles).BeginInit();
            SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblTituloPrincipal.Location = new Point(396, 13);
            lblTituloPrincipal.Margin = new Padding(5, 0, 5, 0);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(161, 24);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Gestión de Títulos";
            // 
            // lblTitleId
            // 
            lblTitleId.AutoSize = true;
            lblTitleId.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblTitleId.Location = new Point(38, 77);
            lblTitleId.Margin = new Padding(5, 0, 5, 0);
            lblTitleId.Name = "lblTitleId";
            lblTitleId.Size = new Size(78, 24);
            lblTitleId.TabIndex = 1;
            lblTitleId.Text = "Título ID";
            // 
            // txtTitleId
            // 
            txtTitleId.Font = new Font("Segoe UI", 10F);
            txtTitleId.Location = new Point(128, 74);
            txtTitleId.Margin = new Padding(5, 4, 5, 4);
            txtTitleId.Name = "txtTitleId";
            txtTitleId.Size = new Size(281, 25);
            txtTitleId.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblTitle.Location = new Point(38, 132);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(61, 24);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Título:";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(128, 128);
            txtTitle.Margin = new Padding(5, 4, 5, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(281, 25);
            txtTitle.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblType.Location = new Point(38, 187);
            lblType.Margin = new Padding(5, 0, 5, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(53, 24);
            lblType.TabIndex = 5;
            lblType.Text = "Tipo:";
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.Font = new Font("Segoe UI", 10F);
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "UNDECIDED", "TRADITIONAL", "MODERN", "EDUCATIONAL", "CHILDREN" });
            cbType.Location = new Point(128, 186);
            cbType.Margin = new Padding(5, 4, 5, 4);
            cbType.Name = "cbType";
            cbType.Size = new Size(281, 25);
            cbType.TabIndex = 6;
            // 
            // lblPubId
            // 
            lblPubId.AutoSize = true;
            lblPubId.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblPubId.Location = new Point(503, 81);
            lblPubId.Margin = new Padding(5, 0, 5, 0);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(86, 24);
            lblPubId.TabIndex = 7;
            lblPubId.Text = "Editor ID:";
            // 
            // cbPubId
            // 
            cbPubId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPubId.Font = new Font("Segoe UI", 10F);
            cbPubId.FormattingEnabled = true;
            cbPubId.Location = new Point(691, 76);
            cbPubId.Margin = new Padding(5, 4, 5, 4);
            cbPubId.Name = "cbPubId";
            cbPubId.Size = new Size(218, 25);
            cbPubId.TabIndex = 8;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblPrice.Location = new Point(503, 132);
            lblPrice.Margin = new Padding(5, 0, 5, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 24);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Precio:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(691, 128);
            txtPrice.Margin = new Padding(5, 4, 5, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(218, 25);
            txtPrice.TabIndex = 10;
            // 
            // lblAdvance
            // 
            lblAdvance.AutoSize = true;
            lblAdvance.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblAdvance.Location = new Point(503, 184);
            lblAdvance.Margin = new Padding(5, 0, 5, 0);
            lblAdvance.Name = "lblAdvance";
            lblAdvance.Size = new Size(83, 24);
            lblAdvance.TabIndex = 11;
            lblAdvance.Text = "Anticipo:";
            // 
            // txtAdvance
            // 
            txtAdvance.Font = new Font("Segoe UI", 10F);
            txtAdvance.Location = new Point(691, 179);
            txtAdvance.Margin = new Padding(5, 4, 5, 4);
            txtAdvance.Name = "txtAdvance";
            txtAdvance.Size = new Size(218, 25);
            txtAdvance.TabIndex = 12;
            // 
            // lblRoyalty
            // 
            lblRoyalty.AutoSize = true;
            lblRoyalty.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblRoyalty.Location = new Point(38, 238);
            lblRoyalty.Margin = new Padding(5, 0, 5, 0);
            lblRoyalty.Name = "lblRoyalty";
            lblRoyalty.Size = new Size(87, 24);
            lblRoyalty.TabIndex = 13;
            lblRoyalty.Text = "Regalías:";
            // 
            // txtRoyalty
            // 
            txtRoyalty.Font = new Font("Segoe UI", 10F);
            txtRoyalty.Location = new Point(128, 237);
            txtRoyalty.Margin = new Padding(5, 4, 5, 4);
            txtRoyalty.Name = "txtRoyalty";
            txtRoyalty.Size = new Size(281, 25);
            txtRoyalty.TabIndex = 14;
            // 
            // lblYtd
            // 
            lblYtd.AutoSize = true;
            lblYtd.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblYtd.Location = new Point(503, 235);
            lblYtd.Margin = new Padding(5, 0, 5, 0);
            lblYtd.Name = "lblYtd";
            lblYtd.Size = new Size(159, 24);
            lblYtd.TabIndex = 15;
            lblYtd.Text = "YTD Ventas (Ytd):";
            // 
            // txtYtd
            // 
            txtYtd.Font = new Font("Segoe UI", 10F);
            txtYtd.Location = new Point(691, 231);
            txtYtd.Margin = new Padding(5, 4, 5, 4);
            txtYtd.Name = "txtYtd";
            txtYtd.Size = new Size(218, 25);
            txtYtd.TabIndex = 16;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblNotes.Location = new Point(38, 289);
            lblNotes.Margin = new Padding(5, 0, 5, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(63, 24);
            lblNotes.TabIndex = 17;
            lblNotes.Text = "Notas:";
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 10F);
            txtNotes.Location = new Point(128, 288);
            txtNotes.Margin = new Padding(5, 4, 5, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(281, 53);
            txtNotes.TabIndex = 18;
            // 
            // lblPubDate
            // 
            lblPubDate.AutoSize = true;
            lblPubDate.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblPubDate.Location = new Point(503, 287);
            lblPubDate.Margin = new Padding(5, 0, 5, 0);
            lblPubDate.Name = "lblPubDate";
            lblPubDate.Size = new Size(172, 24);
            lblPubDate.TabIndex = 19;
            lblPubDate.Text = "Fecha Publicación:";
            // 
            // dtpPubDate
            // 
            dtpPubDate.Font = new Font("Microsoft Sans Serif", 14.25F);
            dtpPubDate.Format = DateTimePickerFormat.Short;
            dtpPubDate.Location = new Point(691, 282);
            dtpPubDate.Margin = new Padding(5, 4, 5, 4);
            dtpPubDate.Name = "dtpPubDate";
            dtpPubDate.Size = new Size(218, 29);
            dtpPubDate.TabIndex = 20;
            // 
            // dgvTitles
            // 
            dgvTitles.AllowUserToAddRows = false;
            dgvTitles.AllowUserToDeleteRows = false;
            dgvTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitles.Location = new Point(38, 350);
            dgvTitles.Margin = new Padding(5, 4, 5, 4);
            dgvTitles.Name = "dgvTitles";
            dgvTitles.ReadOnly = true;
            dgvTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTitles.Size = new Size(871, 159);
            dgvTitles.TabIndex = 21;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnAgregar.Location = new Point(38, 517);
            btnAgregar.Margin = new Padding(5, 4, 5, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(173, 53);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnEditar.Location = new Point(298, 517);
            btnEditar.Margin = new Padding(5, 4, 5, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(173, 53);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnEliminar.Location = new Point(523, 517);
            btnEliminar.Margin = new Padding(5, 4, 5, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(173, 53);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnLimpiar.Location = new Point(736, 517);
            btnLimpiar.Margin = new Padding(5, 4, 5, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(173, 53);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frm_Titles
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 583);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvTitles);
            Controls.Add(dtpPubDate);
            Controls.Add(lblPubDate);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(txtYtd);
            Controls.Add(lblYtd);
            Controls.Add(txtRoyalty);
            Controls.Add(lblRoyalty);
            Controls.Add(txtAdvance);
            Controls.Add(lblAdvance);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(cbPubId);
            Controls.Add(lblPubId);
            Controls.Add(cbType);
            Controls.Add(lblType);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(txtTitleId);
            Controls.Add(lblTitleId);
            Controls.Add(lblTituloPrincipal);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frm_Titles";
            Text = "Gestión de Títulos";
            ((System.ComponentModel.ISupportInitialize)dgvTitles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label lblTitleId;
        private System.Windows.Forms.TextBox txtTitleId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblPubId;
        private System.Windows.Forms.ComboBox cbPubId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label lblRoyalty;
        private System.Windows.Forms.TextBox txtRoyalty;
        private System.Windows.Forms.Label lblYtd;
        private System.Windows.Forms.TextBox txtYtd;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblPubDate;
        private System.Windows.Forms.DateTimePicker dtpPubDate;
        private System.Windows.Forms.DataGridView dgvTitles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}