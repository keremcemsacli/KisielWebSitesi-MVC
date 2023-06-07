using System.Data.Entity;

namespace KisiselWebSitesi_MVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> Anasayfas { get; set; }
        public DbSet<ikonlar> ikonlars { get; set; }
    }
}