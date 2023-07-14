namespace LeaveManagementWeb.Contracts
    //This is an interface. An interface holds all the methods which is mandatory to be present in whichever class is calling this interface
    //This interface specifically is a generic one and holds the methods which is required generally, i.e for all tables
    //Now we need to implement this interface. In order to use this interface in a controller, we need to first implement this interface onto a class
    //This class is where we define what each of these methods actually does. The corresponding classes will be present in a folder called repositories.
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int? id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        Task<bool> Exists(int id);
    }
}
