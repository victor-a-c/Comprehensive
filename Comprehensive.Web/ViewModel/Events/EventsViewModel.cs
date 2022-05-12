using Comprehensive.Web.ViewModel.Base;
using System.ComponentModel.DataAnnotations;

namespace Comprehensive.Web.ViewModel.Events
{
    public class EventsViewModel : BaseViewModel
    {

        [Display(Name = "EventName")]
        public string? EventName { get; set; }

        [Display(Name = "EventDate")]
        public DateTime Date { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "EventAddress")]
        public string? Address { get; set; }

        [Display(Name = "IsValid")]
        public bool? IsValid { get; set; }
    }
}
