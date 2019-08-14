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
        private readonly IClientRepository _clientRepository;

        public ClientServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Delete(Guid key)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public List<Client> GetByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public Client Insert(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
