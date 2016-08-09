using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Lunchbox
{
    internal class LunchCtrl
    {
        private Setting _setting;
        private MainForm _form;

        public LunchCtrl(Setting setting, MainForm form)
        {
            _setting = setting;
            _form = form;
        }

        public void lunch(List<Lunch> lunches)
        {
            _form.timerGetImage.Stop();

            if (lunches.Count == 0)
            {
                return;
            }

            if (_form.Visible == false)
            {
                foreach (Lunch lunch in lunches)
                {
                    if (lunch.path != "")
                    {
                        try
                        {
                            bool res = this.runScript(lunch.path);
                            if (res)
                            {
                                _setting.level++;
                                this.showLevelUpMessage();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + lunch.path);
                        }
                    }
                }

                System.Threading.Thread.Sleep(_setting.tileDelayMs);

                this.tile(lunches);

                this.afterLunch();
            }
        }

        private bool runScript(string cmdLine)
        {
            string exe = "";
            string arg = "";

            cmdLine = cmdLine.Trim();
            if (cmdLine == "")
            {
                return false;
            }

            if (cmdLine.StartsWith("\""))
            {
                int dqPos = cmdLine.IndexOf("\"", 1);
                exe = cmdLine.Substring(0, dqPos + 1);
                if (cmdLine.Length > dqPos + 1)
                {
                    arg = cmdLine.Substring(dqPos + 2);
                }
            }
            else
            {
                int slashPos = cmdLine.IndexOf(" ");
                if (slashPos > 0)
                {
                    exe = cmdLine.Substring(0, slashPos);
                    if (cmdLine.Length > slashPos)
                    {
                        arg = cmdLine.Substring(slashPos + 1);
                    }
                }
                else
                {
                    exe = cmdLine;
                }
            }

            if (arg == "")
            {
                System.Diagnostics.Process.Start(exe);
            }
            else
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = exe;
                p.StartInfo.Arguments = arg;
                //p.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                //p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
                //p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                //p.StartInfo.RedirectStandardInput = false;
                //p.StartInfo.RedirectStandardOutput = true;
                //p.StartInfo.RedirectStandardError = true;

                p.Start();
                p.WaitForExit();
            }

            return true;
        }

        private void showLevelUpMessage()
        {
            switch (_setting.level)
            {
                case 10:
                    MessageBox.Show(Lunchbox.Properties.Resources.Level10.Replace(@"\n", "\n"));
                    _setting.save();
                    break;

                case 20:
                    MessageBox.Show(Lunchbox.Properties.Resources.Level20.Replace(@"\n", "\n"));
                    _setting.save();
                    break;

                default:
                    break;
            }
        }

        private void tile(List<Lunch> lunches)
        {
            int width = _setting.tileRect.Width;
            int height = _setting.tileRect.Height;

            int rowNum = Screen.PrimaryScreen.WorkingArea.Height / height;
            int colNum = Screen.PrimaryScreen.WorkingArea.Width / width;

            if (rowNum == 0 || colNum == 0)
            {
                return;
            }

            int topLeftCount = 0;
            int topRightCount = 0;
            int bottomLeftCount = 0;
            int bottomRightCount = 0;

            foreach (Lunch lunch in lunches)
            {
                if (lunch.path != "")
                {
                    //
                    if (lunch.dirOrFile == Lunch.DirOrFile.Folder)
                    {
                        string dirName = "";
                        string trimDq = "";

                        if (lunch.path.StartsWith("\""))
                        {
                            int dqPos = lunch.path.IndexOf("\"", 1);
                            trimDq = lunch.path.Substring(1, dqPos - 1);
                        }
                        else
                        {
                            trimDq = lunch.path;
                        }

                        try
                        {
                            // ネットワーク上のフォルダか？
                            if (trimDq.StartsWith("\\\\"))
                            {
                                System.IO.FileInfo fi = new System.IO.FileInfo(trimDq);
                                dirName = fi.Name;
                            }
                            // ドライブのルートか？
                            else if (trimDq == System.IO.Path.GetPathRoot(trimDq))
                            {
                                dirName = trimDq;
                            }
                            else
                            {
                                System.IO.FileInfo fi = new System.IO.FileInfo(trimDq);
                                dirName = fi.Name;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        if (dirName != "")
                        {
                            switch (lunch.pos)
                            {
                                case Lunch.Pos.TopLeft:
                                    {
                                        IList<IntPtr> hWndList = findWindows("CabinetWClass", dirName);
                                        if (hWndList != null)
                                        {
                                            foreach (IntPtr hWnd in hWndList)
                                            {
                                                if (hWnd != IntPtr.Zero)
                                                {
                                                    int offsetY = (topLeftCount % rowNum) * height;
                                                    int offsetX = (topLeftCount / rowNum) * width;

                                                    Rectangle dstRect = new Rectangle(offsetX, offsetY, width, height);

                                                    this.moveWindow(hWnd, dstRect);

                                                    if (topLeftCount / rowNum < colNum - 1)
                                                    {
                                                        topLeftCount++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;

                                case Lunch.Pos.TopRight:
                                    {
                                        IList<IntPtr> hWndList = findWindows("CabinetWClass", dirName);
                                        if (hWndList != null)
                                        {
                                            foreach (IntPtr hWnd in hWndList)
                                            {
                                                if (hWnd != IntPtr.Zero)
                                                {
                                                    int offsetY = (topRightCount % rowNum) * height;
                                                    int offsetX = (topRightCount / rowNum) * width;

                                                    Rectangle dstRect = new Rectangle(Screen.PrimaryScreen.WorkingArea.Width - width - offsetX, offsetY, width, height);

                                                    this.moveWindow(hWnd, dstRect);

                                                    if (topRightCount / rowNum < colNum - 1)
                                                    {
                                                        topRightCount++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;

                                case Lunch.Pos.BottomLeft:
                                    {
                                        IList<IntPtr> hWndList = findWindows("CabinetWClass", dirName);
                                        if (hWndList != null)
                                        {
                                            foreach (IntPtr hWnd in hWndList)
                                            {
                                                if (hWnd != IntPtr.Zero)
                                                {
                                                    int offsetY = (bottomLeftCount % rowNum) * height;
                                                    int offsetX = (bottomLeftCount / rowNum) * width;

                                                    Rectangle dstRect = new Rectangle(offsetX, Screen.PrimaryScreen.WorkingArea.Height - height - offsetY, width, height);

                                                    this.moveWindow(hWnd, dstRect);

                                                    if (bottomLeftCount / rowNum < colNum - 1)
                                                    {
                                                        bottomLeftCount++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;

                                case Lunch.Pos.BottomRight:
                                    {
                                        IList<IntPtr> hWndList = findWindows("CabinetWClass", dirName);
                                        if (hWndList != null)
                                        {
                                            foreach (IntPtr hWnd in hWndList)
                                            {
                                                if (hWnd != IntPtr.Zero)
                                                {
                                                    int offsetY = (bottomRightCount % rowNum) * height;
                                                    int offsetX = (bottomRightCount / rowNum) * width;

                                                    Rectangle dstRect = new Rectangle(Screen.PrimaryScreen.WorkingArea.Width - width - offsetX, Screen.PrimaryScreen.WorkingArea.Height - height - offsetY, width, height);

                                                    this.moveWindow(hWnd, dstRect);

                                                    if (bottomRightCount / rowNum < colNum - 1)
                                                    {
                                                        bottomRightCount++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetWindow(IntPtr hWnd, GetWindow_Cmd uCmd);

        enum GetWindow_Cmd : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public List<IntPtr> findWindows(string className, string title)
        {
            if (className == "" && title == "")
            {
                return null;
            }

            List<IntPtr> hWndList = new List<IntPtr>();

            IntPtr hWnd = GetForegroundWindow();
            while (hWnd != IntPtr.Zero)
            {
                bool match = false;

                if (className == "")
                {
                    match = true;
                }
                else
                {
                    StringBuilder sb = new StringBuilder(512);
                    if (GetClassName(hWnd, sb, 512) > 0)
                    {
                        if (className == sb.ToString())
                        {
                            match = true;
                        }
                    }
                }

                if (match == true)
                {
                    match = false;

                    if (title == "")
                    {
                        match = true;
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder(512);
                        if (GetWindowText(hWnd, sb, 512) > 0)
                        {
                            // ドライブのルート
                            if (title.IndexOf(":\\") >= 0)
                            {
                                // 
                                string drive = title.TrimEnd('\\');
                                if (sb.ToString().EndsWith(" (" + drive + ")"))
                                {
                                    match = true;
                                }
                            }
                            else
                            {
                                // ローカルのフォルダ
                                if (title == sb.ToString())
                                {
                                    match = true;
                                }
                                else
                                {
                                    // ネットワーク上のフォルダ
                                    if (sb.ToString().StartsWith(title + " - "))
                                    {
                                        match = true;
                                    }
                                }
                            }
                        }
                    }
                }

                if (match == true)
                {
                    hWndList.Add(hWnd);
                }

                hWnd = GetWindow(hWnd, GetWindow_Cmd.GW_HWNDNEXT);
            }

            return hWndList;
        }

        public void moveWindow(IntPtr hWnd, Rectangle rect)
        {
            if (hWnd != IntPtr.Zero)
            {
                MoveWindow(hWnd, rect.X, rect.Y, rect.Width, rect.Height, true);
            }
        }

        private void afterLunch()
        {
            if (_setting.autoOff)
            {
                if ((_setting.lastMessageOn)
                    && (_setting.lastMessage != ""))
                {
                    _form.notifyIconTaskTray.BalloonTipText = _setting.lastMessage;
                    _form.notifyIconTaskTray.ShowBalloonTip(3000);
                }

                if ((_setting.lastSoundOn)
                    && (_setting.lastSoundPath != ""))
                {
                    try
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(_setting.lastSoundPath);
                        player.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                _form.timerAutoOff.Start();
            }
        }
    }
}
