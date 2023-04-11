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

        public async Task<ServiceResponse<bool>> CreateTodoAsync(CreateTodoViewModel createTodoVM)
        {
            var response = new ServiceResponse<bool>();

            if (createTodoVM == null)
            {
                response.Success = false;
                response.Message = "Invalid Todo item!";
                return response;
            }

            var todo = _mapper.Map<Todo>(createTodoVM);
            _context.Add(todo);
            await _context.SaveChangesAsync();

            response.Data = true;
            return response;
        }


        public Task<TodoVM> DeleteTodoAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TodoVM>> EditTodoAsync(int? id, TodoVM todoVM)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<TodoVM>> GetDetailsAsync(int? id)
        {
            var response = new ServiceResponse<TodoVM>();

            if (id == null || _context.TodoItems == null)
            {
                response.Success = false;
                response.Message = "There are no Todo items to do!";
                return response;
            }

            var todo = await _context.TodoItems
                .FirstOrDefaultAsync(m => m.Id == id);

            if (todo == null)
            {
                response.Success = false;
                response.Message = "There are no Todo items to do!";
                return response;
            }

            response.Data = _mapper.Map<TodoVM>(todo);
            return response;
        }

        public async Task<ServiceResponse<IEnumerable<TodoVM>>> GetTodoItemsAsync(string? filter = null)
        {
            var response = new ServiceResponse<IEnumerable<TodoVM>>();
            if (_context.TodoItems == null)
            {
                response.Success = false;
                response.Message = "There are no Todo items to do!";
                return response;
            }
            var todoItems = await _context.TodoItems.ToListAsync();
            if (filter.IsNullOrEmpty())
            {
                response.Data = todoItems.Select(td => _mapper.Map<TodoVM>(td));
                return response;
            }
            response.Data = todoItems.
            Where(
            td => td.Title.Contains(filter!, StringComparison.OrdinalIgnoreCase) ||
            td.Description!.Contains(filter!, StringComparison.OrdinalIgnoreCase))
            .Select(td => _mapper.Map<TodoVM>(td));
            return response;
        }

        public Task<TodoVM> UpdateTodoCompleteAsync(int id, MarkCompleteViewModel markCompleteVM)
        {
            throw new NotImplementedException();
        }
    }
}
