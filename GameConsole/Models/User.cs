using System;
namespace GameConsole.Models;
internal class User
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public List<HighScore> HighScores { get; set; }

    public User(string name, string username, string password)
    {
        Name = name;
        Username = username;
        Password = password;
        HighScores = new List<HighScore>();
    }
}
