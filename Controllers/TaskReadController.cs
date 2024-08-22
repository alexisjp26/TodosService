using Microsoft.AspNetCore.Mvc;
using TodosService.Data;
using TodosService.Dtos;

namespace TodosService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskReadController : ControllerBase
    {
        private readonly IRepository<TaskReadDto> _repository;

        public TaskReadController(IRepository<TaskReadDto> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskReadDto>> GetAllTasks()
        {
            var tasks = _repository.GetAll();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public ActionResult<TaskReadDto> GetTaskById(int id)
        {
            var task = _repository.GetAll().FirstOrDefault(x => x.Id == id);
            if (task is not null)
            {
                return Ok(task);
            }
            return NotFound();
        }

        [HttpGet("SearchByUserId/{userId}")]
        public ActionResult<IEnumerable<TaskReadDto>> GetTasksByUserId(int userId)
        {
            var task = _repository.GetAll().Where(x => x.UserId == userId);
            if (task is not null)
            {
                return Ok(task);
            }
            return NotFound();
        }
    }
}