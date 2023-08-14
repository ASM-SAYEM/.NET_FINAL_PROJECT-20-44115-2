using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ClientRepo : Repo, IRepo<Client, string, Client>
    {
        public Client Add(Client obj)
        {
            db.Clients.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Get(id);
            db.Clients.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Client> Get()
        {
           return db.Clients.ToList();
        }

        public Client Get(string UserName)
        {
            return db.Clients.FirstOrDefault(t=>t.UserName== UserName);
        }

        public Client Update(Client obj)
        {
            var ex = Get(obj.UserName);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }

            return null;
        }
    }
}
