using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository //The ILTR means this class should implement all the methods in ILTR
                                                                                    //The methods are defined in GR therefore we should inherit the class GR and note interface IGR
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context) //This line specifies that LTR inherits from db and : base(context) basically means 
                                                                                 //GenRep class also inherits from db
        {
        }
    }
}
