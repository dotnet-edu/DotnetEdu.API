using DotnetEdu.Data.UnitOfWorks;
using DotnetEdu.Domain.Entities;
using DotnetEdu.Service.Exceptions;

namespace DotnetEdu.Service.Services.CategoryService;

public class CategoryService(IUnitOfWork unitOfWork) : ICategoryService
{
    public async ValueTask<Category> CreateCategory(Category category)
    {
        var existCategory = await unitOfWork.Categories.SelectAsync(
            expression: c => c.Name == category.Name && !c.IsDeleted);

        if (existCategory != null)
            throw new AlreadyExistException($"Category with name {category.Name}");

        var created = await unitOfWork.Categories.InsertAsync(category);
        await unitOfWork.SaveAsync();

        return created;
    }

    public async ValueTask<bool> DeleteCategory(long id)
    {
        var existsCategory = await unitOfWork.Categories.SelectAsync(
            expression: c => c.Id == id && !c.IsDeleted)
            ?? throw new NotFoundException("Category is not found");

        await unitOfWork.Categories.DeleteAsync(existsCategory);
        await unitOfWork.SaveAsync();

        return true;
    }

    public ValueTask<Category> GetAllCategories()
    {
        throw new NotImplementedException();
    }

    public ValueTask<Category> GetCategory(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Category> UpdateCategory(long id, Category category)
    {
        throw new NotImplementedException();
    }
}
