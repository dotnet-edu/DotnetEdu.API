using DotnetEdu.Data.UnitOfWorks;
using DotnetEdu.Domain.Entities;
using DotnetEdu.Service.Exceptions;

namespace DotnetEdu.Service.Services.CategoryService;

public class CategoryService(IUnitOfWork unitOfWork) : ICategoryService
{
    public async ValueTask<Category> CreateAsync(Category category)
    {
        var existCategory = await unitOfWork.Categories.SelectAsync(
            expression: c => c.Name == category.Name && !c.IsDeleted);

        if (existCategory != null)
            throw new AlreadyExistException($"Category with name {category.Name}");


        var created = await unitOfWork.Categories.InsertAsync(category);
        await unitOfWork.SaveAsync();

        return created;
    }

    public async ValueTask<bool> DeleteAsync(long id)
    {
        var existsCategory = await unitOfWork.Categories.SelectAsync(
            expression: c => c.Id == id && !c.IsDeleted)
            ?? throw new NotFoundException("Category is not found");

        existsCategory.IsDeleted = true;
        existsCategory.DeletedAt = DateTime.UtcNow;
        await unitOfWork.Categories.DeleteAsync(existsCategory);

        await unitOfWork.SaveAsync();

        return true;
    }

    public ValueTask<Category> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async ValueTask<Category> GetAsync(long id)
    {
        var existsCategory = await unitOfWork.Categories.SelectAsync(
            expression: c => c.Id == id && !c.IsDeleted)
            ?? throw new NotFoundException("Category is not found");

        return existsCategory;
    }

    public async ValueTask<Category> UpdateAsync(long id, Category category)
    {
        var existsCategory = await unitOfWork.Categories.SelectAsync(
            expression: c => c.Id == id && !c.IsDeleted)
            ?? throw new NotFoundException("Category is not found");

        existsCategory.Name = category.Name;
        existsCategory.UpdatedAt = DateTime.UtcNow;

        var updated = await unitOfWork.Categories.UpdateAsync(existsCategory);
        await unitOfWork.SaveAsync();

        return updated;
    }
}
