// See https://aka.ms/new-console-template for more information

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        //public string ceo;
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "Cra 9 calle 72";
            miEscuela.añoFundacion = 2012;
            Console.WriteLine("Timbre");
            //Console.WriteLine("Hello, World!");

        }
    }

}