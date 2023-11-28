using Demo;
using Demo.Data;
using Demo.RestfullService;
using Demo.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Demo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");  
            builder.RootComponents.Add<HeadOutlet>("head::after");// route ==> change title
            builder.Services.AddScoped<EmployeeService>();
            builder.Services.AddScoped<DeptService>();
            //--------------------API Provider-----------------
            //builder.Services.AddScoped<IServices<Employee>,EmpHttpService>();
            //builder.Services.AddScoped<IServices<Department>, DeptHttpService>();

            ////Day 3
            //builder.Services.AddScoped(sp => new HttpClient 
            //{
            //   BaseAddress = new Uri(builder.Configuration["ipApi"].ToString())
            //});
            builder.Services.AddHttpClient<IServices<Employee>, EmpHttpService>(
                options =>
                {
                    options.BaseAddress = 
                    new Uri(builder.Configuration["ipApi"].ToString());
                });
            builder.Services.AddHttpClient<IServices<Department>, DeptHttpService>(
                options =>
                {
                    options.BaseAddress = 
                    new Uri(builder.Configuration["ipBank"].ToString());
                });
            await builder.Build().RunAsync();
        }
    }
}