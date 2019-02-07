using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discord_archiver_viewer
{
    public class User
    {
        public int userId { get; }
        public string username { get; }
        public ushort discriminator { get; }
        public long id { get; }
        public string avatar { get; }
        public string avatar_url { get; }
        
        public User(int UserId,string Username,ushort Discriminator,long Id,string Avatar)
        {
            userId = UserId;
            username = Username;
            discriminator = Discriminator;
            id = Id;
            avatar = Avatar;

            avatar_url = @"https://cdn.discordapp.com/avatars/" + Id.ToString() + "/" + Avatar + ".jpg";
            //avatar_url = (avatar_url == null || avatar_url == String.Empty) ? avatar_url = @"https://cdn.discordapp.com/avatars/" + Id.ToString() + "/" + Avatar + ".jpg" : @"https://discordapp.com/assets/dd4dbc0016779df1378e7812eabaa04d.png" ;

        }
    }
}
