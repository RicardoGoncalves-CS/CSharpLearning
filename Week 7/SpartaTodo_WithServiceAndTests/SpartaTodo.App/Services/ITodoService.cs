using SpartaTodo.App.Models;
using SpartaTodo.App.Models.ViewModels;

namespace SpartaTodo.App.Services
{
    public interface ITodoService
    {
        Task<ServiceResponse<IEnumerable<TodoVM>>> GetTodoItemsAsync(Spartan? user, string role = "Trainee", string? filter = null);
        Task<ServiceResponse<TodoVM>> GetDetailsAsync(int? id, Spartan? user, string role = "Trainee");
        Task<ServiceResponse<TodoVM>> CreateTodoAsync(CreateTodoVM createTodoVM, Spartan? user);
        Task<ServiceResponse<TodoVM>> EditTodoAsync(int? id, TodoVM todoVM, Spartan? user);
        Task<ServiceResponse<TodoVM>> UpdateTodoCompleteAsync(int id, MarkCompleteVM markCompleteVM, Spartan? user);
        Task<ServiceResponse<TodoVM>> DeleteTodoAsync(int? id, Spartan? user);
    }
}
