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
            string documento = tbDocumentoProveedor.Text.Trim();  // Agregado para el documento

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor ingrese todos los campos.");
                return;
            }

            proveedorController.CrearProveedor(nombre, telefono, documento);
            MessageBox.Show("Proveedor ingresado correctamente.");
        }
    }
}
