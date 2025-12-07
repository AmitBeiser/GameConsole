using System;
using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
namespace GameConsole.Pages;
internal class ProfileScreen : MenuScreen
{
    public ProfileScreen() : base("Profile Screen")
    {
        Add("View Details", new DetailsScreen());
        Add("Update Details", new UpdateScreen());
    }
    
}
