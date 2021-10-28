using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Thanh.FinalProject.Areas;
using Thanh.FinalProject.Shops;
using Thanh.FinalProject.test;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Thanh.FinalProject.services.ITable1AppService
{
    public class IShop : ApplicationService,IShopAppService
    {
        private readonly IRepository<Shop, Guid> _ShopRepos;
       

        public IShop(IRepository<Shop, Guid> repository)
        {
            _ShopRepos = repository;
        }
        [HttpPost("api/Shop/Post")]
        public async Task<ShopDto> CreateAsync(CreateUpdateShop input)
        { 
            var getName = await _ShopRepos.FirstOrDefaultAsync(x => x.Name == input.Name);
            if (getName != null)
            {
                throw new UserFriendlyException("Ten bi trung ");
            }
            var shop = new Shop
            {
                Name = input.Name,
                Size = input.Size,
                Address= input.Address
                

            };
            await _ShopRepos.InsertAsync(shop);
            return ObjectMapper.Map<Shop, ShopDto>(shop);
        }

        [HttpDelete("api/Shop/deletebyid")]
        public async Task DeleteAsync(Guid id)
        {
          
            await _ShopRepos.DeleteAsync(id);

        }
        [HttpDelete("api/Shop/deletebyInfo")]
        public async Task<ShopDto> DeleteAsync(CreateUpdateShop input) {
            if (string.IsNullOrEmpty(input.Name))
            {
                throw new UserFriendlyException("Khong duoc de trong");
            }
            
            var shop = new Shop
            {
                Name = input.Name
            };
            await _ShopRepos.DeleteAsync(shop);
            return ObjectMapper.Map<Shop, ShopDto>(shop);
        }

        [HttpGet("api/Shop/GetbyID")]
        public async Task<ShopDto> GetAsync(Guid id)
        {
            var shop = await _ShopRepos.GetAsync(id);
            return ObjectMapper.Map<Shop, ShopDto>(shop);
        }


        [HttpGet("api/Shop/getAll")]
        public async Task<List<ShopDto>> GetListAsync()
        {
            var query = await _ShopRepos.ToListAsync();
                return query.Select(x => new ShopDto
                {
             Name = x.Name,
            Size =  x.Size,
            Address= x.Address
            }).ToList();
           // return query;
 
        }

      

        [HttpPut("api/Shop/update")]
        public async Task UpdateAsync(Guid id, CreateUpdateShop input)
        {
            var getName = await _ShopRepos.FirstOrDefaultAsync(x => x.Name == input.Name);
            if (getName != null)
            {
                throw new UserFriendlyException("Ten bi trung ");
            }
            var UShop = await _ShopRepos.GetAsync(id);
            if (string.IsNullOrEmpty(input.Name)) {
                throw new UserFriendlyException("Khong duoc de trong");
            }
            UShop.Name =  input.Name;
            UShop.Size = input.Size;
            UShop.Address = input.Address;
            
           
            await _ShopRepos.UpdateAsync(UShop);
           
        }
      
        Task<List<ShopDto>> IShopAppService.GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        

        // [HttpPut("{id}")]
        //public IActionResult PUT (Guid id, [FromBody] Student student)
        //{
        //  var dbStudent = _context.Students
        //        .FirstOrDefault(s => s.Id.Equals(id));

        //  dbStudent.Age = student.Age;
        //dbStudent.Name = student.Name;
        //dbStudent.IsRegularStudent = student.IsRegularStudent;

        //    _context.SaveChanges();

        //  return NoContent();
        //}

    }
}
