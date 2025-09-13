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
            labelId = new Label();
            idCuenta = new TextBox();
            labelContraseña = new Label();
            contraseña = new TextBox();
            btnIngresar = new Button();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(btnIngresar);
            panelLogin.Controls.Add(contraseña);
            panelLogin.Controls.Add(labelContraseña);
            panelLogin.Controls.Add(idCuenta);
            panelLogin.Controls.Add(labelId);
            panelLogin.Location = new Point(263, 78);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(245, 228);
            panelLogin.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(53, 22);
            labelId.Name = "labelId";
            labelId.Size = new Size(75, 15);
            labelId.TabIndex = 0;
            labelId.Text = "ID de Cuenta";
            labelId.Click += label1_Click;
            // 
            // idCuenta
            // 
            idCuenta.Location = new Point(53, 40);
            idCuenta.Name = "idCuenta";
            idCuenta.Size = new Size(100, 23);
            idCuenta.TabIndex = 1;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(53, 84);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(67, 15);
            labelContraseña.TabIndex = 2;
            labelContraseña.Text = "Contraseña";
            labelContraseña.Click += label1_Click_1;
            // 
            // contraseña
            // 
            contraseña.Location = new Point(53, 102);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(100, 23);
            contraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(78, 161);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLogin);
            Name = "Form1";
            Text = "Form1";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label labelId;
        private Label labelContraseña;
        private TextBox idCuenta;
        private TextBox contraseña;
        private Button btnIngresar;
    }
}
