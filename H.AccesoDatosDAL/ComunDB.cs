using H.EntidadesNegocioEN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace H.AccesoDatosDAL
{
    public class ComunDB : DbContext
    {

        public DbSet<PersonaH> PersonasH { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=emmabook\\SQLEXPRESS;Initial Catalog=HDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
