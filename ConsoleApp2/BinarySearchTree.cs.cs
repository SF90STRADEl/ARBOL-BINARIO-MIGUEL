using System;

namespace ArbolBinarioMiguel
{
   
    public class BinarySearchTree
    {
        // Método para insertar un nodo en el árbol
        public Node Insert(Node root, int key)
        {
            if (root == null)
                return new Node(key);

            // Evitar duplicados
            if (key == root.Key)
                return root;

            if (key < root.Key)
                root.Left = Insert(root.Left, key);
            else if (key > root.Key)
                root.Right = Insert(root.Right, key);

            return root;
        }

        // Método para buscar un valor en el árbol
        public Node Search(Node root, int key)
        {
            if (root == null || root.Key == key)
                return root;

            if (key < root.Key)
                return Search(root.Left, key);

            return Search(root.Right, key);
        }

        // Método para eliminar un nodo del árbol
        public Node Delete(Node root, int key)
        {
            if (root == null)
                return root;

            if (key < root.Key)
                root.Left = Delete(root.Left, key);
            else if (key > root.Key)
                root.Right = Delete(root.Right, key);
            else
            {
                
                if (root.Left == null)
                    return root.Right;
                if (root.Right == null)
                    return root.Left;

                
                root.Key = MinValue(root.Right);

                // Eliminar el sucesor
                root.Right = Delete(root.Right, root.Key);
            }
            return root;
        }

        // Método para encontrar el valor mínimo en un subárbol
        private int MinValue(Node root)
        {
            int minValue = root.Key;
            while (root.Left != null)
            {
                minValue = root.Left.Key;
                root = root.Left;
            }
            return minValue;
        }

        // Método para recorrido en preorden
        public void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Key + " ");
                Preorder(root.Left);
                Preorder(root.Right);
            }
        }

        // Método para recorrido en inorden
        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.Left);
                Console.Write(root.Key + " ");
                Inorder(root.Right);
            }
        }

        // Método para recorrido en postorden
        public void Postorder(Node root)
        {
            if (root != null)
            {
                Postorder(root.Left);
                Postorder(root.Right);
                Console.Write(root.Key + " ");
            }
        }
    }
}