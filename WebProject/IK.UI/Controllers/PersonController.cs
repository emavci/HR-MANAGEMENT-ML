using AutoMapper;
using IK.Application.DTOs;
using IK.Application.InitData;
using IK.Application.Interfaces.Services;
using IK.Application.ViewModels;
using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using IK.Persistence.Utilities.DataTables;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Dynamic;
using System.Text.Json;

namespace IK.UI.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonService _personService;
        private readonly ICurrentBaseService _currentBaseService;
        private readonly IMapper _mapper;

        public PersonController(ILogger<HomeController> logger, IPersonService personService, ICurrentBaseService currentBaseService, IMapper mapper)
        {
            _logger = logger;
            _personService = personService;
            _currentBaseService = currentBaseService;
            _mapper = mapper;
        }

        public async Task<IActionResult> PersonelList(int typeId)
        {
            var data = await _personService.GetAllAsync(typeId);
            var dataSelect = data.Select(x => new Sys_PersonDto(x)).ToList();
            List<Sys_PersonDto> personView = new List<Sys_PersonDto>(dataSelect);
            ViewBag.InitData = data.Select(x => new Sys_PersonDto(x)).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetPersonelList(int typeId)
            {
            var data = await _personService.GetAllAsync(typeId);
            var map = _mapper.Map<List<Sys_PersonDto>>(data);
            var dataSelect = data.Select(x => new Sys_PersonDto(x));
            var personView = new List<Sys_PersonDto>(dataSelect);
            var responseList = new List<Sys_PersonDto>();
            foreach (var item in dataSelect)
            {
                responseList.Add(item);
            }

            return Ok(new DtResult<Sys_PersonDto>
            {

                data = map,
                draw = 1,
                recordsTotal = 1,
                recordsFiltered = 1,

            }
            );
        }
        public async Task<IActionResult> Personel(int id)
        {
            var data = await _currentBaseService.Initialize();
            //ViewBag.InitData = data.Select(x => new CurrentBaseInitData(x));
            ViewBag.InitData = _mapper.Map<CurrentBaseInitData, CurrentBaseInitDataDto>(data);
            var a = _mapper.Map<CurrentBaseInitData, CurrentBaseInitDataDto>(data);
            if (id == null || id == 0)
            {

                return View();
            }
            else
            {
                var datas = _personService.GetById(id);
                PersonViewModel person = new PersonViewModel
                {
                    Personel = _mapper.Map<Sys_Person, Sys_PersonDto>(datas),
                    //PersonelPosition = _mapper.Map<List<Gnl_PersonConPosition>, List<Gnl_PersonConPositionDto>>(datas.PersonConPositions.ToList()),
                    PersonelCard = _mapper.Map<Sys_PersonCard, Sys_PersonCardDto>(datas.PersonCard),
                    PersonPassaport = _mapper.Map<Gnl_PersonPassaport, Gnl_PersonPassaportDto>(datas.PersonPassaport),
                    User = _mapper.Map<Sys_User, Sys_UserDto>(datas.SysUser),
                };

                return View(person);

            }

        }

        [HttpPost]
        public IActionResult AddPerson(PersonViewModel person)
         {
            _personService.Add(person);
            return View("Personel");
        }
        public IActionResult UpdatePerson(PersonViewModel person)
        {
            _personService.Update(person);  

            return View("Personel");
        }
        public IActionResult DetailPerson(int Id)
        {


            return View();
        }

    }
}
