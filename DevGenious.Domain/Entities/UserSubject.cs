using DevGenious.Domain.Commons;

namespace DevGenious.Domain.Entities;

public class UserSubject : Auditable
{
    public long UserId { get; set; } 
    public long SubjectId { get; set; } 
}
