using SpartaTodo.App.Models;
using SpartaTodo.App.Models.ViewModels;

namespace SpartaTodo.App.Services
{
    public interface ITodoService
    {
        Task<ServiceResponse<IEnumerable<TodoVM>>> GetTodoItemsAsync(string? filter = null);
        Task<ServiceResponse<TodoVM>> GetDetailsAsync(int? id);
        Task<ServiceResponse<bool>> CreateTodoAsync(CreateTodoViewModel createTodoVM);
        //Task<ServiceResponse<TodoVM>> CreateTodoAsync(CreateTodoViewModel createTodoVM);
        //Task<TodoVM> EditTodoAsync(int? id, TodoVM todoVM);
        //Task<TodoVM> UpdateTodoCompleteAsync(int id, MarkCompleteViewModel markCompleteVM);
        //Task<TodoVM> DeleteTodoAsync(int? id);
    }
}
