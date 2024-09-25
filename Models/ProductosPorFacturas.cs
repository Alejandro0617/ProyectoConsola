public class ProductosPorFacturas
{
    private int cantidad;
    private double subtotal;
    private Producto producto; //asociacion
    private Factura factura;

    public ProductosPorFacturas(int cantidad, double subtotal,Producto producto, Factura factura)
    {
        this.cantidad=cantidad;
        this.subtotal=subtotal;
        this.producto=producto;
        this.factura=factura;
    }   
    public double subtotal
    {
        get{return subtotal;}
    }
 }