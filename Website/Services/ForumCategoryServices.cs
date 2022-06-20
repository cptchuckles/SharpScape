using SharpScape.Shared.Dto;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace SharpScape.Website.Services
{
    public class ForumCategoryServices : IForumCategoryServices
    {
       
            private readonly HttpClient httpClient;

            public ForumCategoryServices(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }

            public async Task<IEnumerable<ForumCategoryDto>> GetForumCategories()
            {
                return await httpClient.GetFromJsonAsync<List<ForumCategoryDto>>("api/ForumCategories");
            }
       


    }
}


/*using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetJsonAsync<Employee[]>("api/employees");
        }
    }
}*/