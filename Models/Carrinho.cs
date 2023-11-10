namespace WebApplication1.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public List<Lanches> Lanches { get; set; }
        public List<Bebidas> Bebidas { get; set; }
    }
}
