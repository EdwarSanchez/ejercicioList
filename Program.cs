﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciacion de la lista
            List<Gato> gatos = new List<Gato>();
            //Declaracion de variables
            string nombre, color;
            int id = 0;
            int opcion = 0;
            int cantidad = 0;
            string leer = "";
            //Creacion de Menu
            while (opcion!=6)
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine("1.- Agregar");
                Console.WriteLine("2.- Agregar por bloque");
                Console.WriteLine("3.- Eliminar");
                Console.WriteLine("4.- Imprimir");
                Console.WriteLine("5.- Limpiar lista");
                Console.WriteLine("5.- Salir");
                Console.Write("Elija su opcion: ");
                leer = Console.ReadLine();
                opcion = Convert.ToInt32(leer);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el id del gato: ");
                        leer = Console.ReadLine();
                        id = Convert.ToInt32(leer);
                        Console.WriteLine("Ingrese el nombre del gato: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el color del gato");
                        color = Console.ReadLine();
                        gatos.Add(new Gato()
                        {
                            Id = id,
                            Nombre = nombre,
                            Color = color
                       

                        });
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la cantidad de gatos a agregar: ");
                        leer = Console.ReadLine();
                        cantidad = Convert.ToInt32(leer);
                        agregarBloque(cantidad, gatos);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el id del gato ha eliminar: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        eliminar(id, gatos);
                        break;
                    case 4:
                        imprimir(gatos);
                        break;
                    case 5:
                        gatos.Clear();
                        Console.WriteLine("La lista de gatos esta vacia.");
                        break;
                    case 6:
                        Console.WriteLine("Salio del programa");
                        Console.ReadKey();
                        break;
                    
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("La opcion no esta en el menu.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }


        }

        //Metodo para imprimir los elementos
        public static void imprimir(List<Gato> lista)
        {
            Console.WriteLine("Datos de los gatos");
            foreach (var gato in lista)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Id: "+gato.Id);
                Console.WriteLine("Nombre: " + gato.Nombre);
                Console.WriteLine("Color: " + gato.Color);
                Console.WriteLine("-------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }

        //Metodo para agregar en bloque
        public static void agregarBloque(int cantidad, List<Gato> lista)
        {
            //variables
            string nombre, color;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el nombre del gato: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el color del gato: ");
                color = Console.ReadLine();
                //Agregamos
                lista.Add(new Gato() {
                    Id = i + 345,
                    Nombre = nombre,
                    Color = color
                });
            }
        }

        //Metodo para eliminar
        public static void eliminar(int id, List<Gato> lista)
        {
            var elemento = lista.FirstOrDefault(g => g.Id == id);
            if (elemento != null)
            {
                lista.Remove(elemento);
                Console.WriteLine("el gato ha sido eliminado");
            }
            else
            {
                Console.WriteLine("El gato no existe en la lista");
            }
        }

        //
    
    }
}
