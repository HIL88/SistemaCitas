using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema.Models;

namespace Sistema.Datos
{
    public class contextoBD:DbContext
    {
        public contextoBD(DbContextOptions<contextoBD> options) : base(options)
        {

        }
        public DbSet<Cita> citas { get; set; }
    }
}
