using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discord_World
{
    public class SettingsTab
    {
        private ulong GroupID;
        private string token;
        public SettingsTab(ulong groupID, string Token)
        {
            GroupID = groupID;
            token = Token;

        }
        public void SetGroupID(ulong groupID)
        {
            GroupID = groupID;
        }
        public void SetToken(string Token)
        {
            token = Token;
        }
        public ulong GetGroupID()
        {
            return GroupID;
        }
        public string GetToken()
        {
            return token;
        }
        public void SaveSettings()
        {
            File.WriteAllText("token",token);
            File.WriteAllText("GroupID", "" + GroupID);
        }
        public void LoadSettings()
        {
            token = File.ReadAllText("token");
            string group = File.ReadAllText("GroupID");
            GroupID = ulong.Parse(group);
        }
    }
}
