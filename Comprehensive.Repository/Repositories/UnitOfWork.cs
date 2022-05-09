using Comprehensive.Repository.Context;
using Comprehensive.Repository.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprehensive.Repository.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private EventsRepository _eventsRepository;

        public UnitOfWork(IConfiguration iConfiguration)
        {
            Context = new ApplicationDbContext(iConfiguration);
        }

        public ApplicationDbContext Context { get; }

        public EventsRepository EventsRepository
        {
            get 
            {
                _eventsRepository = new EventsRepository(Context);
                return _eventsRepository; 
            }
        }
    }
}
