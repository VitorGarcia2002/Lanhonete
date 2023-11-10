namespace WebApplication1.Models
{
    public class PedidoLanche
    {
        public int VendaId { get; set; }
        public int LanchesId { get; set; }
        public int Quantidade { get; set; }
        public required Lanches Lanches { get; set; }
        public required Venda Venda { get; set; }

    }
}
