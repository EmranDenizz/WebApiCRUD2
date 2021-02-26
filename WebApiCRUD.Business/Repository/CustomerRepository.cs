using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApiCRUD.Business.Request;

namespace WebApiCRUD.Business.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();
    }
}
