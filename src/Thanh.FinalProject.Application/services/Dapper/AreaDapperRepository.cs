using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Thanh.FinalProject.Areas;
using Thanh.FinalProject.EntityFrameworkCore;
using Thanh.FinalProject.services.Context;
using Thanh.FinalProject.services.Contracts;
using Thanh.FinalProject.services.Dto;
using Thanh.FinalProject.Shops;
using Thanh.FinalProject.test;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace Thanh.FinalProject.services.Dapper
{
    public class AreaDapperRepository : DapperRepository<FinalProjectDbContext>, ITransientDependency,IAreaRepository
    {   
        public AreaDapperRepository(IDbContextProvider<FinalProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public virtual async Task<List<string>> GetName()
        {
            var dbConnection = await GetDbConnectionAsync();
            return (await dbConnection.QueryAsync<string>("select Name from AppAreas", transaction: await GetDbTransactionAsync()))
                .ToList();
        }
        public async Task<List<Area>> GetListAsync()
        {
            var dbConnection = await GetDbConnectionAsync();
            var getData = await dbConnection.QueryAsync<Area>("select * from AppAreas", transaction: await GetDbTransactionAsync());
            return getData.ToList();
        }

        public async Task<int> Update(Guid id, CreateUpdateArea input)
        {
            var dbConnection = await GetDbConnectionAsync();
           return  await dbConnection.ExecuteAsync("update AppAreas set Name = @NewName ,Address =@NewAddress", new { NewName = input.Name, NewAddress=input.Address },
                 transaction: await GetDbTransactionAsync());
        }
        public async Task CreateAsync(Area area)
        {
            var sql = "INSERT INTO AppAreas (Id,Name,Address) VALUES (@Id,@Name,@Address)";

            var dbConnection = await GetDbConnectionAsync();
            await dbConnection.ExecuteAsync(sql, new
            {
                Id = Guid.NewGuid(),
                Name = area.Name,
                Address = area.Address,
                
            }, await GetDbTransactionAsync());
        }
        public virtual async Task<int> GetID(Guid id)
        {
            var dbConnection = await GetDbConnectionAsync();
            return await dbConnection.ExecuteAsync("select * from AppAreas where(Id =@Id)", new {Id= id },
                  transaction: await GetDbTransactionAsync());
            //  "select * from AppAreas where( ID =@ID)"
        }

        public async Task DeleteAsync(Area area)
        {
            var sql = "DELETE FROM AppAreas WHERE Name = @Name;";
            var dbConnection = await GetDbConnectionAsync();
            await dbConnection.ExecuteAsync(sql, new { 
            
             Name = area.Name 
            }, await GetDbTransactionAsync());



        }

        public async Task DeleteAsync(Guid id)
        {
            var dbConnection = await GetDbConnectionAsync();
            await dbConnection.ExecuteAsync("DELETE FROM AppAreas WHERE Id = @NewID", new { NewID = id },
                transaction: await GetDbTransactionAsync()); ;
        }
        public  async Task UpdateAsync(Guid id, CreateUpdateArea input)
        {
            var dbConnection = await GetDbConnectionAsync();
             await dbConnection.ExecuteAsync("update AppAreas set Id= @ID Name = @NewName, Address =@NewAddress", new { NewName = input.Name, NewAddress= input.Address, ID = id  },
                 await GetDbTransactionAsync());
        }
    }
}