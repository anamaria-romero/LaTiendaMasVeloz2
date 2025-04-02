using Modelo.Entities;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProductoController
    {
        private readonly ConexionMySql conexion;

        public ProductoController()
        {
            conexion = new ConexionMySql();
        }

        public void CrearProducto(string nombre, string marca, int cantidad, decimal precio, int? id_proveedor, string referencia)
        {
            using (var conn = conexion.GetConnection())
            {
                string query = "INSERT INTO ProductoEntity (nombre, marca, cantidad, precio, id_proveedor, referencia) VALUES (@nombre, @marca, @cantidad, @precio, @id_proveedor, @referencia)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor.HasValue ? (object)id_proveedor.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@referencia", referencia);
                cmd.ExecuteNonQuery();
            }
        }

        public List<ProductoEntity> ObtenerProductos()
        {
            List<ProductoEntity> lista = new List<ProductoEntity>();
            using (var conn = conexion.GetConnection())
            {
                string query = "SELECT * FROM ProductoEntity";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new ProductoEntity
                    {
                        id = reader.GetInt32("id"),
                        nombre = reader.GetString("nombre"),
                        marca = reader.GetString("marca"),
                        cantidad = reader.GetInt32("cantidad"),
                        precio = reader.GetDecimal("precio"),
                        id_proveedor = reader.IsDBNull(reader.GetOrdinal("id_proveedor")) ? (int?)null : reader.GetInt32("id_proveedor"),
                        referencia = reader.GetString("referencia")
                    });
                }
            }
            return lista;
        }

        public ProductoEntity ObtenerProductoPorId(int id)
        {
            ProductoEntity producto = null;

            using (var conn = conexion.GetConnection())
            {
                string query = "SELECT * FROM ProductoEntity WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    producto = new ProductoEntity
                    {
                        id = reader.GetInt32("id"),
                        nombre = reader.GetString("nombre"),
                        marca = reader.GetString("marca"),
                        cantidad = reader.GetInt32("cantidad"),
                        precio = reader.GetDecimal("precio"),
                        id_proveedor = reader.IsDBNull(reader.GetOrdinal("id_proveedor")) ? (int?)null : reader.GetInt32("id_proveedor"),
                        referencia = reader.GetString("referencia")
                    };
                }
            }

            return producto;
        }

        public void ActualizarProducto(int id, string nombre, string marca, int? cantidad, decimal? precio, int? id_proveedor, string referencia)
        {
            using (var conn = conexion.GetConnection())
            {
                StringBuilder query = new StringBuilder("UPDATE ProductoEntity SET ");
                List<MySqlParameter> parameters = new List<MySqlParameter>();

                bool hasFieldsToUpdate = false;

                if (!string.IsNullOrEmpty(nombre))
                {
                    query.Append("nombre=@nombre, ");
                    parameters.Add(new MySqlParameter("@nombre", nombre));
                    hasFieldsToUpdate = true;
                }

                if (!string.IsNullOrEmpty(marca))
                {
                    query.Append("marca=@marca, ");
                    parameters.Add(new MySqlParameter("@marca", marca));
                    hasFieldsToUpdate = true;
                }

                if (cantidad.HasValue)
                {
                    query.Append("cantidad=@cantidad, ");
                    parameters.Add(new MySqlParameter("@cantidad", cantidad.Value));
                    hasFieldsToUpdate = true;
                }

                if (precio.HasValue)
                {
                    query.Append("precio=@precio, ");
                    parameters.Add(new MySqlParameter("@precio", precio.Value));
                    hasFieldsToUpdate = true;
                }

                if (id_proveedor.HasValue)
                {
                    query.Append("id_proveedor=@id_proveedor, ");
                    parameters.Add(new MySqlParameter("@id_proveedor", id_proveedor.Value));
                    hasFieldsToUpdate = true;
                }

                if (!string.IsNullOrEmpty(referencia))
                {
                    query.Append("referencia=@referencia, ");
                    parameters.Add(new MySqlParameter("@referencia", referencia));
                    hasFieldsToUpdate = true;
                }

                if (!hasFieldsToUpdate)
                {
                    throw new Exception("No se proporcionaron campos para actualizar.");
                }

                query.Length -= 2; 
                query.Append(" WHERE id=@id");
                parameters.Add(new MySqlParameter("@id", id));

                MySqlCommand cmd = new MySqlCommand(query.ToString(), conn);
                cmd.Parameters.AddRange(parameters.ToArray());

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                    throw;
                }
            }
        }



        public void EliminarProducto(int id)
        {
            using (var conn = conexion.GetConnection())
            {
                string query = "DELETE FROM ProductoEntity WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
