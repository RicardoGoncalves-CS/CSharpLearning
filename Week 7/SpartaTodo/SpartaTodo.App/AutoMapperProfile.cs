using AutoMapper;
using SpartaTodo.App.Models;
using SpartaTodo.App.Models.ViewModels;

namespace SpartaTodo.App;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CreateTodoViewModel, Todo>();

        CreateMap<EditTodoViewModel, Todo>();

        CreateMap<TodoVM, Todo>();

        CreateMap<Todo, TodoVM>();
    }
}
