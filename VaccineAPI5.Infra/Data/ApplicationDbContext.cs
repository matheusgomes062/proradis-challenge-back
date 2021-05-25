using System;
using Microsoft.EntityFrameworkCore;

namespace VaccineAPI5.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
