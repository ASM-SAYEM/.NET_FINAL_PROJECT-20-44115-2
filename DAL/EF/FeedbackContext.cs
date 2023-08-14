using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class FeedbackContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
        public DbSet<Website> Websites { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

    }
}
