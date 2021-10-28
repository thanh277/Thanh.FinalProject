using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Thanh.FinalProject.Areas;
using Thanh.FinalProject.services.Contracts;
using Thanh.FinalProject.services.Dto;
using Thanh.FinalProject.Shops;
using Thanh.FinalProject.test;

namespace Thanh.FinalProject.services.Repository
{


    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaRepository _areaRepo;
        public AreaController(IAreaRepository areaRepo)
        {
            _areaRepo = areaRepo;
        }
        [HttpGet("api/dapper/getName")]
        public async Task<IActionResult> GetName()
        {
            try
            {
                var areas = await _areaRepo.GetName();
                return Ok(areas);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("api/dapper/getbyID")]
        public async Task<IActionResult> GetID(Guid id)
        {


            try
            {
                var areasID = await _areaRepo.GetID( id);
                return Ok(areasID);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }


        }
        [HttpGet("api/dapper/Getall")]
        public async Task<IActionResult> GetListAsync()
        {
            try
            {
                var Aareas = await _areaRepo.GetListAsync();
                return Ok(Aareas);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("api/dapper/Create")]
        public async Task<IActionResult> CreateAsync(Area area)
        {
            try
            {
                var Careas = new Area
                {
                    Name = area.Name,
                    Address = area.Address
                };
                await _areaRepo.CreateAsync(Careas);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


        }
        [HttpDelete("api/dapper/DeletebyName")]
        public async Task<IActionResult> DeleteAsync(Area area)
        {
            try
            {
                var Dareas = new Area
                {
                    Name = area.Name
                }; await _areaRepo.DeleteAsync(Dareas);
                return Ok(Dareas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpDelete("api/dapper/DeletebyID")]
        public async Task DeleteAsync(Guid id)
        {

            await _areaRepo.DeleteAsync(id);


        }
       //[HttpPut("api/dapper/Update")]
       

            // [HttpGet("api/Dapper/GetbyID")]
            //public async Task<IActionResult> GetID(string id)
            //  {
            //    try
            //   {
            //          var area = await _areaRepo.GetID(id);
            //      if (area == null)
            //          return NotFound();
            //    return Ok(area);
            //  }
            // catch (Exception ex)
            //    {
            //log error
            //     return StatusCode(500, ex.Message);
            //     }
            // }
            // [HttpPost("api/Dapper/Create")]
            //public async Task<IActionResult> CreateAsync(AreaCreationDto area)
            //{
            //  try
            //  {
            // var createdArea = await _areaRepo.CreateAsync(area);
            //      return CreatedAtRoute("AreaById", new { id = createdArea.Id }, createdArea);
            //    }
            //  catch (Exception ex)
            //   {
            //log error
            //       return StatusCode(500, ex.Message);
            // }
            //  }

        }
    }
//}
