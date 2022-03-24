using FindHome_Entity;
using FindHome_Entity.IdentityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_DAL
{
    public class Context: IdentityDbContext<AppUser, AppRole, string>
    {
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }
        public DbSet<Housing> Housings { get; set; }
        public DbSet<HousingType> HousingTypes { get; set; }
        public DbSet<BuyingType> BuyingTypes { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}

