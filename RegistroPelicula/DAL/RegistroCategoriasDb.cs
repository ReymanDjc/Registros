using RegistroPelicula.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroPelicula.DAL
{
    public class RegistroCategoriasDb : DbContext
    {
        public DbSet<Categorias> categorias { get; set; }

        public RegistroCategoriasDb(): base("ConStr")
        {

        }

        
    }
}
