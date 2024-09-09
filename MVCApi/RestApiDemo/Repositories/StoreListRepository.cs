using RestApiDemo.Models;

namespace RestApiDemo.Repositories
{
    public class StoreListRepository : IStoreListRepository
    {
        public static List<Store> StoreList = new List<Store>();
        public void Add(Store store)
        {
            StoreList.Add(store);
        }
        public List<Store> GetAllStores()
        {
            return StoreList;
        }
        public void Delete(int id)
        {
            var v = StoreList.FirstOrDefault(c => c.Id == id);
            if (v != null)
            {
                StoreList.Remove(v);
            }
        }
        public void Update(int id, Store store)
        {
            var result = StoreList.Where(l => l.Id == id).FirstOrDefault();
            if (result != null) {
                result.Location = store.Location;
                result.Name = store.Name;
            }

        }
        public Store GetStoreById(int id)
        {
            return StoreList.Where(l => l.Id == id).FirstOrDefault();
            
        }
        public List<Store> GetStoreByLocation(string location)
        {
            return (from s in StoreList
                    where s.Location == location
                    select s).ToList();
        }
    }
}
