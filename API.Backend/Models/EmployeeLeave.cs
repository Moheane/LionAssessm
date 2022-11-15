using System;
using System.Collections.Generic;

namespace API.Backend.Models;

public partial class EmployeeLeave
{
    public int EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string TypeofLeave { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public DateTime LeaveStart { get; set; }

    public DateTime LeaveEnd { get; set; }

    public int TotalLeavesTaken { get; set; }

    public int TotalLeavesLeft { get; set; }
}
