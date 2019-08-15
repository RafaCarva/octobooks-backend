using Dapper;
using Octobooks.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Repository.Interfaces
{
    /// <summary>
    /// Contract responsible for implementing generic crud
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : Entity
    {
        T Insert(T obj);
        bool Remove(T obj);
        List<T> GetAll();
        T GetById(int id);
        List<T> Query(string query, DynamicParameters parameters);
    }
}
