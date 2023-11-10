namespace WebApplication1.Models
{
    public class PedidoBebida
    {
        public int VendaId { get; set; }
        public int BebidasId { get; set; }
        public required Venda Venda { get; set; }
        public required Bebidas Bebidas { get; set; }    

    }
}
