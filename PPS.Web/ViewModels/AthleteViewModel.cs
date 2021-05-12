using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VMS.Web.ViewModels
{
    public class AthleteViewModel
    {
        // selectlist of Athletes (id, name)       
        public SelectList Athletes { set; get; }

        // Collecting AthleteId and Issue in Form
        [Required]
        [Display(Name = "Select Athlete")]
        public int AthleteId { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string Issue { get; set; }
    }

}
