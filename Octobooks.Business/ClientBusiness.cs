using System;
using System.Collections.Generic;
using System.Text;
using Octobooks.Business.Interfaces;
using Octobooks.Domain.Models;
using Octobooks.Repository.Interfaces;

namespace Octobooks.Business
{
    public class ClientBusiness : IClientBusiness
    {
        private readonly IClientRepository _clientRepository;

        public ClientBusiness(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Delete(Client client)
        {
            _clientRepository.Remove(client);
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public Client Insert(Client client)
        {
            return _clientRepository.Insert(client);
        }
    }
}
