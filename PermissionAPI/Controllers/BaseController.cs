using System;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PermissionBl.Dtos.BaseDto;
using PermissionBl.Services;
using PermissionModels.Entities.Base;
using PermissionModels.Repositories;

namespace PermissionAPI.Controllers
{
    public interface IBaseController
    {
        Type TypeDto { get; set; }
        IMapper Mapper { get; set; }
        IValidatorFactory ValidationFactory { get; set; }
        UnprocessableEntityObjectResult UnprocessableEntity(object error);
        string TypeName { get; set; }
    }

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BaseController<TEntity, TEntityDto> : ControllerBase, IBaseController
            where TEntity : class, IBaseEntity
            where TEntityDto : class, IBaseEntityDto
    {

        public IMapper Mapper { get; set; }
        public Type TypeDto { get; set; }
        public string TypeName { get; set; }
        public IValidatorFactory ValidationFactory { get; set; }
        protected readonly IBaseService<TEntity, TEntityDto> _baseService;

        public BaseController(IBaseService<TEntity, TEntityDto> baseService, IValidatorFactory validationFactory, IMapper mapper)
        {
            _baseService = baseService;
            ValidationFactory = validationFactory;
            TypeDto = typeof(List<TEntityDto>);
            TypeName = typeof(TEntity).Name;
            Mapper = mapper;
        }

        [HttpGet]
        public virtual IActionResult Get()
        {
            var data = _baseService.GetAll();
            return Ok(data.ToList());
        }

        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {
            return Ok(_baseService.GetById(id));
        }

        [HttpPost]
        public virtual IActionResult Post([FromBody] TEntityDto entity)
        {
            var createdEntity = _baseService.Create(entity);
            return Ok(createdEntity);
        }

        [HttpPut]
        public virtual IActionResult Put([FromBody] TEntityDto entity)
        {
            _baseService.Update(entity);
            return Ok();
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            _baseService.Delete(id);
            return Ok();
        }
    }

    /*
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
    */
}

