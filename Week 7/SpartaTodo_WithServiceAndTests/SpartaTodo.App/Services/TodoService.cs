using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SpartaTodo.App.Data;
using SpartaTodo.App.Models;
using SpartaTodo.App.Models.ViewModels;

namespace SpartaTodo.App.Services
{
    public class TodoService : ITodoService
    {
        private readonly SpartaTodoContext _context;
        private readonly IMapper _mapper;

        public TodoService(SpartaTodoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<TodoVM>> CreateTodoAsync(CreateTodoVM createTodoVM, Spartan? user)
        {
            var response = new ServiceResponse<TodoVM>();
            if (user == null)
            {
                response.Success = false;
                response.Message = "No user found";
                return response;
            }
            var todo = _mapper.Map<Todo>(createTodoVM);
            todo.SpartanId = user.Id;
            _context.TodoItems.Add(todo);
            await _context.SaveChangesAsync();
            return response;
        }

        public async Task<ServiceResponse<TodoVM>> DeleteTodoAsync(int? id, Spartan? user)
        {
            var response = new ServiceResponse<TodoVM>();

            if (user == null)
            {
                response.Success = false;
                response.Message = "No user found";
                return response;
            }
            if (_context.TodoItems == null)
            {
                response.Success = false;
                response.Message = "There are no Todos!";
                return response;
            }
            var todo = await _context.TodoItems.FindAsync(id);
            if (todo != null && todo.SpartanId == user.Id)
            {
                _context.TodoItems.Remove(todo);
                await _context.SaveChangesAsync();
            }

            return response;
        }

        public async Task<ServiceResponse<TodoVM>> EditTodoAsync(int? id, TodoVM todoVM, Spartan? user)
        {
            var response = new ServiceResponse<TodoVM>();
            if (user == null)
            {
                response.Success = false;
                response.Message = "No user found";
                return response;
            }

            var spartanOwnerId = await GetSpartanOwnerAsync(id);

            if (id != todoVM.Id || spartanOwnerId != user.Id)
            {
                response.Success = false;
                return response;
            }

            var todo = _mapper.Map<Todo>(todoVM);
            todo.SpartanId = spartanOwnerId;

            try
            {
                _context.Update(todo);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoExists(todoVM.Id))
                {
                    response.Success = false;
                    return response;
                }
                else
                {
                    throw;
                }
            }
            return response;
        }

        public async Task<ServiceResponse<TodoVM>> GetDetailsAsync(int? id, Spartan? user, string role = "Trainee")
        {
            var response = new ServiceResponse<TodoVM>();
            if (user == null)
            {
                response.Success = false;
                response.Message = "No user found";
                return response;
            }
            if (id == null || _context.TodoItems == null)
            {
                response.Success = false;
                return response;
            }

            var todo = await _context.TodoItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todo == null || (todo.SpartanId != user.Id && role == "Trainee"))
            {
                response.Success = false;
                return response;
            }

            response.Data = _mapper.Map<TodoVM>(todo);
            return response;
        }

        public async Task<ServiceResponse<IEnumerable<TodoVM>>> GetTodoItemsAsync(Spartan? user, string? role = "Trainee", string? filter = null)
        {
            var response = new ServiceResponse<IEnumerable<TodoVM>>();
            if (_context.TodoItems == null)
            {
                response.Success = false;
                response.Message = "There are no Todo items to do!";
                return response;
            }
            if (user == null)
            {
                response.Success = false;
                response.Message = "No user found";
                return response;
            }
            List<Todo> todoItems = new List<Todo>();
            if (role == "Trainee")
            {
                todoItems = await _context.TodoItems.Where(td => td.SpartanId == user!.Id).ToListAsync();
            }
            if (role == "Trainer")
            {
                todoItems = await _context.TodoItems.ToListAsync();
            }
            if (filter.IsNullOrEmpty())
            {
                response.Data = todoItems.Select(td => _mapper.Map<TodoVM>(td));
                return response;
            }
            response.Data = todoItems
                .Where(td =>
                    td.Title.Contains(filter!, StringComparison.OrdinalIgnoreCase) ||
                    td.Description!.Contains(filter!, StringComparison.OrdinalIgnoreCase))
                .Select(td => _mapper.Map<TodoVM>(td));
            return response;
        }

        public async Task<ServiceResponse<TodoVM>> UpdateTodoCompleteAsync(int id, MarkCompleteVM markCompleteVM, Spartan? user)
        {
            var response = new ServiceResponse<TodoVM>();
            if (user == null)
            {
                response.Success = false;
                response.Message = "No user found";
                return response;
            }

            if (id != markCompleteVM.Id)
            {
                response.Success = false;
                return response;
            }
            var todo = await _context.TodoItems.FindAsync(id);
            if (todo == null || todo.SpartanId != user.Id)
            {
                response.Success = false;
                return response;
            }
            todo.Complete = markCompleteVM.Complete;
            await _context.SaveChangesAsync();
            return response;
        }

        private bool TodoExists(int id)
        {
            return (_context.TodoItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private async Task<string> GetSpartanOwnerAsync(int? id)
        {
            return await _context.TodoItems.Where(td => td.Id == id).Select(td => td.SpartanId).FirstAsync();
        }
    }
}
