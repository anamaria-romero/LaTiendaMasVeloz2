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
        return new MySqlConnection(cadenaConexion);
    }
}
