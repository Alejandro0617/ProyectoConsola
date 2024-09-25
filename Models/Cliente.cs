public class Cliente : Persona
{
    
    private double credito;

    public Cliente (string codigo, string email, string nombre, string telefono, double credito)
    :base (codigo,email,nombre,telefono)
    {
        this.credito = credito;
    }

public string Codigo {get{return codigo;}}
public string Nombre{get{return nombre;}}
public string Email{get{return Email;}}
public string telefono{get{return telefono;}}
    public void AumentarCredito(double monto) 
    {credito += monto;}
    public double ConsultarCredito () 
    {return credito;}

}


