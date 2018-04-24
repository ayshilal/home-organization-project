using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace C2T.WebApi
{
    public class ACQUIRERContext : DbContext
    {
        public ACQUIRERContext(DbContextOptions<ACQUIRERContext> options)
           : base(options) { }
      
        public DbSet<ACQUIRER> ACQUIRERList { get; set; }
    }
}
