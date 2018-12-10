using System;
using System.Collections.Generic;

namespace Busqueda_binaria
{
    class MainClass
    {
        public static void Datos()//Entrada de datos pura y dura
        {
            Console.WriteLine("\t\t\tBusquera binaria con enteros\n\n");
            Console.Write("Inserte el tamaño del arreglo: ");
            int tam = int.Parse(Console.ReadLine());//tamaño del arreglo
            int[] array = new int[tam];//se crea el arreglo por el usiario
            for (int i = 0; i < array.Length; i++)//entrada de datos de n numeros
            {
                Console.Write("Introduce el valor {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.Write("Que valor deseas saber si esta en el arreglo: ");//Se pide al usuario que valor va a buscar
            int buscar = int.Parse(Console.ReadLine());
            Array.Sort(array);//Se ordena el arreglo

            var valor = Buscar(array, buscar);//Declaramos una variable tipo var, si encuentra el numero pedido, la variable "valor" regresara la posicion,
                                              //si no, regresará un string "No se encontrø el valor".
            Console.WriteLine("El valor se encuentra en la posicion: " + valor);//Impresion de la posicion del valor
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t\t\tBusquera binaria con caracteres\n\n");
            Console.Write("Inserta el tamaño del siguiente arreglo de caracteres: ");//tamaño del arreglo de characteres
            int size = int.Parse(Console.ReadLine());
            char[] arreglo = new char[size];//se declara
            for (int i = 0; i < size; i++)//entrada de datos
            {
                Console.Write("\nIntroduce el caracter {0}: ", i + 1);
                arreglo[i] = Console.ReadKey().KeyChar;
            }
            Console.Write("\nQue caracter  deseas saber si esta en el arreglo: ");//Pedimos que caracter se dea buscar
            char search = Console.ReadKey().KeyChar;
            Array.Sort(arreglo);//Se ordena
            var charvalue = Buscar(arreglo, search);//Y básicamente hace lo mismo, si lo encuentra regresa la posicion, si no un string, como no se sabe
                                                    //declaramos con var.
            Console.WriteLine("\nEl valor se encuentra en la posicion: " + charvalue);
        }

        public static object Buscar(char[] arreglo, char numero)//El metodo buscar le llega el arreglo de caracteres y el caracter deseado a concoer si esta en la colección
        {
            int inferior = 0, superior = arreglo.Length - 1;//declaramos nuestra variable inferior a 0, y superior que sera el tamaño - 1


            while (inferior <= superior)//Mientras que inferior sea menor o igual a superior, se va a repetir
            {
                int centro = (inferior + superior) / 2;//Nuestro centro sera la mitad del arreglo
                if (arreglo[centro] == numero)//Si el valor que deseamos buscar, esta en el centro, quiere decir que se ha encontrado
                {
                    return ++centro;//Entocnes regresamos el centro incrementado en 1, para imprimir su posicion
                }
                else if (numero < arreglo[centro])//Si el caracter que desea encontrar, es menor al valor del centro del arreglo
                {
                    superior = centro - 1;//Superior va a disminuir porque quiere decir que se encuentra anter de la mitad del arreglo
                }
                else if (numero > arreglo[centro])//Si el caracter es mayor al valor de la mitad del arreglo
                {
                    inferior = centro + 1;//Inferior va a incrementar porque está después de la mitad del arreglo
                }

            }
            return "No se encontro el valor";//Si no se encuentra el valor, se regresa un string que dice que no se encontró
        }
        public static object Buscar(int[] arreglo, int numero)//Básicamente es lo mismo solo que en vez de buscar un caracter, va a buscar un entero
        {
            int inferior = 0, superior = arreglo.Length - 1;
          

            while(inferior <= superior)
            {
                int centro = (inferior + superior) / 2;
                if (arreglo[centro] == numero)
                {
                    return ++centro;
                }
                else if(numero < arreglo[centro])
                {
                    superior = centro - 1;
                }
                else if(numero > arreglo[centro])
                {
                    inferior = centro + 1;
                }

            }
            return "No se encontro el valor";

        }
        public static void Main(string[] args)
        {
            Datos();//Llamamos el metodo dato, que es la entrada de datos
            Console.ReadKey();
        }
    }
}
