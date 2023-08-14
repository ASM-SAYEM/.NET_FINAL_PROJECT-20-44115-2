using DAL.Interface;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Client,string,Client> ClientData()
        {
            return new ClientRepo();
        }

        public static IRepo<Admin, string, Admin> AdminData()
        {
            return new AdminRepo();
        }

        public static IRepo<ServiceProvider, int, ServiceProvider> ServiceProviderData()
        {
            return new ServiceProviderRepo();
        }

        public static IRepo<Feedback, int, Feedback> FeedbackData()
        {
            return new FeedbackRepo();
        }

        public static IRepo<Website, int, Website> WebsiteData()
        {
            return new WebsiteRepo();
        }

    }
}
