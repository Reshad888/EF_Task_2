using System.Collections.Generic;

namespace EF_Task_2.Entities;

public class Department : BaseEntity
{
    // Properties
    public string Name { get; set; }

    // Navigation Properties
    public ICollection<Teacher> Teachers { get; set; }
}