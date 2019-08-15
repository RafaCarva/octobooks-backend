using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using Dapper.Contrib.Extensions;
using Octobooks.Domain.Base;
using Octobooks.Repository.Interfaces;
using Microsoft.Extensions.Configuration;


namespace Octobooks.Repository.Base
{
    public class Repository<T>: IRepository<T> where T : Entity
    {

        private readonly IConfiguration _config;

        public Repository( IConfiguration config)
        {
            _config = config;
        }

        private IDbConnection Conn => new SqlConnection(_config.GetConnectionString("DefaultConnection"));

        public List<T> Query(string query, DynamicParameters parameters = null)
        {
            try
            {
                if (parameters == null)
                    return Conn.Query<T>(query).ToList();

                return Conn.Query<T>(query, parameters).ToList();
            }
            catch (Exception ex)
            {
               // _logger.LogError(ex, ex.Message);
                throw;
            }
            finally
            {
                if ((Conn != null) && (Conn.State != ConnectionState.Closed))
                {
                    Conn.Close();
                }
            }
        }

        public T Insert(T obj)
        {
            Conn.Insert(obj);
            return obj;
        }

        public bool Remove(T obj)
        {
            return Conn.Delete(obj);
        }

        public List<T> GetAll()
        {
            return Conn.GetAll<T>().ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }
        /*
        public List<T> Query(string query, DynamicParameters parameters)
        {
            throw new NotImplementedException();
        }
        */
    }
}
