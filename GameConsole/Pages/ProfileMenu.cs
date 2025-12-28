using System;
using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
namespace GameConsole.Pages;
internal class ProfileMenu : MenuScreen
{
    public ProfileMenu() : base("Profile Screen")
    {
        Add("View Details", new DetailsScreen());
        Add("Update Details", new UpdateScreen());
    }
}