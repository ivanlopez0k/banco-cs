namespace Banco.FE
{
    partial class Form1
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
            btnIngresar = new Button();
            contraseña = new TextBox();
            labelContraseña = new Label();
            idCuenta = new TextBox();
            labelId = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblSaldo = new Label();
            btnDepositar = new Button();
            txtDepositar = new TextBox();
            txtRetirar = new TextBox();
            btnRetirar = new Button();
            button1 = new Button();
            panelLogin.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(btnIngresar);
            panelLogin.Controls.Add(contraseña);
            panelLogin.Controls.Add(labelContraseña);
            panelLogin.Controls.Add(idCuenta);
            panelLogin.Controls.Add(labelId);
            panelLogin.Location = new Point(16, 31);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(245, 228);
            panelLogin.TabIndex = 0;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(84, 182);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // contraseña
            // 
            contraseña.Location = new Point(59, 123);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(100, 23);
            contraseña.TabIndex = 3;
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
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtRetirar);
            panel1.Controls.Add(btnRetirar);
            panel1.Controls.Add(txtDepositar);
            panel1.Controls.Add(btnDepositar);
            panel1.Controls.Add(lblSaldo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(267, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 228);
            panel1.TabIndex = 1;
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
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(186, 22);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(13, 15);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "0";
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
            // txtDepositar
            // 
            txtDepositar.Location = new Point(116, 61);
            txtDepositar.Name = "txtDepositar";
            txtDepositar.Size = new Size(175, 23);
            txtDepositar.TabIndex = 3;
            txtDepositar.Text = "0";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 290);
            Controls.Add(panel1);
            Controls.Add(panelLogin);
            Name = "Form1";
            Text = "Form1";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label labelId;
        private Label labelContraseña;
        private TextBox idCuenta;
        private TextBox contraseña;
        private Button btnIngresar;
        private Panel panel1;
        private Label label1;
        private Button btnDepositar;
        private Label lblSaldo;
        private TextBox txtRetirar;
        private Button btnRetirar;
        private TextBox txtDepositar;
        private Button button1;
    }
}
