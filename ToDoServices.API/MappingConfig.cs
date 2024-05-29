using AutoMapper;
using ToDoServices.API.DTO;
using ToDoServices.API.Model;

namespace ToDoServices.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.CreateMap<TodoTaskDTO, TodoTask>();
                mc.CreateMap<TodoTask, TodoTaskDTO>();


            });

            return mappingConfig;
        }
    }
}
