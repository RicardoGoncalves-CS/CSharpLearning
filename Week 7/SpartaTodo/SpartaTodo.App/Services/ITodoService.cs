using SpartaTodo.App.Models;
using SpartaTodo.App.Models.ViewModels;

namespace SpartaTodo.App.Services
{
    public interface ITodoService
    {
        Task<ServiceResponse<IEnumerable<TodoVM>>> GetTodoItemsAsync(string? filter = null);
        Task<ServiceResponse<TodoVM>> GetDetailsAsync(int? id);
        Task<ServiceResponse<bool>> CreateTodoAsync(CreateTodoViewModel createTodoVM);
        Task<ServiceResponse<bool>> EditTodoAsync(int? id, TodoVM todoVM);
        Task<ServiceResponse<bool>> DeleteTodoAsync(int? id);
        Task<ServiceResponse<bool>> UpdateTodoCompleteAsync(int id, MarkCompleteViewModel markCompleteVM);
    }
}
