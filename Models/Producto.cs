public class Producto
{
    private string codigo;
    private string nombre;
    private int stock;
    private double ValorUnitario;

    public Producto(string cosigo, string nombre, int stock,double ValorUnitario)
    {
        this.codigo=codigo;
        this.nombre=nombre;
        this.stock=stock;
        this.ValorUnitario= ValorUnitario;
    }
    public void ModificarStock(int cantidad)
    {
        stock +=cantidad;
    }
    public double ValorUnitario
    {
        get{return ValorUnitario}
    }
}