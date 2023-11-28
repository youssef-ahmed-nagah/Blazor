namespace Demo.RestfullService
{
    public interface IServices<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Update(int id, T obj);
        Task Add(T obj);
        Task Delete(int id);
    }
}
