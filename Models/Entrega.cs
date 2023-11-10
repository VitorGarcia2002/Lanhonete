namespace WebApplication1.Models
{
    public class Entrega
    {
        public int Id { get; set; }
        public Login Login { get; set; }
        public int loginId { get; set; }
        public string Endereço { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }
    }
}
