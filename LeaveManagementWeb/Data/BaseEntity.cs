namespace LeaveManagementWeb.Data
{
    public abstract class BaseEntity //here abstract means we cannot use this class alone. This class only works when some other class inherits from this class.
    {
        public int Id { get; set; } //We dont need to explicitly specify primary key as EntityFrameWork will do that for us when we give coloumn name as Id

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
