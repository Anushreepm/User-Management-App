 using System.ComponentModel.DataAnnotations;

namespace UsersCRUDApp.Models
{    public class User
    {
        [Key] // This attribute specifies the primary key
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
    }
}

