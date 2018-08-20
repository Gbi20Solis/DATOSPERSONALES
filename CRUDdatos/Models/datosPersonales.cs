using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDdatos.Models
{
    public class datosPersonales
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string Telefono  { get; set; }
    }

    public class datosPersonalesContext : DbContext
    {
        public DbSet<datosPersonales> datosPersonales { get; set; }
    }
}