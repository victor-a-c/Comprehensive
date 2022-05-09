using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprehensive.Entities.Entities
{
    public class EventsModel : BaseModel
    {
        [Column("EventId")]
        public long EventId { get; set; }

        [Column("EventName")]
        public string? EventName { get; set; }

        [Column("EventDate")]
        public DateTime Date { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("State")]
        public string State { get; set; }

        [Column("EventAddress")]
        public string? Address { get; set; }

        [Column("IsValid")]
        public bool? IsValid { get; set; }
    }
}
