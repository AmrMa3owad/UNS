namespace Orion.Shared.Enums
{
    public enum ErrorCodes
    {
        UserInfoNotMatch = 0100,
        UserNotAllowed = 0101,
        UserLockedOut = 0102,
        UserPasswordNotValid = 0103,
        UserPasswordRequirementNotMet = 0104,

        NotFound = 01,
        CreateRequiresFields = 02,
        TokenInvalid = 03,
        CreateFailed = 04,
        UpdateFailed = 05,
        DeleteFailed = 06
    }
}
