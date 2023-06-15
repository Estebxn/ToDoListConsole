using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a mi lista de tareas\n");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("\n¿Qué quieres hacer?\n");
                Console.WriteLine("\nPresione 1 para ingresar tareas a la lista.");
                Console.WriteLine("\nPresione 2 para eliminar tareas de la lista.");
                Console.WriteLine("\nPresione 3 para ver la lista de tareas.");
                Console.WriteLine("\nPresione la tecla E para salir del programa.\n");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("\nPor favor ingrese el nombre de la tarea que quiere agregar a la lista.\n");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("\nLa tarea se agrego correctamente.");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }

                    Console.WriteLine("\nIngrese el numero de la tarea que quiere eliminar.\n");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("\nTareas actuales de la lista\n");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("\nCerrando el programa");
                }
                else
                {
                    Console.WriteLine("\nOpcion incorrecta, volver a intentar.");
                }
            }

            Console.WriteLine("\nGracias por usar mi aplicación");
        }
    }
}
