namespace Insurance.entity
{
    // Represents a system user (e.g., Admin, Client, etc.)
    public class User
    {
        // Unique identifier for the user
        public int UserId { get; set; }

        // Username for login
        public string Username { get; set; }

        // User's password (should be securely handled in real systems)
        public string Password { get; set; }

        // Role of the user (e.g., Admin, User)
        public string Role { get; set; }

        // Default constructor
        public User() { }

        // Parameterized constructor to initialize properties
        public User(int userId, string username, string password, string role)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Role = role;
        }

        // Override to display user info (excluding password for security)
        public override string ToString() => $"UserId: {UserId}, Username: {Username}, Role: {Role}";
    }
}
