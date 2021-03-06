using System.Collections.Generic;
using System.Threading.Tasks;
using MAVN.Service.CustomerManagement.Domain.Models;

namespace MAVN.Service.CustomerManagement.Domain.Repositories
{
    public interface ICustomerFlagsRepository
    {
        Task<ICustomerFlags> CreateOrUpdateAsync(string customerId, bool isBlocked);

        Task<ICustomerFlags> GetByCustomerIdAsync(string customerId);

        Task<IEnumerable<ICustomerFlags>> GetByCustomerIdsAsync(string[] customerIds);
    }
}
