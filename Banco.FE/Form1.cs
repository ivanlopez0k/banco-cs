namespace Banco.FE
{

    /* Hola profe, Las instrucciones las puse en el propio programa!
     * Como tambien puse las cuentas, aún asi, las dejo aca asi puede copiar y pegar! 
     * Cuenta: 115612 Contraseña: pepe123
     * Cuenta: 141524 Contraseña: abc156
     * Cuenta: 176982 Contraseña: aaa444
     */

    public partial class Banco : Form
    {

        List<Cuenta> cuentas = new List<Cuenta>();
        Cuenta cuentaActual = null;

        public Banco()
        {
            InitializeComponent();
            cargarCuentas();
            paneles();
        }

        private void cargarCuentas()
        {
            cuentas.Add(new Cuenta { IdCuenta = 115612, Contrasena = "pepe123", Saldo = 1000 });
            cuentas.Add(new Cuenta { IdCuenta = 141524, Contrasena = "abc156", Saldo = 1000 });
            cuentas.Add(new Cuenta { IdCuenta = 176982, Contrasena = "aaa444", Saldo = 1000 });

        }

        private void paneles()
        {
            panelLogin.Dock = DockStyle.Fill;
            panelOperaciones.Dock = DockStyle.Fill;

            panelLogin.Visible = true;
            panelOperaciones.Visible = false;

        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDepositar.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }

            cuentaActual.Saldo += monto;
            lblMensaje.Text = $"Depósito realizado. Nuevo saldo: ${cuentaActual.Saldo}";
            lblSaldo.Text = $"{cuentaActual.Saldo:C}";
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtRetirar.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }

            if (monto > cuentaActual.Saldo)
            {
                MessageBox.Show("Saldo insuficiente");
                return;
            }

            cuentaActual.Saldo -= monto;
            lblMensaje.Text = $"Retiro realizado. Nuevo saldo: ${cuentaActual.Saldo}";
            lblSaldo.Text = $"{cuentaActual.Saldo:C}";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cuentaActual = null;
            panelOperaciones.Visible = false;
            panelLogin.Visible = true;
            idCuenta.Text = "";
            contrasena.Text = "";
            lblLoginMensaje.Text = "";
        }
    

        private void bntInstrucciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instrucciones:\n\n1. Ingrese su ID de cuenta y contraseña para iniciar sesion.\n2. Una vez que ingreso, puede depositar o retirar dinero.\n3. Para depositar, ingrese el monto y presione -Depositar-.\n4. Para retirar, ingrese el monto y presione -Retirar-.\n5. Puede cerrar sesion en cualquier momento presionando -Cerrar Sesion-.", "Instrucciones");
            MessageBox.Show("Estas son las cuentas de prueba para ingresar \n Id:115612 Contraseña:pepe123 \n Id:141524 Contraseña:abc156 \n Id:176982 Contraseña:aaa444 ", "Cuentas para entrar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void idCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {


            if (!int.TryParse(idCuenta.Text, out int idIngresado))
            {
                lblLoginMensaje.Text = "El ID de cuenta debe ser un número";
                return;
            }
            string contra = contrasena.Text;

            for (int i = 0; i < cuentas.Count; i++)
            {
                if (cuentas[i].IdCuenta == idIngresado && cuentas[i].Contrasena == contra)
                {
                    cuentaActual = cuentas[i];
                    break;
                }
            }

            if (cuentaActual != null)
            {
                lblMensaje.Text = $"Bienvenido, cuenta numer: {cuentaActual.IdCuenta}";
                panelLogin.Visible = false;
                panelOperaciones.Visible = true;
                idCuenta.Text = "";
                contrasena.Text = "";
                lblLoginMensaje.Text = "";
                lblSaldo.Text = $"{cuentaActual.Saldo:C}";
            }
            else
            {
                lblLoginMensaje.Text = "ID de cuenta o contraseña incorrectos";
            }
        }
    }
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public string Contrasena { get; set; }
        public decimal Saldo { get; set; }
    }
}
