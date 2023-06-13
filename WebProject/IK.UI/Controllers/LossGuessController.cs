using AutoMapper;
using IK.Application.DTOs;
using IK.Application.Interfaces.Services;
using IK.Application.Services;
using IK.Application.ViewModels;
using IK.Domain.Concrete.Sys;
using IK.Domain.Concrete.Tahmin;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace IK.UI.Controllers
{
    public class LossGuessController : Controller
    {
        private readonly IZararTahminiService _zararService;
        private readonly ITotalTahminService _totalService;
        private readonly IMapper _mapper;

        public LossGuessController(IZararTahminiService zararService, ITotalTahminService totalService, IMapper mapper)
        {
            _zararService = zararService;
            _totalService = totalService;
            _mapper = mapper;
        }

        public async Task<IActionResult> PersonelList()
        {
            var zarar = await _zararService.GetAllAsync();
            var total = await _totalService.GetAllAsync();
            if(total.Count() > 0)
            {
                totaltahminDto total2 = _mapper.Map<totaltahmin, totaltahminDto>((totaltahmin)total.First());
                return View(total2);
            }
            return View();

        }
        public async Task<IActionResult> GetLossGuess(int id)
        {
            return View();

        }
    }
}