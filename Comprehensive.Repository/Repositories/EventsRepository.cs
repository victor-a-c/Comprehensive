using Comprehensive.Entities.Entities;
using Comprehensive.Repository.Context;
using Comprehensive.Repository.Interfaces;
using Comprehensive.Utilities.Enum;
using Comprehensive.Utilities.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprehensive.Repository.Repositories
{
    internal class EventsRepository : IEventsRepository
    {
        private readonly ApplicationDbContext _db;
        public EventsRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        //public async Task<List<EventsModel>> GetAllById(long eventId)
        //{
        //    return await _db.EventsModel.SingleAsync(x => x.EventId == eventId);
        //}

        public async Task<List<EventsModel>> GetAllAsync()
        {
            return await _db.EventsModel.ToListAsync();
        }

        public async Task<EventsModel> CreateAsync(EventsModel model)
        {
            var result = new EventsModel();
            result.EventId = model.EventId;
            result.EventName = model.EventName;
            result.EventDate = model.EventDate;
            result.EventAddress = model.EventAddress;
            result.IsValid = model.IsValid;

            var error = true;
            var message = ReturnTypeRegistryEnum.None.GetDescription();

            try
            {
                _db.Entry(result).State = EntityState.Added;

                try
                {
                    long i = await _db.SaveChangesAsync();
                    if(i == 1)
                    {
                        message = ReturnTypeRegistryEnum.IncludedSuccessfully.GetDescription();
                        error = false;
                    }
                    else
                    {
                        message = ReturnTypeRegistryEnum.NotIncluded.GetDescription();
                    }
                }
                catch (Exception e)
                {
                    message = ReturnTypeRegistryEnum.ExceptionInclude.GetDescription();
                    model.Exception = e;
                }
            }
            catch(Exception e)
            {
                model.Message = ReturnTypeRegistryEnum.ExceptionIncludeChange.GetDescription();
                model.Exception = e;
            }

            model.Error = error;
            model.Message = message;
            return model;
        }

    }
}
