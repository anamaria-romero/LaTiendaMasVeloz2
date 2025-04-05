using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace Principal
{
    public partial class Usuario : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public Usuario()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void CargarRoles()
        {
            var roles = Enum.GetValues(typeof(RolUsuario));
            foreach (RolUsuario rol in roles)
            {
                cbCargo.Items.Add(new ComboBoxItem
                {
                    Texto = EnumHelper.GetDescription(rol),
                    Valor = rol
                });
            }
            cbCargo.SelectedIndex = 0;
        }

        private void btIngresarUsuario_Click(object sender, EventArgs e)
        {
            string documento = tbDocumentoUsuario.Text.Trim();
            string nombre = tbNombreUsuario.Text.Trim();
            string contraseña = tbContraseñaUsuario.Text.Trim();

            if (cbCargo.SelectedItem is ComboBoxItem selectedItem)
            {
                RolUsuario rol = selectedItem.Valor;

                if (string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                UsuarioEntity usuario = new UsuarioEntity
                {
                    documento = documento,
                    nombre = nombre,
                    rol = rol,
                    contraseña = contraseña
                };

                string mensaje = usuarioController.GuardarUsuario(usuario);

                if (mensaje == "Usuario guardado correctamente.")
                {
                    UsuarioEntity usuarioRegistrado = usuarioController.ConsultarUsuario(documento);

                    if (usuarioRegistrado != null)
                    {
                        lbUsuarioRegistrado.Text = $"Usuario registrado: {usuarioRegistrado.nombre}, Rol: {EnumHelper.GetDescription(usuarioRegistrado.rol)}";
                    }
                    else
                    {
                        lbUsuarioRegistrado.Text = "Error al recuperar los datos del usuario.";
                    }
                }
                else
                {
                    lbUsuarioRegistrado.Text = mensaje;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un rol válido.");
            }
        }

        private void lbUsuarioRegistrado_Click(object sender, EventArgs e) { }

        private class ComboBoxItem
        {
            public string Texto { get; set; }
            public RolUsuario Valor { get; set; }

            public override string ToString()
            {
                return Texto;
            }
        }
    }

    public static class EnumHelper
    {
        public static string GetDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }
    }
}
