using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES

            //Declaracion de variables de tipo texto con captura desde consola

            string? universidad="";

            //Declarar variables de tipo texto con asignacion desde codigo

            string facultad="Ingenieria y Arquitectura";
            string profesion="Ingeniero en Desarrollo de Software";

            //Declaracion de variables entera captura desde consola

            int añoIngreso=0;

            //Declaracion de variables enteras asignando valores

            int edadIngreso=26;
            int edadEgreso=31;

            //Declaracion de variable double asignando valor desde consola

            double cuotaUniversidad=0.0;

            //Declaracion de variables decimales asignando valores

            double gastoTransorte=35.50;

            //CAPTURA DE DATOS DESDE CONSOLA

            Console.WriteLine("\n******************************************");
            Console.WriteLine("\n---Capturando datos de tipo texto----");
            Console.WriteLine("Ingrese el nombre de la universidad donde estudia>>");
            universidad=Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n---Fin de captura datos de tipo texto----");

            Console.WriteLine("\n---Capturando datos de tipo enteros----");
            Console.WriteLine("Ingrese el año que inicio la universidad>>");
            añoIngreso=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n---Fin de captura datos de tipo enteros----");

            Console.WriteLine("\n---Capturando datos de tipo decimal----");
            Console.WriteLine("Ingrese la cuota de la universidad>>");
            cuotaUniversidad=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n---Fin de captura datos de tipo decimal----");
            Console.WriteLine("******************************************\n");

            //IMPRESION DE DATOS EN CONSOLA
            Console.WriteLine("*****************************************\n\n");
            Console.WriteLine("\n---Impresion de datos de tipo texto----");
            Console.WriteLine("\n La universidad donde estudia es >>" + universidad);
            Console.WriteLine("\n Pertenece a la facultad de >>" + facultad);
            Console.WriteLine("\n Estudia la carrera de >>" + profesion);
            Console.WriteLine("\n*****************************************\n");

            Console.WriteLine("*****************************************\n\n");
            Console.WriteLine("\n---Impresion de datos de tipo entero----");
            Console.WriteLine("\n El año que ingreso a la universidad fue >>" + añoIngreso);
            Console.WriteLine("\n La edad cuando inicio sus estudios es >>" + edadIngreso +" años");
            Console.WriteLine("\n La edad cuando finalice sus estudios sera >>" + edadEgreso +" años");
            Console.WriteLine("\n*****************************************\n");

            Console.WriteLine("*****************************************\n\n");
            Console.WriteLine("\n---Impresion de datos de tipo double----");
            Console.WriteLine("\n La cuota de su universidad es >>" +"$"+ cuotaUniversidad);
            Console.WriteLine("\n Su gasto en transporte es >>" +"$"+ gastoTransorte);
            Console.WriteLine("\n*****************************************\n");

            Console.ReadKey();


        }
    }
}