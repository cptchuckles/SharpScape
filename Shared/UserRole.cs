namespace SharpScape.Shared.UserRole{
    public static class UserRole
    {
        public static string RoleType(this Role role)
        {
            return (role == Role.User) ? "User" : "Admin";
        }

        public enum Role
        {
            Admin = 1,
            User = 2
        }
    }
}