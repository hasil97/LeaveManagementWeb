using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Data
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; } //Foreign key addition. Go to LeaveAllocation dm to get in depth
        public DateTime DateRequested { get; set; }
        public string? RequestComments   { get; set; }

        public bool? Approved   { get; set; } //nullable bool cause we want a neutral option untill the manager either approves or denies
        public bool Cancelled   { get; set; }
        public string RequestingEmployeeId { get; set; } //The Id of the logged in user to know who is applying for the field
    }
}
