using System;

namespace ArbolBinarioMiguel
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node root = null;
            int option, key;

            do
            {
                Console.WriteLine("\n--- Menú de Operaciones ---");
                Console.WriteLine("1. Insertar un nodo");
                Console.WriteLine("2. Buscar un valor");
                Console.WriteLine("3. Recorrido en Preorden");
                Console.WriteLine("4. Recorrido en Inorden");
                Console.WriteLine("5. Recorrido en Postorden");
                Console.WriteLine("6. Eliminar un nodo");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Ingrese el valor a insertar: ");
                        key = int.Parse(Console.ReadLine());
                        root = bst.Insert(root, key);
                        Console.WriteLine("Valor insertado correctamente.");
                        break;

                    case 2:
                        Console.Write("Ingrese el valor a buscar: ");
                        key = int.Parse(Console.ReadLine());
                        Node result = bst.Search(root, key);
                        if (result != null)
                            Console.WriteLine("Valor encontrado en el árbol.");
                        else
                            Console.WriteLine("Valor no encontrado en el árbol.");
                        break;

                    case 3:
                        Console.Write("Recorrido en Preorden: ");
                        bst.Preorder(root);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Recorrido en Inorden: ");
                        bst.Inorder(root);
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("Recorrido en Postorden: ");
                        bst.Postorder(root);
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("Ingrese el valor a eliminar: ");
                        key = int.Parse(Console.ReadLine());
                        root = bst.Delete(root, key);
                        Console.WriteLine("Valor eliminado correctamente.");
                        break;

                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (option != 7);
        }
    }
} 