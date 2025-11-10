namespace PubsCRUD.Views
{
    partial class frm_Discounts
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
            dgvDiscounts = new DataGridView();
            lblDiscountId = new Label();
            lblStoreId = new Label();
            lblLowQty = new Label();
            lblHighQty = new Label();
            lblDiscount = new Label();
            txtDiscountId = new TextBox();
            txtStoreId = new TextBox();
            txtLowQty = new TextBox();
            txtHighQty = new TextBox();
            txtDiscount = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDiscounts).BeginInit();
            SuspendLayout();
            // 
            // dgvDiscounts
            // 
            dgvDiscounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscounts.Location = new Point(40, 260);
            dgvDiscounts.Name = "dgvDiscounts";
            dgvDiscounts.Size = new Size(640, 200);
            dgvDiscounts.TabIndex = 0;
            // 
            // lblDiscountId
            // 
            lblDiscountId.AutoSize = true;
            lblDiscountId.Font = new Font("Segoe UI", 14F);
            lblDiscountId.Location = new Point(147, 36);
            lblDiscountId.Name = "lblDiscountId";
            lblDiscountId.Size = new Size(128, 25);
            lblDiscountId.TabIndex = 1;
            lblDiscountId.Text = "ID Descuento:";
            // 
            // lblStoreId
            // 
            lblStoreId.AutoSize = true;
            lblStoreId.Font = new Font("Segoe UI", 14F);
            lblStoreId.Location = new Point(147, 76);
            lblStoreId.Name = "lblStoreId";
            lblStoreId.Size = new Size(96, 25);
            lblStoreId.TabIndex = 2;
            lblStoreId.Text = "ID Tienda:";
            // 
            // lblLowQty
            // 
            lblLowQty.AutoSize = true;
            lblLowQty.Font = new Font("Segoe UI", 14F);
            lblLowQty.Location = new Point(147, 116);
            lblLowQty.Name = "lblLowQty";
            lblLowQty.Size = new Size(160, 25);
            lblLowQty.TabIndex = 3;
            lblLowQty.Text = "Cantidad mínima:";
            // 
            // lblHighQty
            // 
            lblHighQty.AutoSize = true;
            lblHighQty.Font = new Font("Segoe UI", 14F);
            lblHighQty.Location = new Point(147, 156);
            lblHighQty.Name = "lblHighQty";
            lblHighQty.Size = new Size(163, 25);
            lblHighQty.TabIndex = 4;
            lblHighQty.Text = "Cantidad máxima:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 14F);
            lblDiscount.Location = new Point(147, 196);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(138, 25);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Descuento (%):";
            // 
            // txtDiscountId
            // 
            txtDiscountId.Font = new Font("Segoe UI", 14F);
            txtDiscountId.Location = new Point(346, 36);
            txtDiscountId.Name = "txtDiscountId";
            txtDiscountId.Size = new Size(200, 32);
            txtDiscountId.TabIndex = 6;
            // 
            // txtStoreId
            // 
            txtStoreId.Font = new Font("Segoe UI", 14F);
            txtStoreId.Location = new Point(346, 76);
            txtStoreId.Name = "txtStoreId";
            txtStoreId.Size = new Size(200, 32);
            txtStoreId.TabIndex = 7;
            // 
            // txtLowQty
            // 
            txtLowQty.Font = new Font("Segoe UI", 14F);
            txtLowQty.Location = new Point(346, 116);
            txtLowQty.Name = "txtLowQty";
            txtLowQty.Size = new Size(200, 32);
            txtLowQty.TabIndex = 8;
            // 
            // txtHighQty
            // 
            txtHighQty.Font = new Font("Segoe UI", 14F);
            txtHighQty.Location = new Point(346, 156);
            txtHighQty.Name = "txtHighQty";
            txtHighQty.Size = new Size(200, 32);
            txtHighQty.TabIndex = 9;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 14F);
            txtDiscount.Location = new Point(346, 196);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(200, 32);
            txtDiscount.TabIndex = 10;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 14F);
            btnNuevo.Location = new Point(40, 477);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 30);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.Location = new Point(180, 477);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 30);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 14F);
            btnEditar.Location = new Point(374, 477);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 30);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14F);
            btnEliminar.Location = new Point(590, 477);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            // 
            // frm_Discounts
            // 
            ClientSize = new Size(740, 519);
            Controls.Add(dgvDiscounts);
            Controls.Add(lblDiscountId);
            Controls.Add(lblStoreId);
            Controls.Add(lblLowQty);
            Controls.Add(lblHighQty);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscountId);
            Controls.Add(txtStoreId);
            Controls.Add(txtLowQty);
            Controls.Add(txtHighQty);
            Controls.Add(txtDiscount);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Name = "frm_Discounts";
            Text = "Gestión de Descuentos";
            ((System.ComponentModel.ISupportInitialize)dgvDiscounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscounts;
        private System.Windows.Forms.Label lblDiscountId;
        private System.Windows.Forms.Label lblStoreId;
        private System.Windows.Forms.Label lblLowQty;
        private System.Windows.Forms.Label lblHighQty;
        private System.Windows.Forms.Label lblDiscount;

        private System.Windows.Forms.TextBox txtDiscountId;
        private System.Windows.Forms.TextBox txtStoreId;
        private System.Windows.Forms.TextBox txtLowQty;
        private System.Windows.Forms.TextBox txtHighQty;
        private System.Windows.Forms.TextBox txtDiscount;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}