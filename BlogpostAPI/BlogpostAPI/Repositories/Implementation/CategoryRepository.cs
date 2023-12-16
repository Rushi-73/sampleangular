using BlogpostAPI.Data;
using BlogpostAPI.Models.Domain;
using BlogpostAPI.Repositories.Interface;

namespace BlogpostAPI.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly ApplicationDbContext dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
