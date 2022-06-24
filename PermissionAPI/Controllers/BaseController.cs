using System;
using Microsoft.AspNetCore.Mvc;
using PermissionBl.Repositories;

namespace PermissionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : class
    {
        protected readonly IRepositoryBase<T> _baseRepository;
        public BaseController(IRepositoryBase<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        [HttpGet]
        public virtual IActionResult Get()
        {
            var data = _baseRepository.GetAll();
            return Ok(data.ToList());
        }

        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {
            return Ok(_baseRepository.GetById(id));
        }

        [HttpPost]
        public virtual IActionResult Post([FromBody] T entity)
        {
            var createdEntity = _baseRepository.Create(entity);
            return Ok(createdEntity);
        }

        [HttpPut]
        public virtual IActionResult Put([FromBody] T entity)
        {
            _baseRepository.Update(entity);
            return Ok();
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            _baseRepository.Delete(id);
            return Ok();
        }
    }
}

