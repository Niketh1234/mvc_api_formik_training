using RestApiDemo.Models;

namespace RestApiDemo.Repositories
{
    public interface IStoreListRepository
    {
        void Add(Store store);
        void Delete(int id);
        List<Store> GetAllStores();
        Store GetStoreById(int id);
        List<Store> GetStoreByLocation(string location);
        void Update(int id, Store store);
    }
}