
namespace PHY_LIB.API.SteamAPI.ISteamUser
{
    public interface ISteamUser
    {
        public UserData response { get; set; }
        public FriendsList friendslist { get; set; }
    }
    public interface IUserData
    {
        public List<Data> players { get; set; }
    }
    public interface IData
    {
        public string steamid { get; set; }
        public int communityvisibilitystate { get; set; }
        public int profilestate { get; set; }
        public string personaname { get; set; }
        public string profileurl { get; set; }
        public string avatar { get; set; }
        public string avatarmedium { get; set; }
        public string avatarfull { get; set; }
        public string avatarhash { get; set; }
        public long lastlogoff { get; set; }
        public int personastate { get; set; }
        public string primaryclanid { get; set; }
        public long timecreated { get; set; }
        public int personastateflags { get; set; }
        public string loccountrycode { get; set; }
    }
    public class SteamUser : ISteamUser
    {
        public virtual UserData response { get; set; }
        public virtual UserBanData[] players { get; set; }
        public virtual FriendsList friendslist { get; set; }
    }
    public class UserBanData
    {
        public string SteamId { get; set; }
        public bool CommunityBanned { get; set; }
        public bool VACBanned { get; set; }
        public int NumberOfVACBans { get; set; }
        public long DaysSinceLastBan { get; set; }
        public int NumberOfGameBans { get; set; }
        public string EconomyBan { get; set; }
    }
    public class UserData : IUserData
    {
       public virtual List<Data> players { get; set; }
    }
    public class Data : IData
    {
        public virtual string steamid { get; set; }
        public virtual int communityvisibilitystate { get; set; }
        public virtual int profilestate { get; set; }
        public virtual string personaname { get; set; }
        public virtual string profileurl { get; set; }
        public virtual string avatar { get; set; }
        public virtual string avatarmedium { get; set; }
        public virtual string avatarfull { get; set; }
        public virtual string avatarhash { get; set; }
        public virtual long lastlogoff { get; set; }
        public virtual int personastate { get; set; }
        public virtual string primaryclanid { get; set; }
        public virtual long timecreated { get; set; }
        public virtual int personastateflags { get; set; }
        public virtual string loccountrycode { get; set; }
        public virtual int success { get; set; }
    }
}
