using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MeetAndPlay.Data.DTO;
using MeetAndPlay.Data.DTO.ReadFilters;

namespace MeetAndPlay.Core.Abstraction.Services.ReadService
{
    public interface IReadService<TEntity>
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IReadOnlyList<TEntity>> GetAsync(ReadFilter filter);
        Task<CountArray<TEntity>> GetAsyncAsCountArray(ReadFilter filter);
    }
}