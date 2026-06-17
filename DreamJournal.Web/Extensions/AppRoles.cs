namespace DreamJournal.Web.Extensions
{
    public static class AppRoles
    {
        public const string Admin = "Admin";
        public const string User = "User";

        public static readonly IReadOnlyList<string> AllRoles = new[] { Admin, User };
    }
}
