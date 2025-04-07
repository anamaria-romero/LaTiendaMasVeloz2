using Modelo.Entities;

namespace Principal
{
    public partial class Proveedor : Form
    {
        private Logica.ProveedorController proveedorController;

        public Proveedor()
        {
            InitializeComponent();
            proveedorController = new Logica.ProveedorController();
        }

        private void btIngresarProveedor_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreProveedor.Text.Trim();
            string telefono = tbTelefonoProveedor.Text.Trim();
            string documento = tbDocumentoProveedor.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor ingrese todos los campos.");
                return;
            }

            ProveedorEntity proveedor = new ProveedorEntity
            {
                nombre = nombre,
                telefono = telefono,
                documento = documento
            };

            proveedorController.GuardarProveedor(proveedor);

            label1.Text = $"Proveedor registrado: {proveedor.nombre},\n Teléfono: {proveedor.telefono}, Documento: {proveedor.documento}";

            MessageBox.Show("Proveedor ingresado correctamente.");
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuProveedores menu = new SubMenuProveedores();
            menu.Show();
            this.Hide();
        }
    }
}
