//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBibliotecaOnline2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Dani_BibIiotecaEntities : DbContext
    {
        public Dani_BibIiotecaEntities()
            : base("name=Dani_BibIiotecaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Biblioteca> Biblioteca { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<TipoBiblioteca> TipoBiblioteca { get; set; }
    }
}
