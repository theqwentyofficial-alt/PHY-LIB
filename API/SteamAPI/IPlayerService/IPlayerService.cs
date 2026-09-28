namespace PHY_LIB.API.SteamAPI.IPlayerService
{
   public interface IPlayerService
    {
        LibData response { get; set; }
    }
    public interface ILibData
    {
        int game_count { get; set; }

        int player_level { get; set; }

        List<GameData> games { get; set; }
    }
    public interface IGameData
    {
       public int appid { get; set; }
       public string name { get; set; }
       public int playtime_forever { get; set; }
       public int playtime_2weeks { get; set; }
       int lastTimePlayed { get; set; }
       public DateTime LastTimePlayed { get; set; }
        public int rtime_last_played
        {
            get
            {
                return lastTimePlayed;
            }
            set
            {
                DateTime date = IO.UnixToDateTime.UnixSecondsToDateTime(value);
                LastTimePlayed = date;
            }
        }
    }
    public class ProfileLibrary : IPlayerService
    {
        public virtual LibData response { get; set; }
    }
    public class LibData : ILibData
    {
        public virtual int game_count { get; set; }

        public virtual int player_level { get; set; }

        public virtual List<GameData> games { get; set; } = new List<GameData>();
    }
    public class GameData : IGameData
    {
        public virtual int appid { get; set; }
        public virtual string name { get; set; }
        public virtual int playtime_forever { get; set; }
        public virtual int playtime_2weeks { get; set; }
        public int lastTimePlayed { get; set; }
        public virtual DateTime LastTimePlayed { get; set; }
        public virtual int rtime_last_played
        {
            get 
            { 
                return lastTimePlayed;
            }
            set
            {
                lastTimePlayed = value;
                DateTime date = IO.UnixToDateTime.UnixSecondsToDateTime(value);
                LastTimePlayed = date;
            }
        }
    }
}
