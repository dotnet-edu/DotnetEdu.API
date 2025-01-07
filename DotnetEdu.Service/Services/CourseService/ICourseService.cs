using DotnetEdu.Domain.Entities;

namespace DotnetEdu.Service.Services.CourseService;

public interface ICourseService
{
    public ValueTask<Course> CreateAsync(Course course);
    public ValueTask<Course> UpdateAsync(long id, Course course);
    public ValueTask<bool> DeleteAsync(long id);
    public ValueTask<Course> GetAsync(long id);
    public ValueTask<Course> GetAllAsync();
}
