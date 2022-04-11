// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;
class program
{
    static void Main(string[] args)
    {
        var escuela = new Escuela("Platzi Academy", 2012);
        Console.WriteLine(escuela.Nombre);
    }
}


