namespace Banco.FE
{



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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
