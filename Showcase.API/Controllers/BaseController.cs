using Microsoft.AspNetCore.Mvc;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<T> : ControllerBase where T : class
    {
        protected readonly IBaseRepository<T> _repository;

        protected BaseController(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<T>>> GetAll()
        {
            try
            {
                var entities = await _repository.GetAllAsync();
                return Ok(entities);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<T>> GetById(int id)
        {
            try
            {
                var entity = await _repository.GetByIdAsync(id);
                if (entity == null)
                {
                    return NotFound($"Entity with ID {id} not found");
                }
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public virtual async Task<ActionResult<T>> Create(T entity)
        {
            try
            {
                if (entity == null)
                {
                    return BadRequest("Entity cannot be null");
                }

                var createdEntity = await _repository.AddAsync(entity);
                return CreatedAtAction(nameof(GetById), new { id = GetEntityId(createdEntity) }, createdEntity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(int id, T entity)
        {
            try
            {
                if (entity == null)
                {
                    return BadRequest("Entity cannot be null");
                }

                // Check if entity exists
                var existingEntity = await _repository.GetByIdAsync(id);
                if (existingEntity == null)
                {
                    return NotFound($"Entity with ID {id} not found");
                }

                await _repository.UpdateAsync(entity);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            try
            {
                var entity = await _repository.GetByIdAsync(id);
                if (entity == null)
                {
                    return NotFound($"Entity with ID {id} not found");
                }

                await _repository.DeleteAsync(entity);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        protected virtual int GetEntityId(T entity)
        {
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null && idProperty.PropertyType == typeof(int))
            {
                return (int)idProperty.GetValue(entity)!;
            }
            
            return 0;
        }
    }
}
