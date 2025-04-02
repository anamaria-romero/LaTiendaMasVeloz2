using Modelo;
using Modelo.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FacturaController
    {
        private readonly ConexionMySql conexion;

        public FacturaController()
        {
            conexion = new ConexionMySql();
        }

        public void CrearFactura(int id_cliente, int id_empleado, decimal total)
        {
            using (var conn = conexion.GetConnection())
            {
                string query = "INSERT INTO FacturaEntity (id_cliente, id_empleado, total) VALUES (@id_cliente, @id_empleado, @total)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                cmd.Parameters.AddWithValue("@id_empleado", id_empleado);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.ExecuteNonQuery();
            }
        }

        public List<FacturaEntity> ObtenerFacturas()
        {
            List<FacturaEntity> lista = new List<FacturaEntity>();
            using (var conn = conexion.GetConnection())
            {
                string query = "SELECT * FROM FacturaEntity";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new FacturaEntity
                    {
                        id = reader.GetInt32("id"),
                        id_cliente = reader.GetInt32("id_cliente"),
                        id_empleado = reader.GetInt32("id_empleado"),
                        total = reader.GetDecimal("total"),
                        fecha = reader.GetDateTime("fecha")
                    });
                }
            }
            return lista;
        }

        public void ActualizarFactura(int id, int id_cliente, int id_empleado, decimal total)
        {
            using (var conn = conexion.GetConnection())
            {
                string query = "UPDATE FacturaEntity SET id_cliente=@id_cliente, id_empleado=@id_empleado, total=@total WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                cmd.Parameters.AddWithValue("@id_empleado", id_empleado);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarFactura(int id)
        {
            using (var conn = conexion.GetConnection())
            {
                string query = "DELETE FROM FacturaEntity WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
