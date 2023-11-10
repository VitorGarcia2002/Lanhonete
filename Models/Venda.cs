namespace WebApplication1.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int EntregaId {  get; set; }
        public required Cliente Cliente { get; set;}
        public required Entrega Entrega { get; set; }



    }
}
