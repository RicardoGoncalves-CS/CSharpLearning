using AutoMapper;
using SpartaTodo.App.Models;
using SpartaTodo.App.Models.ViewModels;

namespace SpartaTodo.App
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateTodoVM, Todo>();
            CreateMap<Todo, TodoVM>();
            CreateMap<TodoVM, Todo>();
        }
    }
}
