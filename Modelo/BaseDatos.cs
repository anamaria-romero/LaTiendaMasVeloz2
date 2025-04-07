using MySql.Data.MySqlClient;
using System;
using Modelo;
using Modelo.Entities;
using System.Data;
using Modelo.Helpers;

namespace Logica
{
    public class BaseDatos : ConexionMySql
    {
        public int GuardarCliente(ClienteEntity cliente)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "INSERT INTO ClienteEntity (documento, nombre, telefono) VALUES (@documento, @nombre, @telefono)";
                cmd.Parameters.AddWithValue("@documento", cliente.documento);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                return cmd.ExecuteNonQuery();
            }
        }

        public ClienteEntity MostrarCliente(string documento)
        {
            ClienteEntity cliente = null;
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT documento, nombre, telefono FROM ClienteEntity WHERE documento = @documento"; 
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new ClienteEntity
                            {
                                documento = reader["documento"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                telefono = reader["telefono"].ToString()
                            };
                        }
                    }
                }
            }
            return cliente;
        }

        public int ActualizarCliente(ClienteEntity cliente)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "UPDATE ClienteEntity SET nombre = @nombre, telefono = @telefono WHERE documento = @documento"; 
                cmd.Parameters.AddWithValue("@documento", cliente.documento);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                return cmd.ExecuteNonQuery();
            }
        }

        public int EliminarCliente(string documento)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "DELETE FROM ClienteEntity WHERE documento = @documento";
                cmd.Parameters.AddWithValue("@documento", documento);
                return cmd.ExecuteNonQuery();
            }
        }

        public int GuardarProducto(ProductoEntity producto)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (MySqlCommand cmd = conexion.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO ProductoEntity (nombre, marca, cantidad, precio, id_proveedor, referencia) VALUES (@nombre, @marca, @cantidad, @precio, @id_proveedor, @referencia)";
                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@marca", producto.marca);
                    cmd.Parameters.AddWithValue("@cantidad", producto.cantidad);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);
                    cmd.Parameters.AddWithValue("@id_proveedor", producto.id_proveedor);
                    cmd.Parameters.AddWithValue("@referencia", producto.referencia);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public ProductoEntity MostrarProducto(int id)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT id, nombre, marca, cantidad, precio, id_proveedor, referencia FROM ProductoEntity WHERE id = @id"; 

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ProductoEntity
                            {
                                id = reader.GetInt32("id"),
                                nombre = reader.GetString("nombre"),
                                marca = reader.IsDBNull(reader.GetOrdinal("marca")) ? null : reader.GetString("marca"),
                                cantidad = reader.GetInt32("cantidad"),
                                precio = reader.GetDecimal("precio"),
                                id_proveedor = reader.IsDBNull(reader.GetOrdinal("id_proveedor")) ? null : reader.GetInt32("id_proveedor"),
                                referencia = reader.GetString("referencia")
                            };
                        }
                    }
                }
            }
            return null;
        }

        public int ActualizarProducto(ProductoEntity producto)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (MySqlCommand cmd = conexion.CreateCommand())
                {
                    cmd.CommandText = "UPDATE ProductoEntity SET nombre = @nombre, marca = @marca, cantidad = @cantidad, precio = @precio, id_proveedor = @id_proveedor WHERE id = @id";

                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@marca", producto.marca);
                    cmd.Parameters.AddWithValue("@cantidad", producto.cantidad);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);
                    cmd.Parameters.AddWithValue("@id_proveedor", producto.id_proveedor);
                    cmd.Parameters.AddWithValue("@id", producto.id); 

                    return cmd.ExecuteNonQuery();
                }
            }
        }


        public int EliminarProducto(int id)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "DELETE FROM ProductoEntity WHERE id = @id"; 
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery();
            }
        }

        public int GuardarProveedor(ProveedorEntity proveedor)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "INSERT INTO ProveedorEntity (documento, nombre, telefono) VALUES (@documento, @nombre, @telefono)";
                cmd.Parameters.AddWithValue("@documento", proveedor.documento);
                cmd.Parameters.AddWithValue("@nombre", proveedor.nombre);
                cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
                return cmd.ExecuteNonQuery();
            }
        }

        public ProveedorEntity MostrarProveedor(string documento)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "SELECT * FROM ProveedorEntity WHERE documento = @documento"; 
                cmd.Parameters.AddWithValue("@documento", documento);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new ProveedorEntity
                    {
                        id = reader.GetInt32("id"),
                        documento = reader.GetString("documento"),
                        nombre = reader.GetString("nombre"),
                        telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? null : reader.GetString("telefono")
                    };
                }
            }
            return null;
        }

        public int ActualizarProveedor(ProveedorEntity proveedor)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (MySqlCommand cmd = conexion.CreateCommand())
                {
                    cmd.CommandText = "UPDATE ProveedorEntity SET nombre = @nombre, telefono = @telefono WHERE documento = @documento"; 

                    cmd.Parameters.AddWithValue("@nombre", proveedor.nombre);
                    cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
                    cmd.Parameters.AddWithValue("@documento", proveedor.documento);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int EliminarProveedor(string documento)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "DELETE FROM ProveedorEntity WHERE documento = @documento"; 
                cmd.Parameters.AddWithValue("@documento", documento);
                return cmd.ExecuteNonQuery();
            }
        }

        public int GuardarUsuario(UsuarioEntity usuario)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "INSERT INTO UsuarioEntity (documento, nombre, rol, contraseña) VALUES (@documento, @nombre, @rol, @contraseña)";
                cmd.Parameters.AddWithValue("@documento", usuario.documento);
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);

                string rolDescripcion = EnumHelper.GetDescription(usuario.rol);
                cmd.Parameters.AddWithValue("@rol", rolDescripcion);

                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                return cmd.ExecuteNonQuery();
            }
        }


        public UsuarioEntity MostrarUsuario(string documento)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "SELECT * FROM UsuarioEntity WHERE documento = @documento";
                cmd.Parameters.AddWithValue("@documento", documento);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string rolDescripcion = reader.GetString("rol");

                    return new UsuarioEntity
                    {
                        id = reader.GetInt32("id"),
                        documento = reader.GetString("documento"),
                        nombre = reader.GetString("nombre"),

                        rol = EnumHelper.GetRolFromDescription(rolDescripcion),

                        contraseña = reader.GetString("contraseña")
                    };
                }
            }
            return null;
        }


        public int ActualizarUsuario(UsuarioEntity usuario)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "UPDATE UsuarioEntity SET nombre = @nombre, rol = @rol, contraseña = @contraseña WHERE documento = @documento";

                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);

                string rolDescripcion = EnumHelper.GetDescription(usuario.rol);
                cmd.Parameters.AddWithValue("@rol", rolDescripcion);

                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                cmd.Parameters.AddWithValue("@documento", usuario.documento);

                return cmd.ExecuteNonQuery();
            }
        }


        public int EliminarUsuario(string documento)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "DELETE FROM UsuarioEntity WHERE documento = @documento"; 
                cmd.Parameters.AddWithValue("@documento", documento);
                return cmd.ExecuteNonQuery();
            }
        }

        public int CrearFactura(FacturaEntity factura)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = @"INSERT INTO FacturaEntity (id_cliente, id_empleado, total) 
                         VALUES (@id_cliente, @id_empleado, @total);
                         SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
                    cmd.Parameters.AddWithValue("@id_empleado", factura.id_empleado);
                    cmd.Parameters.AddWithValue("@total", factura.total);

                    return Convert.ToInt32(cmd.ExecuteScalar()); 
                }
            }
        }

        public int AgregarProductoAFactura(ProductosFactura detalle)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = @"INSERT INTO ProductosFactura (id_factura, id_producto, cantidad, subtotal) 
                         VALUES (@id_factura, @id_producto, @cantidad, @subtotal);";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_factura", detalle.id_factura);
                    cmd.Parameters.AddWithValue("@id_producto", detalle.id_producto);
                    cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                    cmd.Parameters.AddWithValue("@subtotal", detalle.subtotal);

                    return cmd.ExecuteNonQuery();
                }
            }
        }


    }
}


