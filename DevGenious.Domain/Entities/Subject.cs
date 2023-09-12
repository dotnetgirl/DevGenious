using DevGenious.Domain.Commons;

namespace DevGenious.Domain.Entities;

public class Subject : Auditable
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
}
