using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Evolent.Core.Models;

namespace Evolent.Data
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Contact> contacts { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
