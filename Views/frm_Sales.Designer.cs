namespace PubsCRUD.Views
{
    partial class frm_Sales
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
            dgvSales = new DataGridView();
            lblStorId = new Label();
            lblOrdNum = new Label();
            lblOrdDate = new Label();
            lblQty = new Label();
            lblPayterms = new Label();
            lblTitleId = new Label();
            txtStorId = new TextBox();
            txtOrdNum = new TextBox();
            dtpOrdDate = new DateTimePicker();
            txtQty = new TextBox();
            txtPayterms = new TextBox();
            txtTitleId = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(311, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(171, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de Ventas";
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(95, 247);
            dgvSales.Name = "dgvSales";
            dgvSales.Size = new Size(682, 220);
            dgvSales.TabIndex = 1;
            // 
            // lblStorId
            // 
            lblStorId.AutoSize = true;
            lblStorId.Font = new Font("Segoe UI", 14F);
            lblStorId.Location = new Point(42, 54);
            lblStorId.Name = "lblStorId";
            lblStorId.Size = new Size(96, 25);
            lblStorId.TabIndex = 2;
            lblStorId.Text = "Tienda ID:";
            // 
            // lblOrdNum
            // 
            lblOrdNum.AutoSize = true;
            lblOrdNum.Font = new Font("Segoe UI", 14F);
            lblOrdNum.Location = new Point(42, 96);
            lblOrdNum.Name = "lblOrdNum";
            lblOrdNum.Size = new Size(169, 25);
            lblOrdNum.TabIndex = 3;
            lblOrdNum.Text = "Número de Orden:";
            // 
            // lblOrdDate
            // 
            lblOrdDate.AutoSize = true;
            lblOrdDate.Font = new Font("Segoe UI", 14F);
            lblOrdDate.Location = new Point(42, 149);
            lblOrdDate.Name = "lblOrdDate";
            lblOrdDate.Size = new Size(149, 25);
            lblOrdDate.TabIndex = 4;
            lblOrdDate.Text = "Fecha de Orden:";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 14F);
            lblQty.Location = new Point(42, 199);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(92, 25);
            lblQty.TabIndex = 5;
            lblQty.Text = "Cantidad:";
            // 
            // lblPayterms
            // 
            lblPayterms.AutoSize = true;
            lblPayterms.Font = new Font("Segoe UI", 14F);
            lblPayterms.Location = new Point(441, 51);
            lblPayterms.Name = "lblPayterms";
            lblPayterms.Size = new Size(194, 25);
            lblPayterms.TabIndex = 6;
            lblPayterms.Text = "Condiciones de pago:";
            // 
            // lblTitleId
            // 
            lblTitleId.AutoSize = true;
            lblTitleId.Font = new Font("Segoe UI", 14F);
            lblTitleId.Location = new Point(441, 96);
            lblTitleId.Name = "lblTitleId";
            lblTitleId.Size = new Size(87, 25);
            lblTitleId.TabIndex = 7;
            lblTitleId.Text = "Título ID:";
            // 
            // txtStorId
            // 
            txtStorId.Font = new Font("Segoe UI", 14F);
            txtStorId.Location = new Point(223, 54);
            txtStorId.Name = "txtStorId";
            txtStorId.Size = new Size(200, 32);
            txtStorId.TabIndex = 8;
            // 
            // txtOrdNum
            // 
            txtOrdNum.Font = new Font("Segoe UI", 14F);
            txtOrdNum.Location = new Point(223, 96);
            txtOrdNum.Name = "txtOrdNum";
            txtOrdNum.Size = new Size(200, 32);
            txtOrdNum.TabIndex = 9;
            // 
            // dtpOrdDate
            // 
            dtpOrdDate.Font = new Font("Segoe UI", 14F);
            dtpOrdDate.Location = new Point(223, 143);
            dtpOrdDate.Name = "dtpOrdDate";
            dtpOrdDate.Size = new Size(200, 32);
            dtpOrdDate.TabIndex = 10;
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Segoe UI", 14F);
            txtQty.Location = new Point(223, 199);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(200, 32);
            txtQty.TabIndex = 11;
            // 
            // txtPayterms
            // 
            txtPayterms.Font = new Font("Segoe UI", 14F);
            txtPayterms.Location = new Point(641, 48);
            txtPayterms.Name = "txtPayterms";
            txtPayterms.Size = new Size(200, 32);
            txtPayterms.TabIndex = 12;
            // 
            // txtTitleId
            // 
            txtTitleId.Font = new Font("Segoe UI", 14F);
            txtTitleId.Location = new Point(548, 96);
            txtTitleId.Name = "txtTitleId";
            txtTitleId.Size = new Size(293, 32);
            txtTitleId.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.Location = new Point(186, 484);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 42);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 14F);
            btnEditar.Location = new Point(311, 484);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 42);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14F);
            btnEliminar.Location = new Point(436, 484);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 42);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14F);
            btnLimpiar.Location = new Point(561, 484);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 42);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            // 
            // frm_Sales
            // 
            ClientSize = new Size(877, 530);
            Controls.Add(lblTitle);
            Controls.Add(dgvSales);
            Controls.Add(lblStorId);
            Controls.Add(lblOrdNum);
            Controls.Add(lblOrdDate);
            Controls.Add(lblQty);
            Controls.Add(lblPayterms);
            Controls.Add(lblTitleId);
            Controls.Add(txtStorId);
            Controls.Add(txtOrdNum);
            Controls.Add(dtpOrdDate);
            Controls.Add(txtQty);
            Controls.Add(txtPayterms);
            Controls.Add(txtTitleId);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Sales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSales;

        private System.Windows.Forms.Label lblStorId;
        private System.Windows.Forms.Label lblOrdNum;
        private System.Windows.Forms.Label lblOrdDate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPayterms;
        private System.Windows.Forms.Label lblTitleId;

        private System.Windows.Forms.TextBox txtStorId;
        private System.Windows.Forms.TextBox txtOrdNum;
        private System.Windows.Forms.DateTimePicker dtpOrdDate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPayterms;
        private System.Windows.Forms.TextBox txtTitleId;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}