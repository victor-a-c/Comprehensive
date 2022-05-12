using System.ComponentModel.DataAnnotations;

namespace Comprehensive.Web.ViewModel.Base
{
    public class BaseViewModel
    {
        [Display(Name = "Id")]
        public long Id { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }
    }
}
