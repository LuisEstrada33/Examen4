using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen4_Pt._1
{
    class Operaciones
    {
        public void Graph()
        {
            Select:
            Console.Clear();
            Console.WriteLine("Seleccione la Ruta que desea mirar:\n1) Boston->LA\n2)NewYork->San Francisco\n3)Atlanta->San Francisco\n4)Denver->NewYork\n5)Salir");
            int Data = int.Parse(Console.ReadLine());
            if (Data == 1)
            {
                Graph Graph = new Graph(5);
                Graph.Add(0, 1);
                Graph.Add(1, 2);
                Graph.Add(2, 3);
                Graph.DFS(0, 1);
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Select;
            }

            if (Data == 2)
            {
                Graph Graph = new Graph(7);
                Graph.Add(0, 1);
                Graph.Add(1, 2);
                Graph.Add(2, 3);
                Graph.Add(4, 5);
                Graph.DFS(4, 2);
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Select;
            }

            if (Data == 3)
            {
                Graph Graph = new Graph(4);
                Graph.Add(0, 1);
                Graph.Add(1, 2);
                Graph.DFS(0, 3);
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Select;
            }

            if (Data == 4)
            {
                Graph Graph = new Graph(4);
                Graph.Add(0, 1);
                Graph.Add(1, 2);
                Graph.DFS(0, 4);
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Select;
            }
            if (Data == 5)
            {
                Console.Clear();
                Console.WriteLine("Presione una tecla para salir");
                Console.ReadKey();
            }
        }
    }
}
