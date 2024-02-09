using System.Collections.Generic;

namespace EF_Task_2.Entities;

public class Book : BaseEntity
{
    // Properties
    public string Name { get; set; }
    public int Pages { get; set; }
    public int YearPress { get; set; }
    public string Comment { get; set; }
    public int Quantity { get; set; }

    // Foreign Keys
    public int Id_Theme { get; set; }
    public int Id_Category { get; set; }
    public int Id_Author { get; set; }
    public int Id_Press { get; set; }

    // Navigation Properties
    public Theme Theme { get; set; }
    public Category Category { get; set; }
    public Author Author { get; set; }
    public Press Press { get; set; }
    public ICollection<T_Card> T_Cards { get; set; }
    public ICollection<S_Card> S_Cards { get; set; }
}