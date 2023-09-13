namespace DevGenious.Domain.Service.DTO;
public class AuditableForCreationDTO
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}