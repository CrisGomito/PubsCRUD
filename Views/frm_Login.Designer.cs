namespace PubsCRUD.Views
{
    partial class frm_Login
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
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnLogin = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblUsuario.Location = new Point(63, 67);
            lblUsuario.Margin = new Padding(5, 0, 5, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblContrasena.Location = new Point(63, 150);
            lblContrasena.Margin = new Padding(5, 0, 5, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(118, 25);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(191, 67);
            txtUsuario.Margin = new Padding(5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(249, 32);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(191, 143);
            txtContrasena.Margin = new Padding(5);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(249, 32);
            txtContrasena.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F);
            btnLogin.Location = new Point(54, 219);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(157, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(283, 219);
            btnSalir.Margin = new Padding(5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(157, 50);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(66, 304);
            label1.Name = "label1";
            label1.Size = new Size(426, 19);
            label1.TabIndex = 6;
            label1.Text = "Para las credenciales usar Nombre y Apellido de la tabla Empleados )";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(26, 304);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 7;
            label2.Text = "Nota:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(18, 303);
            label3.Name = "label3";
            label3.Size = new Size(13, 19);
            label3.TabIndex = 8;
            label3.Text = "(";
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 332);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Pubs";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}