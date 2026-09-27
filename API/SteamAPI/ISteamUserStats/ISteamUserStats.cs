using System;
using System.Collections.Generic;
using System.Text;

namespace PHY_LIB.API.SteamAPI.ISteamUserStats
{
    public interface IUserStats
    {
        public string steamID { get; set; }
        public string gameName { get; set; }
        public Achievements[] achievements { get; set; }
        public bool success { get; set; }
    }
    public interface IAchievements
    {
        public string apiname { get; set; }
        public int achieved { get; set; }
        public int unlocktime { get; set; }
    }
    public class UserStats : IUserStats
    {
        public string steamID { get; set; }
        public string gameName { get; set; }
        public GameStats[] stats { get; set; }
        public Achievements[] achievements { get; set; }
        public bool success { get; set; }
    }
        public class GameStats
    {
        public string name { get; set; }
        public int value { get; set; }
    }
    public class Achievements : IAchievements
    {
        public string apiname { get; set; }
        public int achieved { get; set; }
        public int unlocktime { get; set; }
    }
}
