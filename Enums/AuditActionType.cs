namespace SchoolSystem.Domain.Enums;

public enum AuditActionType
{
    Created,
    Updated,
    Deleted,
    Login,
    Logout,
    InviteSent,
    ApplicationSubmitted,
    ApplicationReviewed,
    GradeAssigned,
    ClassAssigned
}