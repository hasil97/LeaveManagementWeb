using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name ="Start Date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [Required]
        [Display(Name = "Leave Type Id")]
        public int LeaveTypeId { get; set; } //Foreign key addition. Go to LeaveAllocation dm to get in depth
        public SelectList? LeaveTypes { get; set; }
        [Display(Name = "Request Comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) //this comes from implementing the interface IValidableObject
                                                                                           //In here we can type in the validation requirements of the above view model.
                                                                                           
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date must be before End Date", new[] { nameof(StartDate), nameof(EndDate)}); //First param says the error message
                                                                                                                                   // Second param is an array which says on which all
                                                                                                                                   //coloumns should this error message be displayed
            }

            if(RequestComments?.Length > 250)
            {
                yield return new ValidationResult("Comments are too long. Restrict to a total of 250 characters", new[] { nameof(RequestComments) }); // for multiple returns, we use yield return
            }
        }
    }
}
