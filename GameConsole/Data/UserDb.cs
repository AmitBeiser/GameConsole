using System;
using GameConsole.Models;
namespace GameConsole.Data;
internal class UserDb
{
    private static List<User> users;
    public static User RegisterUser(string name, string uName, string password)
        {
            if (users.Any(u => u.Username == uName))
            {
                throw new InvalidOperationException("the user exists already");
            }
            User newuserrrr = new User(name, uName, password);
            users.Add(newuserrrr);
            return newuserrrr;
        }
        public static User Login(string name, string password)
        {
             return users.FirstOrDefault(u => u.Username == name && u.Password == password); 
        }
        public static void Update(User u)
        {
            if (users.Any(user => user == u))
            {
                users.Where(user => user == u).FirstOrDefault().Password = u.Password;
                users.Where(user => user == u).FirstOrDefault().Name = u.Name;
            }
            else
                throw new InvalidOperationException("no such user exists");
        }
}