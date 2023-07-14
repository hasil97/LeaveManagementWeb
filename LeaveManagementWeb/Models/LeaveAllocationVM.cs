using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveAllocationVM /*This VM is used to display the number of days allocated for an employee and the name of the leavetype, the default days and the remaining days*/
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        [Required]
        [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
        public int NumberOfDays { get; set; }

        [Display(Name = "Allocation Period")]
        [Required]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}