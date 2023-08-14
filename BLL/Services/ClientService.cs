using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientService
    {
        public static List<ClientDTO> Get()
        {
            var data = DataAccessFactory.ClientData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                //c.CreateMap<ClientDTO, Client>();
                c.CreateMap<Client, ClientDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ClientDTO>>(data);
            return mapped;
        }

        public static ClientDTO Get(string UserName)
        {
            var data = DataAccessFactory.ClientData().Get(UserName);

            var cfg = new MapperConfiguration(c => {
                //c.CreateMap<ClientDTO, Client>();
                c.CreateMap<Client, ClientDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ClientDTO>(data);
            return mapped;
        }

        public static Client Create(ClientDTO client)
        {


            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ClientDTO, Client>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Client>(client);
            var data = DataAccessFactory.ClientData().Add(mapped);

            return data;

        }

        public static Client Update(ClientDTO client)
        {
            

            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ClientDTO, Client>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Client>(client);
            var data = DataAccessFactory.ClientData().Update(mapped);

            return data;

        }

        public static bool Delete(string UserName)
        { 
            var data = DataAccessFactory.ClientData().Delete(UserName);

            return data;

        }



    }
}
