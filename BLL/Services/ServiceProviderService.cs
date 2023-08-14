using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.Services
{
    public class ServiceProviderService
    {
        public static List<ServiceProviderDTO> Get()
        {
            var data = DataAccessFactory.ServiceProviderData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                //c.CreateMap<ClientDTO, Client>();
                c.CreateMap<ServiceProvider, ServiceProviderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ServiceProviderDTO>>(data);
            return mapped;
        }

        public static ServiceProviderDTO Get(int id)
        {
            var data = DataAccessFactory.ServiceProviderData().Get();
            
            var cfg = new MapperConfiguration(c => {
               // c.CreateMap<ServiceProviderDTO, ServiceProvider>();
                c.CreateMap<ServiceProvider, ServiceProviderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped= mapper.Map<ServiceProviderDTO>(data);
            return mapped;
        }

        public static ServiceProvider Create(ServiceProviderDTO serviceProvider)
        {


            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ServiceProviderDTO, ServiceProvider>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ServiceProvider>(serviceProvider);
            var data = DataAccessFactory.ServiceProviderData().Add(mapped);

            return data;

        }

        public static ServiceProvider Update(ServiceProviderDTO serviceProvider)
        {


            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ServiceProviderDTO, ServiceProvider>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ServiceProvider>(serviceProvider);
            var data = DataAccessFactory.ServiceProviderData().Update(mapped);

            return data;

        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ServiceProviderData().Delete(id);

            return data;

        }



    }
}

