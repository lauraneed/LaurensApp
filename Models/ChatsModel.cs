using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaurensApp1.Models
{
  
 
    public class ChatsModel
    {
        public string Avatar { get; set; }
        public string Name { get; set; }
        public int DateTime  { get; set; }

        public int UnreadCount { get; set; }
        


        public ChatsModel(string avatar, string name, DateTime, int unreadCount)
        {
            Name = name;
            Avatar = avatar;
            DateTime = DateTime;
            UnreadCount = unreadCount;
        }

    }

}
