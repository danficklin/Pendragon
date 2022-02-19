using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pendragon.Data
{
    public class PendragonDbContext : DbContext
    {
        public PendragonDbContext(DbContextOptions<PendragonDbContext> options) : base(options) 
        {
            
        }
    }
}