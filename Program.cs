using System.Collections.Generic;
Dictionary<int, Persona> dicPersonas = new Dictionary<int, Persona>();
 
void CargarPersona()
{
    int dni = Funciones.IngresarEntero("Ingrese DNI ");
    string apellido = Funciones.IngresarTexto("Ingrese Curso ");
    string nom = Funciones.IngresarTexto("Ingrese Nombre ");
    string email = Funciones.IngresarTexto("Ingrese su Email");
    DateTime fn = Funciones.IngresarFecha("Ingrese Fecha de Nacimiento (aaaa/mm/dd) ");
    
    Persona unaPer =  new Persona(dni, apellido, nom, email, fn);
    dni = Funciones.IngresarEntero("Ingrese DNI ");
    apellido = Funciones.IngresarTexto("Ingrese Apellido ");
    nom = Funciones.IngresarTexto("Ingrese Nombre ");
    email = Funciones.IngresarTexto("Ingrese Email");
    fn = Funciones.IngresarFecha("Ingrese Fecha de Nacimiento (aaaa/mm/dd) ");
    

    dicPersonas.Add(dni,unaPer);
}

void EstadisticasCenso()
{
    int cantPersonas;
    cantPersonas = dicPersonas.Count;
    int habilitados = 0;
    int acum = 0;
    int promedio;
    if(cantPersonas == 0)
    {
        Console.WriteLine("Aún no se han ingresado personas");
    }
    else
    {
        foreach (Persona valor in dicPersonas.Values)
    {
        if(valor.PuedeVotar())
        {
            habilitados ++;
        }

        acum +=valor.Edad;
    }

    promedio = acum/cantPersonas;
    Console.WriteLine($"Cantidad de Personas: {cantPersonas}");
    Console.WriteLine($"Cantidad de Personas Habilitadas para votar: {habilitados}");
    Console.WriteLine($"Promedio edad: {promedio}");
    }
    

}