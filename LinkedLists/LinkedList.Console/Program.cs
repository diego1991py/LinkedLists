using SimpleList;

var list = new SingleSimpleList<string>();
var option = string.Empty;
var value = string.Empty;

do
{
    option = Menu();

    switch (option)
    {
        case "1":
            Console.Write("Ingrese el nombre a insertar: ");
            value = Console.ReadLine() ?? string.Empty;
            list.InsertAtBeginning(value);
            break;
        case "2":
            Console.Write("Ingrese el nombre a insertar: ");
            value = Console.ReadLine() ?? string.Empty;
            list.InsertAtEnd(value);
            break;
        case "3":
            Console.WriteLine(list);
            break;
        case "4":
            Console.Write("Ingrese el nombre a buscar: ");
            var searchValue = Console.ReadLine() ?? string.Empty;
            list.Contains(searchValue);
            if (list.Contains(searchValue))
            {
                Console.WriteLine($"El elemento '{searchValue}' se encuentra en la lista.");
            }
            else
            {
                Console.WriteLine($"El elemento '{searchValue}' no se encuentra en la lista.");
            }
            break;
        case "5":
            Console.Write("Ingrese el nombre a eliminar: ");
            var deleteValue = Console.ReadLine() ?? string.Empty;
            list.Remove(deleteValue);

            break;
        case "0":
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
    }

} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Insertar al inicio");
    Console.WriteLine("2. Insertar al inicio");
    Console.WriteLine("3. Mostrar la lista");
    Console.WriteLine("4. Buscar un elemento");
    Console.WriteLine("5. Eliminar un elemento");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    return Console.ReadLine() ?? string.Empty;
}