using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsClinica.Models;

namespace WindowsClinica.Data
{
    internal class DBClinicaEFContext : DbContext
    {
        public DBClinicaEFContext() : base("KeyDB") { }


        //Propiedades DB SET

        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
