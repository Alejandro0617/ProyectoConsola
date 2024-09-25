using system;
using system.Collections.Generic;

public class venta
{
    public double Monto{get;}
    public DateTime Fecha{get;}

    public venta (double Monto, DateTime Fecha)
    {
        Monto=monto;
        Fecha=fecha; 
    }
}

public class Vendedor : Persona
{
    private int comision;
    private string direccion;
    private List<venta> ventas; //Almacena las ventas

    public Vendedor(stringc codigo, string email, string nombre, string telefono, int comision, string direccion)
    :base (codigo,email,nombre,telefono)
    {
        this.comision=comision;
        this.direccion=direccion;
        this.ventas= new List<venta>(); //Inicializa la lista de venta
    }

    public void Vender(double monto)
    {
        venta nuevaVenta= new venta(monto,DateTime.Now);
        vantas.Add(nuevaVenta);
        Console.WriteLine($"Venta Registrada: Monto = {monto}, Fecha = {nuevaVenta.Fecha}")

    }

    public double ConsultarComision()
    {
        double totalComision = 0;
        foreach (var venta in ventas)
        {
            totalComision +=ventas.Monto * (comision / 100.0);

        }
        Console.WriteLine($"Comision total: {totalComision}");
        return totalComision;
    }
}