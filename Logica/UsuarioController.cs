using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Logica
{
    public class UsuarioController
    {
        private ConexionMySql conexion = new ConexionMySql();

        public string RegistrarUsuario(string nombre, string documento, string rol, string contraseña)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(contraseña))
                return "Todos los campos son obligatorios.";

            string query = "INSERT INTO UsuarioEntity (nombre, documento, rol, contraseña) VALUES (@nombre, @documento, @rol, @contraseña)";

            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@rol", rol);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                    cmd.ExecuteNonQuery();
                    return "Usuario registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar usuario: " + ex.Message;
            }
        }

        public DataTable ConsultarUsuario(string documento)
        {
            string query = "SELECT * FROM UsuarioEntity WHERE documento = @documento";
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar usuario: " + ex.Message);
            }

            return dt;
        }

        public string ActualizarUsuario(string nombre, string documento, string contraseña)
        {
            try
            {
                string query = "UPDATE UsuarioEntity SET nombre = @nombre, contraseña = @contraseña WHERE documento = @documento";

                using (var connection = new MySqlConnection("Server=localhost;Database=LaTiendaMasVeloz;User ID=root;Password=;"))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@contraseña", contraseña);
                        command.Parameters.AddWithValue("@documento", documento);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return "Usuario actualizado con éxito.";
                        }
                        else
                        {
                            return "No se encontró el usuario para actualizar.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar el usuario: " + ex.Message;
            }
        }


        public string EliminarUsuario(string documento)
        {
            if (string.IsNullOrEmpty(documento))
                return "El documento es obligatorio.";

            string query = "DELETE FROM UsuarioEntity WHERE documento = @documento";

            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.ExecuteNonQuery();
                    return "Usuario eliminado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar usuario: " + ex.Message;
            }
        }
    }
}
