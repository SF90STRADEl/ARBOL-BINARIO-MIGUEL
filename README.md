Árbol Binario de Búsqueda (ABB) en C#
Este proyecto implementa un Árbol Binario de Búsqueda (ABB) en C#. Incluye funcionalidades básicas como inserción, búsqueda, eliminación de nodos y recorridos (preorden, inorden y postorden). Además, cuenta con un menú interactivo para que el usuario pueda interactuar con el árbol.

Características
Inserción de nodos: Permite agregar valores al árbol manteniendo las propiedades del ABB.

Búsqueda de valores: Busca un valor específico en el árbol.

Eliminación de nodos: Elimina un valor del árbol manteniendo las propiedades del ABB.

Recorridos:

Preorden: Visita la raíz, luego el subárbol izquierdo y finalmente el subárbol derecho.

Inorden: Visita el subárbol izquierdo, luego la raíz y finalmente el subárbol derecho (devuelve los valores en orden ascendente).

Postorden: Visita el subárbol izquierdo, luego el subárbol derecho y finalmente la raíz.

Menú interactivo: Permite al usuario realizar operaciones en el árbol de manera sencilla.

Estructura del Proyecto
El proyecto está organizado en tres clases principales:

Node:

Representa un nodo del árbol.

Contiene un valor (Key) y referencias a sus hijos izquierdo (Left) y derecho (Right).

BinarySearchTree:

Contiene las operaciones del árbol:

Inserción (Insert).

Búsqueda (Search).

Eliminación (Delete).

Recorridos (Preorder, Inorder, Postorder).

Program:

Contiene el método Main y el menú interactivo.

Permite al usuario interactuar con el árbol.
