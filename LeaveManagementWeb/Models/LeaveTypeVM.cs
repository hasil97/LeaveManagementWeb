using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveTypeVM /*(We are creating a view model so that this is displayed to the user and the user interacts with this class
                              * It is better to prevent the user from interacting with the Data model)*/
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1, 25, ErrorMessage ="Please enter a valid number")]

        public int DefaultDays { get; set; }

    }
}  