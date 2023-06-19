using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_application.Models;

namespace Project_application.Screens
{
    public class AccountUser
    {
        List<User> users = new List<User>();

        public void CreateAccount(string username, string password)
        {
            users.Add(new User(username, password));
            Console.WriteLine("Account created successfully!");
        }

        public void Login(string username, string password)
        {
            User user = FindUser(username, password);
            if (user != null)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Invalid username or password! Please try again.");
            }
        }
        private User FindUser(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.username == username && user.password == password)
                {
                    return user;
                }
            }
            return null;
        }
        private User FindUser(string username)
        {
            foreach (User user in users)
            {
                if (user.username == username)
                {
                    return user;
                }
            }
            return null;
        }
        public void UpdatePassword(string username, string newPassword)
        {
            User user = FindUser(username);
            if (user != null)
            {
                user.password = newPassword;
                Console.WriteLine("Password updated successfully");
            }
            else
            {
                Console.WriteLine("User not found! Please check the username.");
            }
        }

        public void UpdateUsername(string currentUsername, string newUsername, string password)
        {
            User user = FindUser(currentUsername, password);
            if (user != null)
            {
                user.username = newUsername;
                Console.WriteLine("Username updated successfully");
            }
            else
            {
                Console.WriteLine("Invalid username or password! Please try again.");
            }
        }

        public void DeleteAccount(string username, string password)
        {
            User user = FindUser(username, password);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("Account deleted successfully");
            }
            else
            {
                Console.WriteLine("Invalid username or password! Please try again.");
            }
        }
    }
}
