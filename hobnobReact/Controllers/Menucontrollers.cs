using System.Collections.Generic;
using AutoMapper;
using hobnobReact.Data;
using hobnobReact.Models;
using Microsoft.AspNetCore.Mvc;
using hobnobReact.Dtos;

namespace Menucontrollers.Controllers
{
    [Route("api/menus")]
    [ApiController]
    public class Menucontrollers:ControllerBase
    {
        private readonly IhobnobRepo _repository;
        private readonly IMapper _mapper;
        public Menucontrollers(IhobnobRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper=mapper;

        }
    
        [HttpGet]
        public ActionResult<IEnumerable<Menu>> GetAllMenus()
        {
                var menuitems=_repository.GetAllmenus();
                return Ok(menuitems);
        }
        [HttpGet("{id}", Name="GetMenuById")]
        public ActionResult<Menu> GetMenuById(int id)
        {
            var menuitems=_repository.GetMenuById(id);
            if(menuitems!=null)
            {
            return Ok (menuitems);
            }
            return NotFound();
        }
        //POST api/ menu
        [HttpPost]
        public ActionResult<MenuReadDto> createMenu(MenuCreateDto menuCreateDto)
        {
            //source -> Target
         var menuModel=_mapper.Map<Menu>(menuCreateDto);// from the Dto(source User input ) to target Dto or profile.
         _repository.CreateMenu(menuModel);
         _repository.SaveChanges();
        // var MenuReadDto = _mapper.Map<MenuReadDto>(menuModel);// it need not to display filedname;
         //return Ok(menuModel);
         return CreatedAtRoute(nameof(GetMenuById), new {Id = menuModel});//,MenuReadDto);

        }
    }
}