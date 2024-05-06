using System;
using System.Collections.Generic;

namespace AuthorizationExample
{
    // Enum to define user roles
    enum UserRole
    {
        Admin,
        Moderator,
        User
    }

    // Sample user class
    class User
    {
        public string Username { get; set; }
        public UserRole Role { get; set; }
    }

    // Authorization service
    class AuthorizationService
    {
        private List<User> users;

        public AuthorizationService()
        {
            // Sample user data
            users = new List<User>
            {
                new User { Username = "admin", Role = UserRole.Admin },
                new User { Username = "moderator", Role = UserRole.Moderator },
                new User { Username = "user1", Role = UserRole.User },
                // Add more users as needed
            };
        }

        public bool IsAuthorized(string username, UserRole requiredRole)
        {
            User user = users.Find(u => u.Username == username);
            return user != null && user.Role >= requiredRole;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AuthorizationService authService = new AuthorizationService();

            // Example usage
            string username = "admin";
            UserRole requiredRole = UserRole.Moderator;

            bool isAuthorized = authService.IsAuthorized(username, requiredRole);

            if (isAuthorized)
            {
                Console.WriteLine($"{username} is authorized to perform this action.");
            }
            else
            {
                Console.WriteLine($"{username} is not authorized to perform this action.");
            }
            Console.ReadLine();
        }
    }
}
