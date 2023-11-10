namespace WebApplication1.Models
{
    public class Login
    {
        public int Id { get; set; }
        public required string Password { get; set; }    
        public required string Email { get; set; }

    }
}
