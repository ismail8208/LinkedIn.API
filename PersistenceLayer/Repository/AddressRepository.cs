using DataAccess;
using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class AddressRepository : IAddressRepository
    {
        public Task AddAddress(int userId, Address Address)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAddress(int userId, int AddressId)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetAddress(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Address>> GetAddresses(string address)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAddress(int userId, int AddressId, Address Address)
        {
            throw new NotImplementedException();
        }
    }
}
