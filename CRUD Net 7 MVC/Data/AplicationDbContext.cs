using CRUD_Net_7_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Net_7_MVC.Data
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {

        }

        //Se agregan los Modelos de la APP

        public DbSet<Contacto> Contactos { get; set; }

    }
}
