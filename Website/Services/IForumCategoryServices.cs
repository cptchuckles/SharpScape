using SharpScape.Shared.Dto;

namespace SharpScape.Website.Services
{
    public interface IForumCategoryServices
    {
        Task<IEnumerable<ForumCategoryDto>> GetForumCategories();
    }
}
