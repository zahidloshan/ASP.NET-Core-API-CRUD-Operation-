using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Web_Application_CURD.Model
{
    public class Book
    {
        [Key]
        public  int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string Token { get; set; }
    }
}
