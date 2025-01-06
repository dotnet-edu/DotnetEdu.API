using DotnetEdu.Domain.Entities;

namespace DotnetEdu.Service.Services.CategoryService;

public interface ICategoryService
{
    public ValueTask<Category> CreateCategory(Category category);
    public ValueTask<Category> UpdateCategory(long id, Category category);
    public ValueTask<bool> DeleteCategory(long id);
    public ValueTask<Category> GetCategory(long id);
    public ValueTask<Category> GetAllCategories();
}
