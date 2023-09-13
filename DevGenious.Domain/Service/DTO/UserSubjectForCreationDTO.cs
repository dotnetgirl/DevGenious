namespace DevGenious.Domain.Service.DTO;
public class UserSubjectForCreationDTO : AuditableForCreationDTO
{
    public int UserId { get; set; }
    public int SubjectId { get; set; }
}