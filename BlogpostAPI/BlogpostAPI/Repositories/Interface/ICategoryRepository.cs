using BlogpostAPI.Models.Domain;

namespace BlogpostAPI.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
