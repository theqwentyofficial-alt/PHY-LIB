namespace PHY_LIB.API.SteamAPI.ISteamUser
{
    public interface IFriendsList
    {
        public Friend[] friends { get; set; }
    }
    public interface IFriend
    {
        public string steamid { get; set; }
        public string relationship { get; set; }
        public long friend_since { get; set; }
    }
    public class FriendsList : IFriendsList
    {
      public Friend[] friends { get; set; }
    }
    public class Friend : IFriend
    {
        public string steamid { get; set; }
        public string relationship { get; set; }
        public long friend_since { get; set; }
    }
}
