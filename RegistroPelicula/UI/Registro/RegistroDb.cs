using System;

namespace RegistroPelicula.UI.Registro
{
    internal class RegistroDb
    {
        public RegistroDb()
        {
        }

        public object Categorias { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}