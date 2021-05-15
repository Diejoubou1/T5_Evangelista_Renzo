using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaElectrodomesticos;

namespace ConsoleApp1
{
    class Program
    {
        static void Clases()
        {
            Console.WriteLine("Selecione la Seccion");
            Console.WriteLine("1 - Estetica");
            Console.WriteLine("2 - HigienePersonal");


        }
        static void Main(string[] args)
        {
            bool nextLoop = true;

            while (nextLoop)
            {
                Console.Clear();
                Loop();

                Console.WriteLine("Continue? (Y/N)");
                string next = Console.ReadLine();

                if (next.ToUpper() != "Y")
                    nextLoop = false;

            }

        }
        static UsoPersonal EsteticaObjects()
        {
            UsoPersonal Elementos = null;
            Console.WriteLine("Selecione la Objetos");
            Console.WriteLine("1 - AlisadoraDePelo");
            Console.WriteLine("2 - RizadoraDePelo");
            string str = Console.ReadLine();

            /*switch (str)
            {
                case "1":
                    Elementos = new AlisadoraDePelo(name);
                    break;

                case "2":
                    Elementos = new RizadoraDePelo(name);
                    break;

                default:
                    Console.WriteLine("Objeto no encontrado");
                    break;
            }
            */

            return Elementos;
        }
        static UsoPersonal HigienePersonalObjects()
        {
            UsoPersonal Elementos = null;
            Console.WriteLine("Selecione la Objetos");
            Console.WriteLine("1 - Depilora");
            Console.WriteLine("2 - Afeitadora");
            Console.WriteLine("3 - CepilloElectrico");

            string str = Console.ReadLine();

            /*switch (str)
            {
                case "1":
                    Elementos = new Afeitadora(name);
                    break;

                case "2":
                    Elementos = new Depiladora(name);
                    break;
                case "3":
                    Elementos = new CepilloElectrico(name);
                    break;
                default:
                    Console.WriteLine("Objeto no encontrado");
                    break;
            }*/

            return Elementos;
        }

        static void Loop()
        {
            Console.WriteLine("Enter para empezar a editar el precio");
            Console.ReadLine();
            UsoPersonal secciones = null;
            Clases();
            string STR = Console.ReadLine();
            /*switch (STR)
            {
                case "1":
                    secciones = EsteticaObjects();
                    break;

                case "2":
                    secciones = HigienePersonalObjects();
                    break;
                default:
                    Console.WriteLine("Objeto no encontrado");
                    break;
            }*/
        }


    }

}