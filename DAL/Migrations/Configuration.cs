namespace DAL.Migrations
{
    using DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Xml.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.FeedbackContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.FeedbackContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            for (int i = 1; i <= 10; i++)
            {
                context.Admins.AddOrUpdate(new Models.Admin
                {

                    UserName = "Admin_" + i,
                    Password = Guid.NewGuid().ToString().Substring(1, 15),
                    Name = Guid.NewGuid().ToString().Substring(1, 15),
                    Type = "Admin"

                }
                );
            }

            for (int i = 1; i <= 10; i++)
            {
                context.Clients.AddOrUpdate(new Models.Client
                {
                    Name = Guid.NewGuid().ToString().Substring(1, 15),
                    UserName = "Client_" + i,
                    Password = Guid.NewGuid().ToString().Substring(1, 15),
                    Type = "Regular"

                }
                );
            }
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                context.ServiceProviders.AddOrUpdate(new Models.ServiceProvider
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(1, 15),
                    shortDescriprtion = Guid.NewGuid().ToString(),
                    //Date = DateTime.Now,
                    AssignedBy = "Admin_" + random.Next(1, 19),
                    FeedbackBy = "Client" + random.Next(1, 19)

                }
                );
            }

            for (int i = 1; i <= 10; i++)
            {
                context.Feedbacks.AddOrUpdate(new Models.Feedback
                {
                    Id = i,

                    FeedbackDescription = Guid.NewGuid().ToString(),
                    Star = random.Next(1, 6),
                    Date = DateTime.Now,
                    ServiceProviderId = i + random.Next(1, 11),
                    FeedbackBy = "Client" + random.Next(1, 19)

                }
                );


            }


            context.Websites.AddOrUpdate(new Models.Website
            {
                Id = 1,

                Description = Guid.NewGuid().ToString(),
                FeedbackBy = "Client" + random.Next(1, 19),
                Date = DateTime.Now
                //ServiceProviderId = random.Next(1, 11),


            }
            );


        }
    }
}
