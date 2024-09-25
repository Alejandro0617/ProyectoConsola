using system;
using system.Collections.Generic;

public class Factura
{
    private DateTime fecha;
    private long numero;
    private double total;
    private Cliente cliente; //agregacion
    private List<ProductosPorFacturas> ProductosPorFacturas; //composicion
    
    public Factura (DateTime fecha, long numero, Cliente cliente)
    {
        this.fecha= fecha;
        this.numero=numero;
        this.cliente=cliente;
        this.ProductosPorFacturas= new List<ProductosPorFacturas>();
    }
    public void agregarProducto(Producto producto, int cantidad)
    {
        double subtotal = cantidad * producto.ValorUnitario;
        ProductosPorFacturas.Add(new ProductosPorFactura(cantidad, subtotal, producto, this));
        total += subtotal;
    }
    public double ConsultarTotal() { return total;}
    public void ImprimirFactura() {
        cosnole.WriteLine("Factura");
        Console.WriteLine($"Fecha : {fecha.ToShortDateString()}");
        console.WriteLine($"Numero: {numero}");
        console.WriteLine($"Cliente: {Cliente.nombre }")

        Console.WriteLine("Productos: ");
        foreach (var item in ProductosPorFacturas)
        {
            Console.WriteLine($"-{item.Producto.Nombre}:{item.Cantidad} x{item.Producto.ValorUnitario:C}={item.Subtotal:c}");

        }
        console.WriteLine($"Total:{ConsultarToal():c}")
    }
}