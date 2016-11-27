using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetStarted.Entities
{
    public class GetStartedDbContext : IdentityDbContext<User>
    {
        public GetStartedDbContext(DbContextOptions<GetStartedDbContext> options)
            :base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
