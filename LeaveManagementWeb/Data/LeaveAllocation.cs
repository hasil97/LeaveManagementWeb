using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        public int Period { get; set; } //The year like 2022, 2023 etc.

        public LeaveType LeaveType { get; set; } //Here we need to create a foreign key which connects to a table's primary key. So first we need to create a class variable
                                                 //with datatype as name of the parent class/table. Then we need to give the class name as the same.
                                                 
        public int LeaveTypeId { get; set; }     //Now THE VERY NEXT LINE we need to give the name of the foreign key which SHOULD BE ClassNameId i.e parent class name and ('Id' or the 
                                                 //name of the coloumn which is the primary key of parent table). Following this format is a must for entityframework to work.

        public string EmployeeId { get; set; }
    }
}


/*Alternatively, to create a foreign key, we can follow the following format
    public class LeaveAllocation
{
    public int NumberOfDays { get; set; }
    
    [ForeignKey("somecoloumnname")]
    
    public LeaveType LeaveType { get; set; } (The datatype should be parent class and variable name should be the same aswell)
                                             

    public int somecoloumnname { get; set; }   (Doesn't necessarily have to be the very next line nor it need to be ParentClassName + Id i.e LeaveTypeId)   
                                             

    public string EmployeeId { get; set; }
}*/

