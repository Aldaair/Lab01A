// See https://aka.ms/new-console-template for more information
using Lab01A;

Console.WriteLine("Hello, World!");

Usuario usuario = new Usuario("Juan", 100);

Empleado empleado = new Empleado("Aldair", 122, 22);

List<Usuario> usuarios = new List<Usuario> {
    usuario, empleado
};

Grifo a = new Grifo(usuarios);

bool salir = false;

while (!salir)
{
    Console.WriteLine("¡Bienvenid@!!");
    Console.WriteLine("1. Mostrar informacion de usuarios");
    Console.WriteLine("2. Agregar cliente");
    Console.WriteLine("3. Agregar empleado");
    Console.WriteLine("4. Salir");
    Console.Write("Elige una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            a.MostrarUsuarios(a.Griferos);
            break;
        case "2":
            Console.WriteLine("Agregar cliente: ");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Saldo: ");
            if (double.TryParse(Console.ReadLine(), out double saldo))
            {
                Console.Write("Sueldo: ");
                if (double.TryParse(Console.ReadLine(), out double sueldo))
                {
                    // Crear una instancia de Cliente con la información proporcionada
                    Cliente nuevoCliente = new Cliente(nombre, saldo, sueldo);
                    // Agregar el cliente a tu colección o realizar otras acciones necesarias
                    // (Por ejemplo, podrías tener una lista de clientes para mantener un registro)
                    usuarios.Add(nuevoCliente);

                    Console.WriteLine("Cliente agregado con éxito.");
                }
                else
                {
                    Console.WriteLine("El sueldo debe ser un número válido.");
                }
            }
            else
            {
                Console.WriteLine("El saldo debe ser un número válido.");
            }
            break;
        case "3":
            Console.WriteLine("Agregar empleado: ");
            Console.Write("Nombre: ");
            string nombreEmpleado = Console.ReadLine();

            Console.Write("Saldo: ");
            if (double.TryParse(Console.ReadLine(), out double saldoEmpleado))
            {
                Console.Write("Sueldo: ");
                if (double.TryParse(Console.ReadLine(), out double sueldoEmpleado))
                {
                    // Crear una instancia de Empleado con la información proporcionada
                    Empleado nuevoEmpleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
                    // Agregar el empleado a tu colección o realizar otras acciones necesarias
                    // (Por ejemplo, podrías tener una lista de empleados para mantener un registro)
                    usuarios.Add(nuevoEmpleado);
                    Console.WriteLine("Empleado agregado con éxito.");
                }
                else
                {
                    Console.WriteLine("El sueldo debe ser un número válido.");
                }
            }
            else
            {
                Console.WriteLine("El saldo debe ser un número válido.");
            }
            break;
        case "4":
            salir = true;
            Console.WriteLine("¡Hasta luego!");
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
            break;
    }

    Console.WriteLine();
}