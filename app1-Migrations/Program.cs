using app1_Migrations.Modelos;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        agregarCliente();
        consultarCliente();
        modificarCliente();
        eliminarCliente();
        consultarClienteFunciones();
    }

    //agregar estudiante
    public static void agregarCliente()
    {
        AplicationDbContext context = new AplicationDbContext();

        Console.WriteLine("Metodo agregar estudiante");
        Cliente user = new Cliente();
        user.Nombre = "aa";
        user.Apellido = "aa";
        user.Direccion = "a";
        user.Telefono = "a";
        user.Fecha_nac = "a";
        user.Estado = true;
        context.Clientes.Add(user);
        context.SaveChanges();

        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Nombre);
    }

    public static void consultarCliente()
    {
        AplicationDbContext context = new AplicationDbContext();
        List<Cliente> listClientes = context.Clientes.ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Name: " + item.Nombre);
        }
    }

    public static void modificarCliente()
    {
        Console.WriteLine("Metodo consultar estudiante por Id");
        AplicationDbContext context = new AplicationDbContext();
        Cliente user = new Cliente();
        user = context.Clientes.Find(1);

        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Nombre);
    }

    public static void eliminarCliente()
    {
        Console.WriteLine("Metodo eliminar estudiante");
        AplicationDbContext context = new AplicationDbContext();
        Cliente user = new Cliente();
        user = context.Clientes.Find(5);
        context.Remove(user);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Nombre);
    }
    
    public static void consultarClienteFunciones()
    {
        Console.WriteLine("Metodo consultar estudiantes con el uso de funciones");
        AplicationDbContext context = new AplicationDbContext();
        List<Cliente> listClientes;
        Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
        Cliente user = context.Clientes.First();
        Console.WriteLine("Primer elemento de la tabla:" + user.Id + "-" + user.Nombre);
        listClientes = context.Clientes.Where(s => s.Name.StartsWith("A")).ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Name: " + item.Nombre);
        }
    }
}