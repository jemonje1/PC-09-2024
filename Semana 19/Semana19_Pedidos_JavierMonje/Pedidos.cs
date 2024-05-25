namespace PedidosRestaurante
{
    public class Pedido
    {
        public double totalPedido;
        public DateTime fechaPedido = DateTime.Now;
        public string formaDePago;
        public List<string> PedidosRegistrados = new List<string>();
        public void AñadirPedido(string nuevoPedido)
        {
            PedidosRegistrados.Add(nuevoPedido);
        }
        public bool EliminarPedido()
        {
            int eliminador;
            if (int.TryParse(Console.ReadLine(), out eliminador) && eliminador >= 1 && eliminador <= PedidosRegistrados.Count)
            {
                PedidosRegistrados.RemoveAt(eliminador - 1);
                return true;
            }
            return false;
        }
        public void MostrarPedidos()
        {
            totalPedido = 20.00;
            formaDePago = "Tarjeta de débito";
            foreach (string pedido in PedidosRegistrados)
            {
                Console.WriteLine($"Fecha Pedido: {fechaPedido}\nForma de Pago en: {formaDePago}\nCon un total de: Q.{totalPedido}\nPedido: {pedido}");
            }
        }
    }
}