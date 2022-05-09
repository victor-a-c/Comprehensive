using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprehensive.Entities.Entities
{
    public class EventsModel
    {
        [Column("EventId")]
        public int EventId { get; set; }

        [Column("EventName")]
        public string? EventName { get; set; }

        [Column("EventDate")]
        public DateTime EventDate { get; set; }

        [Column("EventAddress")]
        public string? EventAddress { get; set; }

        [Column("IsValid")]
        public bool? IsValid { get; set; }
    }
}
