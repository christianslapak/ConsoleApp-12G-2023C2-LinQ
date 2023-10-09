using System;
using System.Linq;

namespace ConsoleApp_12G_2023C2_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiante[] misEstudiantes =
            {
                new Estudiante() {Id = 1, Nombre = "Magadalena", Edad = 18},
                new Estudiante() {Id = 2, Nombre = "Jorge", Edad = 29},
                new Estudiante() {Id = 3, Nombre = "Fernanda", Edad = 13},
                new Estudiante() {Id = 4, Nombre = "Javier", Edad = 17},
                new Estudiante() {Id = 5, Nombre = "Cecila", Edad = 22},
                new Estudiante() {Id = 6, Nombre = "Yamila", Edad = 31},
                new Estudiante() {Id = 7, Nombre = "Federico", Edad = 25},
                new Estudiante() {Id = 8, Nombre = "Miguel Angel", Edad = 34},
            };

            Estudiante[] estudiantesConsulta = new Estudiante[8];
            int x = 0;
            foreach (var item in misEstudiantes)
            {
                if (item.Edad >= 13 && item.Edad <= 21 ) //Filtrar
                {
                    estudiantesConsulta[x] = item;
                    x++;
                }
            }

            Console.WriteLine("Alumnos por bloque de codigo");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(estudiantesConsulta[i].Nombre.ToString() + " " + estudiantesConsulta[i].Edad);
            }


            Console.ReadKey();
            //LinQ - Expresion de Consulta
            Console.WriteLine("Alumnos por Expresion de Consulta con LinQ");

            var miConsultaLinQEC = from itemEstudiante in misEstudiantes where itemEstudiante.Edad >= 13 && itemEstudiante.Edad <= 21 orderby itemEstudiante.Nombre select itemEstudiante;
            foreach (var pepe in miConsultaLinQEC)
            {
                Console.WriteLine(pepe.Nombre + " " + pepe.Edad);
            }
            Console.ReadKey();

            //LinQ -Expresion Lambda
            Console.WriteLine("Alumnos por Expresion lambda con LinQ");
            var miConsultaLinQL = misEstudiantes.Where(itemEstu => itemEstu.Edad >= 13 && itemEstu.Edad <= 21).ToArray();
            foreach (var item in miConsultaLinQL)
            {

                Console.WriteLine(item.Nombre + " " + item.Edad);
            }
            Console.ReadKey();

            Console.WriteLine("Alumnos por Expresion de Consulta 2 con LinQ");
            var miConsultaLinQEC2 = from itemEstudiante in misEstudiantes where itemEstudiante.Nombre.StartsWith('F') orderby itemEstudiante.Edad select itemEstudiante;
            foreach (var pepe in miConsultaLinQEC2)
            {
                Console.WriteLine(pepe.Nombre + " " + pepe.Edad);
            }
            Console.ReadKey();

            Console.WriteLine("Traer uno");
            Estudiante unEstudiante = misEstudiantes.Where(itemEstu => itemEstu.Id == 5).FirstOrDefault();
            Console.WriteLine("Estudiante por Id " + unEstudiante.Nombre + " " + unEstudiante.Edad);

            Console.ReadKey();

        }
    }
}
