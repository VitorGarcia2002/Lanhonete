namespace WebApplication1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Endereço { get; set; }
        public int LoginId { get; set; }
        public required  Login Login { get; set; }


    }
}
