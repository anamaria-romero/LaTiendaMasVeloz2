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

        public int GuardarProductoProveedor(ProductoProveedor productoProveedor)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (MySqlCommand cmd = conexion.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO ProductoProveedor (id_producto, id_proveedor, fecha_ingreso, precio_compra, cantidad) " +
                                      "VALUES (@id_producto, @id_proveedor, @fecha_ingreso, @precio_compra, @cantidad)";
                    cmd.Parameters.AddWithValue("@id_producto", productoProveedor.IdProducto);
                    cmd.Parameters.AddWithValue("@id_proveedor", productoProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", productoProveedor.FechaIngreso);
                    cmd.Parameters.AddWithValue("@precio_compra", productoProveedor.PrecioCompra);
                    cmd.Parameters.AddWithValue("@cantidad", productoProveedor.Cantidad);

                    return cmd.ExecuteNonQuery();
                }
            }
        }


        public ProductoProveedor MostrarProductoProveedor(int id)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT id, id_producto, id_proveedor, fecha_ingreso, precio_compra, cantidad FROM ProductoProveedor WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ProductoProveedor
                            {
                                Id = reader.GetInt32("id"),
                                IdProducto = reader.GetInt32("id_producto"),
                                IdProveedor = reader.GetInt32("id_proveedor"),
                                FechaIngreso = reader.GetDateTime("fecha_ingreso"),
                                PrecioCompra = reader.GetDecimal("precio_compra"),
                                Cantidad = reader.GetInt32("cantidad")
                            };
                        }
                    }
                }
            }
            return null;
        }


        public int ActualizarProductoProveedor(ProductoProveedor productoProveedor)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = @"UPDATE ProductoProveedor 
                         SET id_producto = @id_producto, 
                             id_proveedor = @id_proveedor, 
                             fecha_ingreso = @fecha_ingreso, 
                             precio_compra = @precio_compra, 
                             cantidad = @cantidad 
                         WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", productoProveedor.Id);
                    cmd.Parameters.AddWithValue("@id_producto", productoProveedor.IdProducto);
                    cmd.Parameters.AddWithValue("@id_proveedor", productoProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", productoProveedor.FechaIngreso);
                    cmd.Parameters.AddWithValue("@precio_compra", productoProveedor.PrecioCompra);
                    cmd.Parameters.AddWithValue("@cantidad", productoProveedor.Cantidad);

                    return cmd.ExecuteNonQuery();
                }
            }
        }


        public int EliminarProductoProveedor(int id)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "DELETE FROM ProductoProveedor WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery();
                }
            }
        }


        public int CrearFactura(FacturaEntity factura)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = @"INSERT INTO FacturaEntity (id_cliente, id_usuario, total) 
                         VALUES (@id_cliente, @id_usuario, @total);
                         SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
                    cmd.Parameters.AddWithValue("@id_usuario", factura.id_usuario);
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

        public string ObtenerNombreCliente(int idCliente)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT nombre FROM ClienteEntity WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return reader.GetString("nombre");
                    }
                }
            }
            return "Cliente desconocido";
        }

        public string ObtenerNombreEmpleado(int idEmpleado)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT nombre FROM UsuarioEntity WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return reader.GetString("nombre");
                    }
                }
            }
            return "Empleado desconocido";
        }

        public FacturaEntity ConsultarFacturaPorId(int id)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM FacturaEntity WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new FacturaEntity
                            {
                                id = reader.GetInt32("id"),
                                id_cliente = reader.GetInt32("id_cliente"),
                                id_usuario = reader.GetInt32("id_usuario"),
                                total = reader.GetDecimal("total"),
                                fecha = reader.GetDateTime("fecha")
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<ProductosFactura> ConsultarProductosPorFactura(int idFactura)
        {
            List<ProductosFactura> lista = new List<ProductosFactura>();
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM ProductosFactura WHERE id_factura = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idFactura);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProductosFactura
                            {
                                id = reader.GetInt32("id"),
                                id_factura = reader.GetInt32("id_factura"),
                                id_producto = reader.GetInt32("id_producto"),
                                cantidad = reader.GetInt32("cantidad"),
                                subtotal = reader.GetDecimal("subtotal")
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool ActualizarFactura(FacturaEntity factura)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = @"UPDATE FacturaEntity 
                         SET id_cliente = @id_cliente, 
                             id_usuario = @id_usuario, 
                             fecha = @fecha, 
                             total = @total 
                         WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", factura.id);
                    cmd.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
                    cmd.Parameters.AddWithValue("@id_usuario", factura.id_usuario);
                    cmd.Parameters.AddWithValue("@fecha", factura.fecha);
                    cmd.Parameters.AddWithValue("@total", factura.total);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public void EliminarProductosPorFactura(int idFactura)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "DELETE FROM ProductosFactura WHERE id_factura = @idFactura";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idFactura", idFactura);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string ObtenerNombreProductoPorId(int idProducto)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT nombre FROM ProductoEntity WHERE id_producto = @idProducto";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    object resultado = cmd.ExecuteScalar();
                    return resultado != null ? resultado.ToString() : "Producto desconocido";
                }
            }
        }

        public int ObtenerIdProductoPorNombre(string nombreProducto)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT id FROM ProductoEntity WHERE nombre = @nombreProducto";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                    object resultado = cmd.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : -1;
                }
            }
        }


        public void EliminarFactura(int idFactura)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "DELETE FROM FacturaEntity WHERE id = @id"; 
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idFactura);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public FacturaEntity ObtenerFacturaPorId(int idFactura)
        {
            using (MySqlConnection conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM FacturaEntity WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idFactura);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new FacturaEntity
                            {
                                id = reader.GetInt32("id"),
                                id_cliente = reader.GetInt32("id_cliente"),
                                id_usuario = reader.GetInt32("id_usuario"),
                                total = reader.GetDecimal("total"),
                                fecha = reader.GetDateTime("fecha")
                            };
                        }
                    }
                }
            }

            return null;
        }

    }
}


