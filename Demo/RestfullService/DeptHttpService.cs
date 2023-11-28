using Demo.Data;
using System.Net.Http;
using System.Net.Http.Json;

namespace Demo.RestfullService
{
    
    public class DeptHttpService : IServices<Department>
    {
        HttpClient httpClient;
        public DeptHttpService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
            //httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("http://localhost:5147/"); ;
        }
        public Task Add(Department obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAll()
        {
            var depts= await  httpClient.GetFromJsonAsync<List<Department>>("api/Departments");
            return depts;
        }

        public Task<Department> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Department obj)
        {
            throw new NotImplementedException();
        }
    }
}
