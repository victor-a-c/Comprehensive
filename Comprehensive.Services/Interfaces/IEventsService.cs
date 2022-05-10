using Comprehensive.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprehensive.Services.Interfaces
{
    public interface IEventsService
    {
        Task<EventsM> CreateAsync(EventsM param);
        Task<EventsM> UpdateAsync(EventsM param);
        Task<EventsM> DeleteByIdAsync(long id);
        Task<EventsM> GetByIdAsync(long id);
        Task<List<EventsM>> GetAllAsync();
        Task<List<EventsM>> GetAllByDateAsync(DateTime date);
        Task<List<EventsM>> GetAllByValidityAsync(bool binary);
    }
}
