using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprehensive.Entities.Entities
{
    public class BaseModel
    {
        [NotMapped]
        public bool Error { get; set; }

        [NotMapped]
        public string? Message { get; set; }

        [NotMapped]
        public Exception? Exception { get; set; }

        [NotMapped]
        public bool RegisteredItem { get; set; }
    }
}
