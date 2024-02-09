using System.Collections.Generic;

namespace EF_Task_2.Entities;

public class Student : BaseEntity
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Term { get; set; }

    // Foreign Keys
    public int Id_Group { get; set; }

    // Navigation Properties
    public Group Group { get; set; }
    public ICollection<S_Card> S_Cards { get; set; }
}