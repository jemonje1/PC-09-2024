namespace PedidosRestaurante
{
    public class Restaurante
    {
        public string sedeRestaurante { get; set; }
        public Pedido OperacionesPedidos = new Pedido();
        static void Main(string[] args)
        {
            Restaurante restaurante = new Restaurante();
            restaurante.RegistrarPedidos();
        }
        public void RegistrarPedidos()
        {
            bool salirMenú = false;
            sedeRestaurante = "Sede 01 Villa Nueva";
            Pedido operacionesPedidos = new Pedido();
            Cliente cliente1 = new Cliente("Mario Arévalo", "12 calle A, 5-21", 12345678);
            cliente1.DatosPedido("Carne Asada con papas", operacionesPedidos);
            Cliente cliente2 = new Cliente("Heidy Monterros", "14 avenida B, 8-30", 87654321);
            cliente2.DatosPedido("Pollo a la parrilla", operacionesPedidos);
            do
            {
                Console.WriteLine($"Registro de Pedidos para la {sedeRestaurante}\n1. Ver pedido\n2. Eliminar el pedido\n3. Salir");
                string opciones = Console.ReadLine();
                switch (opciones)
                {
                    case "1":
                        operacionesPedidos.MostrarPedidos();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el número de pedido que desee eliminar");
                        if (!operacionesPedidos.EliminarPedido())
                        {
                            Console.WriteLine("Número de pedido no válido.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Chauuuu chauuuu");
                        salirMenú = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (!salirMenú);
        }
    }
}
