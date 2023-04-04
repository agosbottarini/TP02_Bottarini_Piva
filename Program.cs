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