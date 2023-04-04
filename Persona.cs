class Persona
{
    public int DNI{get;set;}
    public string Apellido{get;private set;}
    public string Nombre{get;set;}
     public string Email{get;set;}
    public DateTime FechaNacimiento{get;set;}
    public int Edad{get;set;}

    public Persona()
    {

    }
    public Persona(int dni, string apellido, string nom, string email, DateTime fn = new DateTime())
    {
        DNI = dni;
        Apellido = apellido;
        Nombre = nom;
        Email = email;
        FechaNacimiento = fn;
        Edad = 0;
    }   

    public int ObtenerEdad()
    {
        DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, FechaNacimiento.Month, FechaNacimiento.Day);
        if (FechaNacimientoHoy< DateTime.Today)  Edad = DateTime.Today.Year - FechaNacimiento.Year;
            else   Edad = DateTime.Today.Year - FechaNacimiento.Year -1;
        return Edad;
    }

    public bool PuedeVotar()
    {
        bool puede = false;
        if(Edad >= 16)
        {
            puede = true;
        }
        return puede;
    }
}