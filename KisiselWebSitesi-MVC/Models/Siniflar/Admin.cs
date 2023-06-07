using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesi_MVC.Models
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
    }
}