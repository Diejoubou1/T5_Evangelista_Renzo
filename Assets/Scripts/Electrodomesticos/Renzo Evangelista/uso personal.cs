using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TiendaElectrodomesticos
{
    class UsoPersonal : MonoBehaviour
    {
        public string nombre;
        public string modelo;
        public string marca;
        public double precio;
        public void cambiarprecio()
        {
            Console.WriteLine("Cambiar Precio (Precio Actual:" +  precio + ")");

            double nuevoprecio = Convert.ToDouble(Console.ReadLine());
            precio = nuevoprecio;
            Console.WriteLine("Nuevo precio: " + precio);
        }


        public UsoPersonal()
        {

        }

    }
}
