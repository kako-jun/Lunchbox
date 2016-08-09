using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Lunchbox
{
    public class Setting
    {
        public enum Timing
        {
            Desktop,
            Dropbox,
        };

        public List<Lunch> lunches { get; set; }
        public Timing timing { get; set; }
        public int moratoriumDelayMs { get; set; }
        public int moratoriumMs { get; set; }
        public Rectangle iconRect { get; set; }
        public int getImageIntervalMs { get; set; }
        public bool startUp { get; set; }
        public bool autoOff { get; set; }
        public bool lastMessageOn { get; set; }
        public string lastMessage { get; set; }
        public bool lastSoundOn { get; set; }
        public string lastSoundPath { get; set; }
        public Rectangle tileRect { get; set; }
        public int tileDelayMs { get; set; }
        public int level { get; set; }

        public Setting()
        {
            lunches = new List<Lunch>();
            timing = Timing.Desktop;
            moratoriumDelayMs = 30000;
            moratoriumMs = 10000;
            iconRect = new Rectangle(Screen.PrimaryScreen.Bounds.Width - 400, Screen.PrimaryScreen.Bounds.Height - 70, 400, 70);
            getImageIntervalMs = 3000;
            startUp = false;
            autoOff = true;
            lastMessageOn = true;
            lastMessage = "";
            lastSoundOn = false;
            lastSoundPath = "";
            tileRect = new Rectangle(0, 0, 300, 350);
            tileDelayMs = 3000;
            level = 0;
        }

        private static string file_name = "lunchbox_setting_" + Lunchbox.Properties.Resources.Lang + ".xml";

        public bool save()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\" + file_name;

            XmlSerializer serializer = new XmlSerializer(typeof(Setting));
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                serializer.Serialize(fs, this);
                fs.Close();

                // たまにファイル末尾が化けることがあるため
                string text = File.ReadAllText(path, Encoding.GetEncoding("utf-8"));
                int find = text.IndexOf("</Setting>");
                text = text.Substring(0, find);
                text += "</Setting>";

                File.WriteAllText(path, text, Encoding.GetEncoding("utf-8"));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool load()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\" + file_name;
            Setting tempSetting = new Setting();

            XmlSerializer serializer = new XmlSerializer(typeof(Setting));
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                tempSetting = (Setting)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception)
            {
                return false;
            }

            this.lunches = tempSetting.lunches;
            this.timing = tempSetting.timing;
            this.moratoriumDelayMs = tempSetting.moratoriumDelayMs;
            this.moratoriumMs = tempSetting.moratoriumMs;
            this.iconRect = tempSetting.iconRect;
            this.getImageIntervalMs = tempSetting.getImageIntervalMs;
            this.startUp = tempSetting.startUp;
            this.autoOff = tempSetting.autoOff;
            this.lastMessageOn = tempSetting.lastMessageOn;
            this.lastMessage = tempSetting.lastMessage;
            this.lastSoundOn = tempSetting.lastSoundOn;
            this.lastSoundPath = tempSetting.lastSoundPath;
            this.tileRect = tempSetting.tileRect;
            this.tileDelayMs = tempSetting.tileDelayMs;
            this.level = tempSetting.level;

            return true;
        }
    }
}
