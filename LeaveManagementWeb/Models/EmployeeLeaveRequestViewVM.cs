namespace LeaveManagementWeb.Models
{
    public class EmployeeLeaveRequestViewVM
    {
        public EmployeeLeaveRequestViewVM(List<LeaveRequestVM> leaveRequest, List<LeaveAllocationVM> leaveAllocation)
        {
            LeaveRequest = leaveRequest;
            LeaveAllocation = leaveAllocation;
        } //This ctor is used so that when we instantiate the class from elsewhere, we can do so by passing in certain params and the object will be automatically created
        // without the need of assigning each property manually

        public List<LeaveRequestVM> LeaveRequest { get; set; }
        public List<LeaveAllocationVM> LeaveAllocation { get; set; }

    }
}
