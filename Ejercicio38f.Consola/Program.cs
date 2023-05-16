using System.ComponentModel;

namespace Ejercicio38f.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nro. del mes:");
            var nroMes = int.Parse(Console.ReadLine());
            if (ValidarMes(nroMes))
            {
                var nombreMes = DevolverNombreDelMes(nroMes);
                var trimestre = DevolverTrimestre(nroMes);
                Console.WriteLine($"{nroMes} corresponde al mes de {nombreMes} que pertenece al {trimestre}");
            }
            else
            {
                Console.WriteLine("Nro de mes no válido");
            }
        }

        private static string DevolverTrimestre(int nroMes)
        {
            string nombre = "";
            switch (nroMes)
            {
                case 1:
                case 2:
                case 3:
                    nombre = "primer trimestre";
                    break;
                case 4:
                case 5:

                case 6:
                    nombre = "segundo trimestre";
                    break;
                case 7:

                case 8:

                case 9:
                    nombre = "tercer trimestre";
                    break;

                default:
                    nombre = "cuarto trimestre";
                    break;
            }
            return nombre;
        }

        private static string DevolverNombreDelMes(int nroMes)
        {
            string nombre = "";
            switch (nroMes)
            {
                case 1:
                    nombre = "Enero";
                    break;
                case 2:
                    nombre = "Febrero";
                    break;
                case 3:
                    nombre = "Marzo";
                    break;
                case 4:
                    nombre = "Abril";
                    break;
                case 5:
                    nombre = "Mayo";
                    break;
                case 6:
                    nombre = "Junio";
                    break;
                case 7:
                    nombre = "Julio";
                    break;
                case 8:
                    nombre = "Agosto";
                    break;
                case 9:
                    nombre = "Septiembre";
                    break;
                case 10:
                    nombre = "Octubre";
                    break;
                case 11:
                    nombre = "Noviembre";
                    break;
                default:
                    nombre = "Diciembre";
                    break;
            }
            return nombre;
        }

        private static bool ValidarMes(int nroMes) => nroMes >= 1 && nroMes <= 12;
    }
}