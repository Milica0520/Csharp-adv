
using TaxiManager9000.Enums;

namespace TaxiManager9000.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 
        public Role Role { get; set; }


    }
}
