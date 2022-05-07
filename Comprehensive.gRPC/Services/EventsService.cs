using Comprehensive.gRPC;
using Grpc.Core;

namespace Comprehensive.gRPC.Services
{
    public class EventsService : EventsS.EventsSBase
    {
        private readonly ILogger<EventsService> _logger;
        public EventsService(ILogger<EventsService> logger)
        {
            _logger = logger;
        }

        public override Task<EventsModel> GetEvent(GetEventRequest request, ServerCallContext context)
        {
            return null;
        }
    }
}