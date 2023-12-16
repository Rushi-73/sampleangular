using BlogpostAPI.Data;
using BlogpostAPI.Models.Domain;
using BlogpostAPI.Models.DTO;
using BlogpostAPI.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogpostAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository) { 

            this.categoryRepository = categoryRepository;
            
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            //map dto to domain model

            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };
          
            await categoryRepository.CreateAsync(category);

            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle

            };
            return Ok(response);
        }
    }
}
