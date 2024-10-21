using System;
using System.Collections.Generic;

namespace EmployeeInfo.Models;

public partial class Education
{
    public int EducationId { get; set; }

    public string EducationLevel { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
