using System.Collections.Generic;

namespace EF_Task_2.Entities;

public class Faculty : BaseEntity
{
    // Properties
    public string Name { get; set; }

    // Navigation Properties
    public ICollection<Group> Groups { get; set; }
}