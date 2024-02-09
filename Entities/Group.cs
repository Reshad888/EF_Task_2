namespace EF_Task_2.Entities;

public class Group : BaseEntity
{
    // Properties
    public string Name { get; set; }

    // Foreign Keys
    public int Id_Faculty { get; set; }

    // Navigation Properties
    public Faculty Faculty { get; set; }
}