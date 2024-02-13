﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;

        public WorkLocationController(IWorkLocationService workLocationService)
        {
            _workLocationService = workLocationService;
        }

        [HttpGet]
        public IActionResult WorkLocationList()
        {
            var values = _workLocationService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation workLocation)
        {
            _workLocationService.TInsert(workLocation);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _workLocationService.TGetById(id);
            _workLocationService.TDelete(values);
            return Ok();
        }
       
        [HttpGet("{id}")]
        public IActionResult GetWorkLocation(int id)
        {
            var values = _workLocationService.TGetById(id);

            return Ok(values);
        }
    }
}
