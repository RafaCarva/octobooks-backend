using Dapper;
using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Repository.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        new Client Insert(Client obj);
        new bool Remove(Client obj);
        new List<Client> GetAll();
        new Client GetById(int id);
        new List<Client> Query(string query, DynamicParameters parameters);
    }
}
