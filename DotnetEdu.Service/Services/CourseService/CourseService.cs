using DotnetEdu.Data.UnitOfWorks;
using DotnetEdu.Domain.Entities;
using DotnetEdu.Service.Exceptions;

namespace DotnetEdu.Service.Services.CourseService;

public class CourseService(IUnitOfWork unitOfWork) : ICourseService
{
    public async ValueTask<Course> CreateAsync(Course course)
    {
        var existCourse = await unitOfWork.Courses.SelectAsync(
            expression: c => c.Name == course.Name && !c.IsDeleted);

        if (existCourse == null)
            throw new AlreadyExistException($"Course with name {course.Name} is already exists");

        var created = await unitOfWork.Courses.InsertAsync(course);
        await unitOfWork.SaveAsync();

        return created;
    }

    public async ValueTask<bool> DeleteAsync(long id)
    {
        var existCourse = await unitOfWork.Courses.SelectAsync(
            expression: c => c.Id == id && !c.IsDeleted)
            ?? throw new NotFoundException("Course is not found");

        existCourse.IsDeleted = true;
        existCourse.DeletedAt = DateTime.UtcNow;
        await unitOfWork.Courses.DeleteAsync(existCourse);

        await unitOfWork.SaveAsync();

        return true;
    }

    public ValueTask<Course> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async ValueTask<Course> GetAsync(long id)
    {
        var existCourse = await unitOfWork.Courses.SelectAsync(
            expression: c => c.Id == id && !c.IsDeleted)
            ?? throw new NotFoundException("Course is not found");

        return existCourse;
    }

    public ValueTask<Course> UpdateAsync(long id, Course course)
    {
        throw new NotImplementedException();
    }
}
