public class persona{
    private string codigo;
    private string email;
    private string nombre;
    private string telefono;
    
public persona (string codigo, string email, string nombre, string telefono)
{
    this.codigo=codigo;
    this.email=email;
    this.nombre=nombre;
    this.telefono=telefono;
}

public void borrar (List<persona> personas)
{
    var personaAborrar = personas.Find(=>p.codigo == this.codigo);
    if(personaAborrar !=NULL)
    {
        personas.Remove(personaAborrar);
        Console.WriteLine($"Persona con codigo {this.codigo} ha sido borrada.")
    }else{
        Console.WriteLine($"No se encontro a la persona con Codido{this.codigo}.")
    }
}

public void Consultar ()
{
    Console.WriteLine($"Codigo: {Codigo}");
    Console.WriteLine($"Email: {Email}");
    Console.WriteLine($"Nombre: {Nombre}");
    Console.WriteLine($"Telefono: {Telefono}")
}
public void Ingresar(string Codido, string email, string nombre, string telefono)
{
    this.codigo=codigo;
    this.email=email;
    this.nombre=nombre;
    this.telefono=telefono;
}
public void Modificar(string email, string nombre, string telefono)
{
    this.email=email;
    this.nombre=nombre;
    this.telefono=telefono;
}
public bool Verificar()
{
    //Verifica si la persona es valida
    return !string.IsNullOrEmpty(email);
}

}