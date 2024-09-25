using System.Collections.Generic;

public class Empresa
{
    private string codigo;
    private string nombre;
    private List<Cliente> clientes; //Agregacion

    public class Empresa(string codigo, string nombre)
    {
        this.codigo=codigo;
        this.nombre=nombre;
        this.cliente = new List<Cliente>();
    }
    public void AgregarCliente(Cliente cliente)
    {
        cliente.Add(cliente);
    }
    public void ConsultarCliente()
    {
        Console.WriteLine("Lista de Clientes:");
        foreach(var cliente in clientes)
        {
            console.WriteLine($"Codigo:{cliente.Codigo}");
            console.WriteLine($"Nombre: {cliente.Nombre}");
            console.WriteLine($"Email:{cliente.Email}");
            console.WriteLine($"Credito:{cliente.ConsultarCredito():C}");//Devuelve credito disponible
        }
    }


}