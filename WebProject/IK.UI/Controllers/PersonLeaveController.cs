using AutoMapper;
using IK.Application.DTOs;
using IK.Application.InitData;
using IK.Application.Interfaces.Services;
using IK.Domain.Concrete.Gnl;
using IK.Persistence.Utilities.DataTables;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace IK.UI.Controllers
{
    public class PersonLeaveController : Controller
    {
        private readonly IPersonLeaveService _leaveService;
        private readonly IGnlLeaveTypeService _leaveTypeService;
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonLeaveController(IPersonLeaveService leaveService, IPersonService personService, IGnlLeaveTypeService leaveTypeService, IMapper mapper)
        {
            _leaveService = leaveService;
            _leaveTypeService = leaveTypeService;
            _personService = personService;
            _mapper = mapper;
        }

        public IActionResult LeaveList()
        {
            return View();
        }
        public async Task<IActionResult> Leave(int Id)
        {
            var data = await _leaveTypeService.GetAllAsync();
            ViewBag.InitData = data.Select(x => new Gnl_LeaveTypeDto(x)).ToList();
            var person =  _personService.GetById(Id);
            ViewBag.Name = person.Name;
            ViewBag.PersonId = Id;
            return View();
        }

        [HttpPost]
        public IActionResult AddLeave(Gnl_LeaveDto leave,IFormFile file)
        {
            leave.LFile = file.FileName;
            _leaveService.Add(leave);
            return Redirect("/PersonLeave/LeaveList");
        }
        [HttpPost]
        public async Task<IActionResult> GetLeaveList(int Id)
        {
            var data = await _leaveService.GetById(Id);
            var map = _mapper.Map<List<Gnl_LeaveDto>>(data);

            return Ok(new DtResult<Gnl_LeaveDto>
            {

                data = map,
                draw = 1,
                recordsTotal = 1,
                recordsFiltered = 1,

            }
            );
        }
        public IActionResult LeaveCalendar()
        {
            return View();
        }
        public IActionResult LeaveRequest()
        {
            return View();
        }
    }
}
