using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen4_Pt._1
{
    class Graph
    {
        public int Vertices { get; set; } // Atributo vertice del grafo
        readonly List<int>[] List; // Lista entera  se crea
        public Graph(int value) // Constructor
        {
            Vertices = value; // Vertice se igual al valor agregado 
            List = new List<int>[value]; // se agrega el valor del parametro
            for (int i = 0; i < value; i++) // un ciclo for para estar creando una lista
            {
                List[i] = new List<int>();
            }
        }

        public void Add(int Indice, int Valor) // Para agregar un valor a  la lista
        {
            List[Indice].Add(Valor); // agrega el valor que le des a la lista del indice
        }



        public void DFS(int Value, int Data) // Busca el camino al ultimo elemento
        {
            List<string> City = new List<string>();
            if (Data == 1 || Data == 2)
            {
                City.Add("Boston");
                City.Add("Chicago");
                City.Add("Denver");
                City.Add("LA");
                City.Add("New York");
                City.Add("San Francisco");
                City.Add("Miami");
                City.Add("Atlanta");
            }
            if (Data == 3)
            {
                City.Add("Atlanta");
                City.Add("Chicago");
                City.Add("San Francisco");
                City.Add("Boston");
                City.Add("Denver");
                City.Add("LA");
                City.Add("New York");
                City.Add("Miami");
            }
            if (Data == 4)
            {
                City.Add("Denver");
                City.Add("Chicago");
                City.Add("New York");
                City.Add("Atlanta");
                City.Add("San Francisco");
                City.Add("Boston");
                City.Add("LA");
                City.Add("Miami");
            }

            bool[] Visita = new bool[Vertices]; // crea una arreglo boleano de tamaño atributo vertices
            Stack<int> Stack = new Stack<int>(); // crea una pila 
            Visita[Value] = true; // el valor del arreglo con el parametro es igual a true
            Stack.Push(Value); // agrega el valor parametro a la pila
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("La ruta es: ");     // EL camino al ultimo elemento es       
            while (Stack.Count != 0) // mientras la pila no este vacio
            {
                Value = Stack.Pop(); // Valor se igual al ultmo elemento de la pila (lo saca)
                Console.Write("{0}-> ", City[Value]); // agrega el valor                
                foreach (int item in List[Value]) // por cada elemento entero en la lista de [Valor dado]
                {
                    if (!Visita[item]) // Si visita en la posicion item es diferente
                    {
                        Visita[item] = true; // esa posicion es igual a true
                        Stack.Push(item); // agrega el elemento item a la pila
                    }
                }
            }
            Console.Write("Fin de la ruta");
        }
    }
}
