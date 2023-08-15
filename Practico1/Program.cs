using Shared;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataAccessLayer.IDALs;

IDAL_Persona _personas = new DAL_Persona();

do
{
    try
    {
        Console.WriteLine("Nueva Persona");
        Persona p = new Persona();
        Console.WriteLine("Ingrese el nombre de una persona");
        p.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el documento de una persona");
        p.Documento = Console.ReadLine();
        _personas.Insert(p);
        _personas.GetPersonas().ForEach(p => p.Print());
    }
    catch(Exception e)
    {
        Console.WriteLine( e.ToString()); 
    }

} while (!Console.ReadLine().Equals("EXIT"));

