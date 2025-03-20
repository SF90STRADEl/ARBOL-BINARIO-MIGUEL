using System;

namespace ArbolBinarioMiguel
{
    // Clase que representa un nodo del árbol
    public class Node
    {
        public int Key;           // Valor del nodo
        public Node Left, Right;  //  hijos izquierdo y derecho

       
        public Node(int item)
        {
            Key = item;
            Left = Right = null;
        }
    }
}