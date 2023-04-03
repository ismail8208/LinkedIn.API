using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IAddressRepository
    {
        public Task<List<Address>> GetAddresses(string address); //search for Addresses based on a address parameter.
        public Task<Address> GetAddress(int userId); //Retrieves an Address of a user.
        public Task AddAddress(int userId, Address Address); //Adds an Address of a user.
        public Task UpdateAddress(int userId, int AddressId, Address Address); //Updates an Address of a user.
        public Task DeleteAddress(int userId, int AddressId); //Deletes an Address of a user.
    }
}
