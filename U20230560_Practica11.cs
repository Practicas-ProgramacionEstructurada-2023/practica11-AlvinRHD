using System;

namespace practica11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opc;

            do
            {
                Console.WriteLine("\n\nMenu de opciones : ");
                Console.WriteLine("1. Ingresar numeros");
                Console.WriteLine("2. Calcular suma de numeros");
                Console.WriteLine("3. Buscar numero");
                Console.WriteLine("4. Ordenar numeros");
                Console.WriteLine("5. Salir");
                Console.WriteLine("\nSeleccione una opcion (1-5): ");

                if (int.TryParse(Console.ReadLine(), out opc))
                {
                    switch (opc)
                    {
                        case 1:

                            IngresarNumeros();
                            Console.ReadKey();

                            break;
                        case 2:

                            int suma = CalcularSuma();
                            Console.WriteLine("\nLa suma de los numeros es:" + suma);
                            Console.ReadKey();

                            break;
                        case 3:

                            BuscarNumero();
                            Console.ReadKey();

                            break;

                        case 4:

                            OrdenarNumeros();
                            Console.ReadKey();

                            break;
                        case 5:

                            Console.WriteLine("\n¡Hasta luego!");

                            break;
                        default:
                            Console.WriteLine("Opcion no valida, porfavor, seleccione una opcion valida (1-5)");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada no valida, debe ingresar un numero (1-3).");
                }

            } while (opc != 5);
        }//FIN DEL MAIN

        static int[] numeros = new int[5];//arreglo para almacenar numeros

        static int cantidadNumeros = 0;// contador para rastrear la cantidad de numeros ingresados

        static void IngresarNumeros()
        {
            Console.WriteLine("\nIngresa hasta 5 numeros (ingresa -1 para finalizar): ");
            cantidadNumeros = 0;

            while (cantidadNumeros < numeros.Length)
            {
                Console.WriteLine("Numero #{0}: ", cantidadNumeros + 1);
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1)
                    break;

                numeros[cantidadNumeros] = numero;
                cantidadNumeros++;
            }

        }//Ingresar numero fin

        static int CalcularSuma()
        {
            int suma = 0;
            for (int i = 0; i < cantidadNumeros; i++)
            {
                suma += numeros[i];
            }
            return suma;
        }//Calcular suma fin

        static void BuscarNumero()
        {
            Console.Write("\nIngrese el numero que deseas buscar: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                Console.WriteLine("\nEl numero fue encontrado en el arreglo.");

            else
                Console.WriteLine("\nEl numero no fue encontrado en el arreglo.");
        }//Buscar numero fin

        static void OrdenarNumeros()
        {
            Array.Sort(numeros, 0, cantidadNumeros);
            Console.WriteLine("\nNumeros ordenados de manera ascendente");
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }//ordenar numeros fin
    }
}

