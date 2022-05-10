using Comprehensive.Entities.Entities;
using Comprehensive.Repository.Context;
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
    public class EventsRepository
    {
        private readonly ApplicationDbContext _db;
        public EventsRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<EventsM>> GetAllAsync()
        {
            return await _db.EventsModel.ToListAsync();
        }

        public async Task<List<EventsM>> GetAllByDateAsync(DateTime date)
        {
            return await _db.EventsModel.Where(x => x.Date == date).ToListAsync();
        }

        public async Task<List<EventsM>> GetAllByValidity(bool binary)
        {
            return await _db.EventsModel.Where(x => x.IsValid == binary).ToListAsync();
        }

        public async Task<EventsM> GetByIdAsync(long id)
        {
            return await _db.EventsModel.SingleAsync(x => x.EventId == id);
        }

        public async Task<EventsM> CreateAsync(EventsM model)
        {
            var result = new EventsM();
            result.EventId = model.EventId;
            result.EventName = model.EventName;
            result.Date = model.Date;
            result.State = model.State;
            result.City = model.City;
            result.Address = model.Address;
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

        public async Task<EventsM> UpdateAsync(EventsM model)
        {
            var result = new EventsM();
            result.EventId = model.EventId;
            result.EventName = model.EventName;
            result.Date = model.Date;
            result.State = model.State;
            result.City = model.City;
            result.Address = model.Address;
            result.IsValid = model.IsValid;

            var error = true;
            var message = ReturnTypeRegistryEnum.None.GetDescription();

            try
            {
                _db.Entry(result).State = EntityState.Added;

                try
                {
                    long i = await _db.SaveChangesAsync();
                    if (i == 1)
                    {
                        message = ReturnTypeRegistryEnum.AlteredSuccessfully.GetDescription();
                        error = false;
                    }
                    else
                    {
                        message = ReturnTypeRegistryEnum.NotAltered.GetDescription();
                    }
                }
                catch (Exception e)
                {
                    message = ReturnTypeRegistryEnum.ExceptionAlter.GetDescription();
                    model.Exception = e;
                }
            }
            catch (Exception e)
            {
                model.Message = ReturnTypeRegistryEnum.ExceptionAlterChange.GetDescription();
                model.Exception = e;
            }

            model.Error = error;
            model.Message = message;
            return model;
        }

        public async Task<EventsM> DeleteByIdAsync(long id)
        {
            var result = await _db.EventsModel.Include(c => c.EventId).SingleAsync(x => x.EventId == id);
            var error = true;
            var message = ReturnTypeRegistryEnum.None.GetDescription();

            if (result != null)
            {
                _db.Entry(result).State = EntityState.Deleted;
                _db.EventsModel.Remove(result);
            }

            try
            {
                if (await _db.SaveChangesAsync() > 0)
                {
                    message = ReturnTypeRegistryEnum.AlteredSuccessfully.GetDescription();
                    error = false;
                }
                else
                {
                    message = ReturnTypeRegistryEnum.NotAltered.GetDescription();
                }
            }
            catch (Exception e)
            {
                result.Exception = e;
            }

            result.Error = error;
            result.Message = message;
            return result;
        }

    }
}
