using Comprehensive.Repository.Context;
using Comprehensive.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprehensive.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        ApplicationDbContext Context { get; }
        EventsRepository EventsRepository { get; }
    }
}
