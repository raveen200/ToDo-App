using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoServices.API.Data;
using ToDoServices.API.DTO;
using ToDoServices.API.Model;

namespace ToDoServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoTaskController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        public ToDoTaskController(AppDbContext db , IMapper mapper
        )
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<TodoTask> tasks = _db.TodoTasks.ToList();
                return Ok(tasks);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public object Get(int id)
        {
            try
            {
                TodoTask task = _db.TodoTasks.Find(id);
                return Ok(task);
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        [HttpPost]
        public object Post([FromBody] TodoTaskDTO taskDTO)
        {
            try
            {
                TodoTask task = _mapper.Map<TodoTask>(taskDTO);
                _db.TodoTasks.Add(task);
                _db.SaveChanges();
                return Ok(task);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }



        }

        [HttpPut]
        public object Put(int id, [FromBody] TodoTaskDTO taskDTO)
        {
            try
            {
                TodoTask task = _mapper.Map<TodoTask>(taskDTO);
                task.Id = id;
                _db.TodoTasks.Update(task);
                _db.SaveChanges();
                return Ok(task);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public object Delete(int id)
        {
            try
            {
                TodoTask task = _db.TodoTasks.Find(id);
                _db.TodoTasks.Remove(task);
                _db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }





    }
}
