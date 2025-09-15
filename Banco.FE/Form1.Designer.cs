namespace Banco.FE
{
    partial class Banco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLogin = new Panel();
            lblLoginMensaje = new Label();
            btnIngresar = new Button();
            contrasena = new TextBox();
            labelContraseña = new Label();
            idCuenta = new TextBox();
            labelId = new Label();
            panelOperaciones = new Panel();
            lblMensaje = new Label();
            button1 = new Button();
            txtRetirar = new TextBox();
            btnRetirar = new Button();
            txtDepositar = new TextBox();
            btnDepositar = new Button();
            lblSaldo = new Label();
            label1 = new Label();
            panelLogin.SuspendLayout();
            panelOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(lblLoginMensaje);
            panelLogin.Controls.Add(btnIngresar);
            panelLogin.Controls.Add(contrasena);
            panelLogin.Controls.Add(labelContraseña);
            panelLogin.Controls.Add(idCuenta);
            panelLogin.Controls.Add(labelId);
            panelLogin.Location = new Point(63, 31);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(245, 228);
            panelLogin.TabIndex = 0;
            // 
            // lblLoginMensaje
            // 
            lblLoginMensaje.AutoSize = true;
            lblLoginMensaje.Location = new Point(88, 155);
            lblLoginMensaje.Name = "lblLoginMensaje";
            lblLoginMensaje.Size = new Size(10, 15);
            lblLoginMensaje.TabIndex = 5;
            lblLoginMensaje.Text = " ";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(69, 182);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // contrasena
            // 
            contrasena.Location = new Point(59, 123);
            contrasena.Name = "contrasena";
            contrasena.Size = new Size(100, 23);
            contrasena.TabIndex = 3;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(59, 105);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(67, 15);
            labelContraseña.TabIndex = 2;
            labelContraseña.Text = "Contraseña";
            labelContraseña.Click += label1_Click_1;
            // 
            // idCuenta
            // 
            idCuenta.Location = new Point(59, 61);
            idCuenta.Name = "idCuenta";
            idCuenta.Size = new Size(100, 23);
            idCuenta.TabIndex = 1;
            idCuenta.TextChanged += idCuenta_TextChanged;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(59, 43);
            labelId.Name = "labelId";
            labelId.Size = new Size(75, 15);
            labelId.TabIndex = 0;
            labelId.Text = "ID de Cuenta";
            labelId.Click += label1_Click;
            // 
            // panelOperaciones
            // 
            panelOperaciones.Controls.Add(lblMensaje);
            panelOperaciones.Controls.Add(button1);
            panelOperaciones.Controls.Add(txtRetirar);
            panelOperaciones.Controls.Add(btnRetirar);
            panelOperaciones.Controls.Add(txtDepositar);
            panelOperaciones.Controls.Add(btnDepositar);
            panelOperaciones.Controls.Add(lblSaldo);
            panelOperaciones.Controls.Add(label1);
            panelOperaciones.Location = new Point(267, 31);
            panelOperaciones.Name = "panelOperaciones";
            panelOperaciones.Size = new Size(309, 228);
            panelOperaciones.TabIndex = 1;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(116, 155);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(10, 15);
            lblMensaje.TabIndex = 7;
            lblMensaje.Text = " ";
            lblMensaje.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(85, 182);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 6;
            button1.Text = "Cerrar Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtRetirar
            // 
            txtRetirar.Location = new Point(116, 117);
            txtRetirar.Name = "txtRetirar";
            txtRetirar.Size = new Size(175, 23);
            txtRetirar.TabIndex = 5;
            txtRetirar.Text = "0";
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(12, 117);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(75, 23);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += button1_Click;
            // 
            // txtDepositar
            // 
            txtDepositar.Location = new Point(116, 61);
            txtDepositar.Name = "txtDepositar";
            txtDepositar.Size = new Size(175, 23);
            txtDepositar.TabIndex = 3;
            txtDepositar.Text = "0";
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(12, 61);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(75, 23);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(186, 22);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(13, 15);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 22);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "SALDO ACTUAL:";
            label1.Click += label1_Click_2;
            // 
            // Banco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 261);
            Controls.Add(panelOperaciones);
            Controls.Add(panelLogin);
            Name = "Banco";
            Text = "Banco";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelOperaciones.ResumeLayout(false);
            panelOperaciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label labelId;
        private Label labelContraseña;
        private TextBox idCuenta;
        private TextBox contrasena;
        private Button btnIngresar;
        private Panel panelOperaciones;
        private Label label1;
        private Button btnDepositar;
        private Label lblSaldo;
        private TextBox txtRetirar;
        private Button btnRetirar;
        private TextBox txtDepositar;
        private Button button1;
        private Label lblMensaje;
        private Label lblLoginMensaje;
    }
}
