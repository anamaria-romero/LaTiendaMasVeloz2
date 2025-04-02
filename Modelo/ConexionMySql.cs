using MySql.Data.MySqlClient;

public class ConexionMySql
{
    private string cadenaConexion;

    public ConexionMySql()
    {
        cadenaConexion = "Database=LaTiendaMasVeloz;Datasource=localhost;User Id=root;Password=;";
    }

    public MySqlConnection GetConnection()
    {
        MySqlConnection connection = new MySqlConnection(cadenaConexion); 
        try
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open(); 
            }
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            throw;
        }

        return connection;
    }
}
