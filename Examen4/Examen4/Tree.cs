using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen4
{
    
        public class Nodo
        {
            public int info; //Guarda el valor que toma el nodo
            public Nodo left, right; //Punteros izquierda y derecha
            public char letter; //Letra del nodo
        }
    
        public class Tree
        {
            Nodo root; //Se crea el objeto raiz

            public Tree()
            {
                root= null; //El constructor inicializa raiz en nulo
            }

            public void Insert(int info, char letra)
            {
                Nodo New;
                New = new Nodo(); //Se inicializa nuevo de parte de Nodo
                New.info = info; //Se agrega el valor al nodo
                New.letter = letra; //Se agrega la letra al nodo
                New.left = null;
                New.right = null;
                if (root == null)
                    root = New; //Si raiz es nulo, se le asigna el primer valor ingresado
                else //De lo contrario se evaluan los valores de los nodos para ir acomodandolos
                {
                    Nodo previous = null, travel;
                    travel = root;
                    while (travel != null)
                    {
                        previous = travel;
                        if (info < travel.info)
                            travel = travel.left;
                        else
                            travel = travel.right;
                    }
                    if (info < previous.info)
                        previous.left = New;
                    else
                        previous.right = New;
                }
            }


            private void PrintPre(Nodo recorrido) //Se imprime el pre orden
            {
                if (recorrido != null)
                {
                    Console.Write(recorrido.letter + " ");
                    PrintPre(recorrido.left);
                    PrintPre(recorrido.right);
                }
            }

            public void PrintPre()
            {
                PrintPre(root);
                Console.WriteLine();
            }

            private void ImprimirEntre(Nodo recorrido) //Se imprime el inorden
            {
                if (recorrido != null)
                {
                    ImprimirEntre(recorrido.left);
                    Console.Write(recorrido.letter + " ");
                    ImprimirEntre(recorrido.right);
                }
            }

            public void PrintEntre()
            {
                ImprimirEntre(root);
                Console.WriteLine();
            }


            private void PrintPost(Nodo recorrido) //Se imprime el post-orden
            {
                if (recorrido != null)
                {
                    PrintPost(recorrido.left);
                    PrintPost(recorrido.right);
                    Console.Write(recorrido.letter + " ");
                }
            }
            public void PrintPost()
            {
                PrintPost(root);
                Console.WriteLine();
            }
        }
    
}
