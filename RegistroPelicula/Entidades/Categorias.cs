using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroPelicula.Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }

        public Categorias()
        {
        }

        public Categorias(string descripcion)
        {
            Descripcion = descripcion;
        }

    }   
}
