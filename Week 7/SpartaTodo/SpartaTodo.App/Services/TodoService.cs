using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
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

            response.Success = true;
            return response;
        }


        public async Task<ServiceResponse<bool>> DeleteTodoAsync(int? id)
        {
            var response = new ServiceResponse<bool>();

            if (_context.TodoItems == null)
            {
                response.Success = false;
                response.Message = "Invalid Todo item!";
                return response;
            }

            var todo = await _context.TodoItems.FindAsync(id);

            if (todo != null)
            {
                _context.TodoItems.Remove(todo);
            }

            await _context.SaveChangesAsync();
            response.Success = true;
            return response;

            //return RedirectToAction(nameof(Index));
        }

        public async Task<ServiceResponse<bool>> EditTodoAsync(int? id, TodoVM todoVM)
        {
            var response = new ServiceResponse<bool>();

            if (id != todoVM.Id)
            {
                response.Success = false;
                response.Message = "There are no Todo items to do!";
                return response;
            }

            try
            {
                _context.Update(_mapper.Map<Todo>(todoVM));
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoExists(todoVM.Id))
                {
                    response.Success = false;
                    response.Message = "There are no Todo items to do!";
                    return response;
                }
                else
                {
                    throw;
                }
            }

            response.Success = true;
            return response;
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

        public async Task<ServiceResponse<bool>> UpdateTodoCompleteAsync(int id, MarkCompleteViewModel markCompleteVM)
        {
            var response = new ServiceResponse<bool>();

            if (id != markCompleteVM.Id)
            {
                response.Success = false;
                response.Message = "There are no Todo items to do!";
                return response;
            }

            var todo = await _context.TodoItems.FindAsync(id);

            if (todo == null)
            {
                response.Success = false;
                response.Message = "There are no Todo items to do!";
                return response;
            }

            todo.Complete = markCompleteVM.Complete;
            await _context.SaveChangesAsync();
            response.Success = true;
            return response;
        }

        private bool TodoExists(int id)
        {
            return (_context.TodoItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
