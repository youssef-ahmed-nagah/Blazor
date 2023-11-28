using Demo.Data;
using System.Net.Http.Json;

namespace Demo.RestfullService
{
    public class EmpHttpService:IServices<Employee>
    {
        HttpClient httpClient;
        //public EmpHttpService(IConfiguration cong)
        //{
        //    string ip = cong["ipApi"];
        //  //  httpClient= new HttpClient();
        //    //httpClient.BaseAddress =new Uri("http://localhost:5147/"); ;
        //}
        public EmpHttpService(HttpClient _httpClient)
        {
            httpClient= _httpClient;
        }
        public async Task<List<Employee>> GetAll()
        {
           List<Employee> EmpList=await httpClient.GetFromJsonAsync<List<Employee>>("api/Employees");
            return EmpList;
        }
        public async Task<Employee> GetById(int id)
        {
            Employee Emp = 
                await httpClient.GetFromJsonAsync<Employee>
                ($"api/Employees/{id}");
            return Emp;
        }
        public async Task Update(int id,Employee emp)
        {
            await httpClient.PutAsJsonAsync<Employee>($"api/Employees/{id}",emp);
        }
        public async Task Add(Employee emp)
        {
            await httpClient.PostAsJsonAsync<Employee>($"api/Employees", emp);
        }
        public async Task Delete(int id)
        {
            await httpClient.DeleteFromJsonAsync<Employee>($"api/Employees/{id}");
        }
    }
}
