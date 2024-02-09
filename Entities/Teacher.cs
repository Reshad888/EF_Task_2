using System.Collections.Generic;

namespace EF_Task_2.Entities;

public class Teacher : BaseEntity
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Foreign Keys
    public int Id_Dep { get; set; }

    // Navigation Properties
    public Department Department { get; set; }
    public ICollection<T_Card> T_Cards { get; set; }
}