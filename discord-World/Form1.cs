using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static Guna.UI2.Native.WinApi;
using SelfBot_Framework.Startup;
using DSharpPlus;
using DSharpPlus.Entities;
using System.IO;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Remoting.Contexts;
using Newtonsoft.Json.Linq;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using Discord;
using System.Threading.Channels;
using discord_World.Properties;
using System.Timers;
using System.Reflection;

namespace discord_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://Discord.com/"); //didnt add my discord if you want it its anthemia
        }
        private void guna2HtmlLabel1_Hover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator2_Click(object sender, EventArgs e)
        {

        }

        System.Random random = new Random();
        string[] monke = { "brazil", "hongkong", "india", "japan", "rotterdam", "russia", "singapore", "south-korea", "southafrica", "sydney", "us-central", "us-east", "us-south", "us-west" };
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string pathToExecutable = "ChangeRegion.exe";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = pathToExecutable;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = $"{Startup.token} {settings.GetGroupID()}";
            Process.Start(startInfo);
        }


        public static SettingsTab settings = new SettingsTab(1224523985614671924, "");
        public string username;
       

            private void Form1_Load(object sender, EventArgs e)
        {
            guna2Panel3.Location = new System.Drawing.Point(404, 89);
            this.guna2Panel1.Location = new System.Drawing.Point(14, 89);
            this.guna2Panel4.Location = new System.Drawing.Point(10000, 10000);
            if (File.Exists("GroupID"))
            {
                settings.LoadSettings();
            }
            else
            {
                File.WriteAllText("GroupID", "1");
                settings.LoadSettings();
            }
            if (Startup._discordClient != null)
            {
                var currentUser = Startup._discordClient.CurrentUser;
                if (currentUser != null)
                {
                    username = Startup._discordClient.CurrentUser.Username;
                }
                else
                {
                    Console.WriteLine("Current user is null.");
                }
            }
            else
            {
                Console.WriteLine("Discord client is not initialized.");
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ulong channelId = settings.GetGroupID();
            string filePath = @"fun.txt";

            Task task = SendFileWithMessageAsync(channelId, "LOOK AT THIS", filePath);
        }
        public async Task SendFileWithMessageAsync(ulong channelId, string messageContent, string filePath, int delaySeconds = 5)
        {
            var channel = await SelfBot_Framework.Startup.Startup._discordClient.GetChannelAsync(channelId) as DSharpPlus.Entities.DiscordChannel;
            if (channel != null)
            {
                using (var fileStream = File.OpenRead(filePath))
                {
                    var fileMessage = await channel.SendFileAsync(fileStream, Path.GetFileName(filePath), messageContent);
                }
                await Task.Delay(TimeSpan.FromSeconds(delaySeconds));
                var messages = await channel.GetMessagesAsync();
                var messageWithFile = messages.FirstOrDefault(m => m.Content == messageContent);

                if (messageWithFile != null)
                {
                    await messageWithFile.DeleteAsync();
                }
                else
                {
                    Console.WriteLine("Message containing the file not found.");
                }
            }
            else
            {
                Console.WriteLine("Channel not found.");
            }
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //info tab shit
            label4.Text = "Username: " + username;
            label5.Text = "Group ID: " + settings.GetGroupID();
        }
        static string GroupName;
        public static async Task getGroupSHIt()
        {
            ulong channelId = settings.GetGroupID();
            var channel = await SelfBot_Framework.Startup.Startup._discordClient.GetChannelAsync(channelId) as DSharpPlus.Entities.DiscordChannel;
            if (channel != null)
            {
                GroupName = channel.Name;
            }
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2CirclePictureBox4_Hover(object sender, EventArgs e)
        {

        }
        public static Color FromArgb(byte red, byte green, byte blue)
        {
            return Color.FromArgb(255, red, green, blue);
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                timer2.Start();
            }
            else
            {
                timer2.Stop();
            }
        }
        public void RunTHeShit()
        {
            string pathToExecutable = "ChangeRegion.exe";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = pathToExecutable;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = $"{Startup.token} {settings.GetGroupID()}";
            Process.Start(startInfo);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Task.Run(RunTHeShit);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel3.Location = new System.Drawing.Point(10000, 10000);
            this.guna2Panel1.Location = new System.Drawing.Point(10000, 10000);
            this.guna2Panel4.Location = new System.Drawing.Point(15, 89);
        }
        //buttons for tabs, no othere tabs set up. only settings and main

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel3.Location = new System.Drawing.Point(404, 89);
            this.guna2Panel1.Location = new System.Drawing.Point(14, 89);
            this.guna2Panel4.Location = new System.Drawing.Point(10000, 10000);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ulong result;
            ulong.TryParse(this.guna2TextBox1.Text, out result);
                settings.SetGroupID(result);
            settings.SaveSettings();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            settings.SetToken(this.guna2TextBox2.Text);
            settings.SaveSettings();
        }
    }
}
