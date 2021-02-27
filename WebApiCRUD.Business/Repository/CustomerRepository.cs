using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using WebApiCRUD.Business.Helpers;
using WebApiCRUD.Business.Request;

namespace WebApiCRUD.Business.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();
        void Add(Customer model);
        Task<Customer> GetById(int id);
        void Update(Customer customer);
        void Delete(int id);
    }

    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            await using(var connection = new SqlConnection(GetSettings.ConnectionString))
            {
                return await connection.QueryAsync<Customer>(QueryStrings.GetAllCustomers, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public Task<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
