using Octobooks.Business.Interfaces;
using Octobooks.Domain.Models;
using Octobooks.Repository.Interfaces;
using Octobooks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Services
{
    public class ClientServices : IClientServices
    {
        private readonly IClientBusiness _clientBusiness;

        public ClientServices(IClientBusiness clientBusiness)
        {
            _clientBusiness = clientBusiness;
        }

        public void Delete(Client client)
        {
            _clientBusiness.Delete(client);
        }

        public List<Client> GetAll()
        {
            return _clientBusiness.GetAll();
        }

        public Client GetById(int id)
        {
            return _clientBusiness.GetById(id);
        }

        public Client Insert(Client client)
        {
            return _clientBusiness.Insert(client);
        }

       
    }
}
