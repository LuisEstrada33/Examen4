using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen4
{
    class Letters
    {
        public void CallTree()
        {
            Tree Call = new Tree(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            Call.Insert(100, 'C');
            Call.Insert(90, 'B');
            Call.Insert(80, 'F');
            Call.Insert(70, 'E');
            Call.Insert(60, 'L');
            Call.Insert(50, 'K');
            Call.Insert(75, 'M');
            Call.Insert(91, 'G');
            Call.Insert(93, 'N');
            Call.Insert(92, 'R');
            Call.Insert(94, 'S');
            Call.Insert(110, 'D');
            Call.Insert(105, 'I');
            Call.Insert(104, 'H');
            Call.Insert(103, 'O');
            Call.Insert(120, 'J');
            Call.Insert(115, 'P');
            Call.Insert(130, 'Q');
            //Impresion en post-orden
            Console.WriteLine("Impresion postorden: ");
            Call.PrintPost();
            //Impresion en pre orden
            Console.WriteLine("Impresion preorden: ");
            Call.PrintPre();
        }

        public void Tree2()
        {
            Tree Call = new Tree(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            Call.Insert(100, 'A');
            Call.Insert(90, 'B');
            Call.Insert(80, 'C');
            Call.Insert(95, 'D');
            Call.Insert(110, 'E');
            Call.Insert(120, 'F');
            Call.Insert(115, 'G');
            Call.Insert(130, 'H');
            //Impresion en post-orden
            Console.WriteLine("Impresion postorden: ");
            Call.PrintPost();
            //Impresion en pre orden
            Console.WriteLine("Impresion preorden: ");
            Call.PrintPre();
            Console.ReadKey();
        }
    }
}
