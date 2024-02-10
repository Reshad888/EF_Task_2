using System;
using System.Collections.Generic;

namespace EF_Task_2.Entities;

public class S_Card : BaseEntity
{
    // Properties
    public DateTime DateOut { get; set; }
    public DateTime? DateIn { get; set; }

    // Foreign Keys
    public int Id_Student { get; set; }
    public int Id_Book { get; set; }
    public int Id_Lib { get; set; }

    // Navigation Properties
    public Student Student { get; set; }
    public Book Book { get; set; }
    public Lib Lib { get; set; }
}