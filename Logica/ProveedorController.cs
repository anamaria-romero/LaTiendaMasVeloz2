using Modelo.Entities;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace Logica
{
    public class ProveedorController
    {
        private ConexionMySql conexion = new ConexionMySql();
        
        public string CrearProveedor(string nombre, string telefono, string documento)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(documento))
                return "El nombre, el teléfono y el documento son obligatorios.";

            string query = "INSERT INTO ProveedorEntity (nombre, telefono, documento) VALUES (@nombre, @telefono, @documento)";

            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.ExecuteNonQuery();
                    return "Proveedor registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar proveedor: " + ex.Message;
            }
        }

        public DataTable ConsultarProveedor(string documento)
        {
            string query = "SELECT * FROM ProveedorEntity WHERE documento = @documento";
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
                Console.WriteLine("Error al consultar proveedor: " + ex.Message);
            }

            return dt;
        }

        public string ActualizarProveedor(string nombre, string telefono, string documento)
        {
            if (string.IsNullOrEmpty(documento))
                return "El documento es obligatorio.";

            List<string> updates = new List<string>();
            if (!string.IsNullOrEmpty(nombre)) updates.Add("nombre = @nombre");
            if (!string.IsNullOrEmpty(telefono)) updates.Add("telefono = @telefono");

            if (updates.Count == 0)
                return "No se proporcionaron datos para actualizar.";

            string query = $"UPDATE ProveedorEntity SET {string.Join(", ", updates)} WHERE documento = @documento";

            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(nombre)) cmd.Parameters.AddWithValue("@nombre", nombre);
                    if (!string.IsNullOrEmpty(telefono)) cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@documento", documento);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return "Proveedor actualizado correctamente.";
                    else
                        return "No se encontró el proveedor con ese documento.";
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar proveedor: " + ex.Message + "\n" + ex.StackTrace;
            }
        }

        public string EliminarProveedor(string documento)
        {
            if (string.IsNullOrEmpty(documento))
                return "El documento es obligatorio.";

            string query = "DELETE FROM ProveedorEntity WHERE documento = @documento";

            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.ExecuteNonQuery();
                    return "Proveedor eliminado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar proveedor: " + ex.Message;
            }
        }
    }
}
