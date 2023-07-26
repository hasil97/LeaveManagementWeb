using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId); //Give a list of allocations. the param being passed is employees id
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id); //Only brings in a single allocation. the param being passed is the leave allocation id
        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}
