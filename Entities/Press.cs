using System.Collections.Generic;

namespace EF_Task_2.Entities;

public class Press : BaseEntity
{
    // Properties
    public string Name { get; set; }

    // Navigation Properties
    public ICollection<Book> Books { get; set; }
}