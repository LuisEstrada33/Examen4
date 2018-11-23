using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen4
{
    class Program
    {
        static void Main(string[] args)
        {
            Letters obj = new Letters();
            Console.WriteLine("Árbol número 1: ");
            obj.CallTree();

            Console.WriteLine("\nÁrbol número 2:");
            obj.Tree2();
        }
    }
}
