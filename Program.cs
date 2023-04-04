using System.Collections.Generic;
Dictionary<int, Persona> dicPersonas = new Dictionary<int, Persona>();
int caso;
caso = Funciones.IngresarEntero("Ingrese que caso quiere consultar[1. CARGARPERSONA | 2. ESTADISTICAS | 3. BUSCAR PERSONA | 4. MODIFICAR EMAIL | 5. SALIR]: ");
Console.WriteLine();
bool salir = false;
while(salir)
{
    switch(caso)
    {
        case 1:
        CargarPersona();
        break;

        case 2:
        EstadisticasCenso();
        break;

        case 3:
        BuscarPersona();
        break;

        case 4:
        ModificarEmail();
        break;

        case 5:
        Salir(salir);
        break;
    }
    caso = Funciones.IngresarEntero("Ingrese que caso quiere consultar[1. CARGARPERSONA | 2. ESTADISTICAS | 3. BUSCAR PERSONA | 4. MODIFICAR EMAIL | 5. SALIR]: ");
        
}
 
void CargarPersona()
{
    int dni = Funciones.IngresarEntero("Ingrese DNI ");
    

    ValidarDNI(ref dni);

    string apellido = Funciones.IngresarTexto("Ingrese Apellido ");
    string nom = Funciones.IngresarTexto("Ingrese Nombre ");
    string email = Funciones.IngresarTexto("Ingrese su Email: ");
    DateTime fn = Funciones.IngresarFecha("Ingrese Fecha de Nacimiento (aaaa/mm/dd): ");
    
    Persona unaPer =  new Persona(dni, apellido, nom, email, fn);

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

        acum +=valor.ObtenerEdad();
    }
    promedio = acum/cantPersonas;

    MostrarEstadisticasCenso(cantPersonas, habilitados, promedio);
    }
}

void BuscarPersona()
{
    int userDNI = Funciones.IngresarEntero("Ingrese DNI ");
    bool encontro = false;
    foreach(Persona valor in dicPersonas.Values)
    {
        if(userDNI == valor.DNI) 
        {
            Console.WriteLine(valor.DNI);
            Console.WriteLine(valor.Apellido);
            Console.WriteLine(valor.Nombre);
            Console.WriteLine(valor.Email);
            Console.WriteLine(valor.FechaNacimiento.ToShortDateString());
            Console.WriteLine(valor.ObtenerEdad());
            encontro = true;

        }
        
    }
    if(!encontro)
    {
        Console.WriteLine("No se encuentra el DNI");
    }
    

}

void ModificarEmail()
{
    int userDNI = Funciones.IngresarEntero("Ingrese el DNI para cambiar el Email: ");
    string newEmail = Funciones.IngresarTexto("Ingrese el nuevo Email: ");

    foreach(int valor in dicPersonas.Keys)
    {
        if(userDNI == valor)
        {
            dicPersonas[valor].Email = newEmail;
        }
    }
}

void Salir(bool salir)
{
    salir = true;
}

void ValidarDNI(ref int dni)
{
    bool puede = false;
    while(puede)
    {
        foreach(Persona valor in dicPersonas.Values)
        {
            if(dni == valor.DNI)
            {
            puede = true;
            }
            else
            {
            dni = Funciones.IngresarEntero("Ingrese un DNI que no haya sido ingresado previamente: ");
            }
        }

    }
   
}
void MostrarEstadisticasCenso(int cantPersonas, int habilitados, int promedio)
{
    Console.WriteLine($"Cantidad de Personas: {cantPersonas}");
    Console.WriteLine($"Cantidad de Personas Habilitadas para votar: {habilitados}");
    Console.WriteLine($"Promedio edad: {promedio}");
}
