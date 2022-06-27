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
       
            private readonly HttpClient _httpClient;

            public ForumCategoryServices(HttpClient httpClient)
            {
                this._httpClient = httpClient;
            }

            public async Task<List<ForumCategoryDto>> GetForumCategories()
            {
                return await _httpClient.GetFromJsonAsync<List<ForumCategoryDto>>("https://localhost:7193/api/ForumCategories");
            }
    }
}