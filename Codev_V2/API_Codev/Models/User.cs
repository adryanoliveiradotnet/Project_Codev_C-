using System.Data;

namespace API_Codev.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = "";
        public string Senha { get; set; } = "";
        public bool AppStatus { get; set; } = true;
        public DateTime Data { get; set; } = DateTime.UtcNow;
    }
}
