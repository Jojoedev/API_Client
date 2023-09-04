namespace Api_Client.Interface
{
    public interface IHttpInterface
    {
        Task<T> GetData<T>();
        Task<T> GetAData<T>(int id);
        Task<T> CreateData<T>(T body);
        Task<T> UpdateData<T>(int id, T body);
        Task<T> DeleteData<T>(int id);
    }
}
