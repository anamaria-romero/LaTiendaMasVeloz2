public class ProductoEntity
{
    public int id { get; set; }
    public string nombre { get; set; }
    public string marca { get; set; }
    public int cantidad { get; set; }
    public decimal precio { get; set; }
    public int? id_proveedor { get; set; } 
    public string referencia { get; set; }
}
