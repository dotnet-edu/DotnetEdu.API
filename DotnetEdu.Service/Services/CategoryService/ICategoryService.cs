using DotnetEdu.Domain.Entities;

namespace DotnetEdu.Service.Services.CategoryService;

public interface ICategoryService
{
    public ValueTask<Category> CreateAsync(Category category);
    public ValueTask<Category> UpdateAsync(long id, Category category);
    public ValueTask<bool> DeleteAsync(long id);
    public ValueTask<Category> GetAsync(long id);
    public ValueTask<Category> GetAllAsync();
}
