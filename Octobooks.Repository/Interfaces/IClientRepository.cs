using Dapper;
using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Repository.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        Client Insert(Client obj);
        bool Remove(Client obj);
        List<Client> GetAll();
        Client GetById(int id);
        List<Client> Query(string query, DynamicParameters parameters);
    }
}
