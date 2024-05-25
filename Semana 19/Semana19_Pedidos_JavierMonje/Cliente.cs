namespace PedidosRestaurante
{
    public class Cliente
    {
        public string nombreCliente { get; set; }
        public string direccionCliente { get; set; }
        public int numeroTelefono { get; set; }
        public string comidaElegida { get; set; }
        public Cliente(string nombre, string direccion, int telefono)
        {
            nombreCliente = nombre;
            direccionCliente = direccion;
            numeroTelefono = telefono;
        }
        public void DatosPedido(string comidaCliente, Pedido operacionesPedidos)
        {
            comidaElegida = comidaCliente;
            operacionesPedidos.AñadirPedido($"El cliente {nombreCliente} de dirección {direccionCliente}, número de teléfono {numeroTelefono}. Realizó pedido de: {comidaElegida}.");
        }
    }
}