using Comprehensive.Repository.UnitOfWork;
using Comprehensive.Services.Interfaces;
using Comprehensive.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comprehensive.Entities.Entities;

namespace Comprehensive.Services.Services
{
    public class EventsService : IEventsService
    {
        protected readonly IUnitOfWork _iUnitOfWork;

        public EventsService(IUnitOfWork iUnitOfWork, IEvLogService iEvLogService)
        {
            _iUnitOfWork = iUnitOfWork;
        }

        public async Task<EventsM> CreateAsync(EventsM param)
        {
            try
            {
                return await _iUnitOfWork.EventsRepository.CreateAsync(param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EventsM> UpdateAsync(EventsM param)
        {
            try
            {
               return await _iUnitOfWork.EventsRepository.UpdateAsync(param);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EventsM> DeleteByIdAsync(EventsM param)
        {
            try
            {
                return await _iUnitOfWork.EventsRepository.DeleteByIdAsync(param.EventId);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task<EventsM> GetByIdAsync(long id)
        {
            try
            {
                return await _iUnitOfWork.EventsRepository.GetByIdAsync(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
