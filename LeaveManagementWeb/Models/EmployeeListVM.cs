using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [Display(Name = "First Name")]
        public string Firstname { get; set; }
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Display(Name = "Date Joined")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")] //The display format annotation helps to format the date to the required format
        [DataType(DataType.Date)] //This ensure datatype that we is displayed gets converted from datetime to date
        public DateTime DateJoined { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
