using System;

namespace EF_Task_2.Entities;

public class BaseEntity
{
    // Properties
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
}