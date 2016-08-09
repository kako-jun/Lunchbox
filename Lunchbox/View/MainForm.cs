using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunchbox
{
    public partial class MainForm : Form
    {
        private Setting _setting;

        private Image _prevImage;
        private bool _moratoriumDelayEnd;
        private int _totalMoratoriumMs;
        private bool _okClicked;

        private LunchCtrl _lunchCtrl;
        private ImageCtrl _imageCtrl;
        private GridCtrl _gridCtrl;

        public MainForm()
        {
            _setting = new Setting();
            _setting.load();

            _prevImage = null;
            _moratoriumDelayEnd = false;
            _totalMoratoriumMs = 0;
            _okClicked = true;

            _lunchCtrl = new LunchCtrl(_setting, this);
            _imageCtrl = new ImageCtrl(_setting, this);
            _gridCtrl = null;

            InitializeComponent();

            // 
            timerOnStart.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _gridCtrl = new GridCtrl(_setting, this, dataGridViewLunch, buttonAdd, buttonUp, buttonDown);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void timerOnStart_Tick(object sender, EventArgs e)
        {
            timerOnStart.Stop();

            if (_setting.timing == Setting.Timing.Desktop)
            {
                _moratoriumDelayEnd = true;
            }
            else
            {
                if (_setting.moratoriumDelayMs > 0)
                {
                    timerMoratoriumDelay.Interval = _setting.moratoriumDelayMs;
                    timerMoratoriumDelay.Start();
                }
            }

            timerGetImage.Interval = _setting.getImageIntervalMs + 100;
            timerGetImage.Start();
        }

        private void timerMoratoriumDelay_Tick(object sender, EventArgs e)
        {
            timerMoratoriumDelay.Stop();
            _moratoriumDelayEnd = true;
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                if (this.Visible == true)
                {
                    this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                    this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

                    // 
                    radioButtonAppMenu.Checked = true;

                    // 
                    _gridCtrl.initControls();

                    if (_setting.timing == Setting.Timing.Desktop)
                    {
                        radioButtonDesktop.Checked = true;
                    }
                    else
                    {
                        radioButtonDropbox.Checked = true;
                    }

                    if (_setting.moratoriumDelayMs >= 1000)
                    {
                        numericUpDownMoratoriumMs1.Value = _setting.moratoriumDelayMs / 1000;
                    }
                    else
                    {
                        numericUpDownMoratoriumMs1.Value = 1;
                    }

                    if (_setting.moratoriumMs >= 1000)
                    {
                        numericUpDownMoratoriumMs2.Value = _setting.moratoriumMs / 1000;
                    }
                    else
                    {
                        numericUpDownMoratoriumMs2.Value = 1;
                    }

                    numericUpDownIconX.Maximum = Screen.PrimaryScreen.Bounds.Width;
                    numericUpDownIconY.Maximum = Screen.PrimaryScreen.Bounds.Height;
                    numericUpDownIconWidth.Maximum = Screen.PrimaryScreen.Bounds.Width;
                    numericUpDownIconHeight.Maximum = Screen.PrimaryScreen.Bounds.Height;

                    if (_setting.iconRect.X > numericUpDownIconX.Maximum)
                    {
                        numericUpDownIconX.Value = numericUpDownIconX.Maximum;
                    }
                    else if (_setting.iconRect.X < numericUpDownIconX.Minimum)
                    {
                        numericUpDownIconX.Value = numericUpDownIconX.Minimum;
                    }
                    else
                    {
                        numericUpDownIconX.Value = _setting.iconRect.X;
                    }

                    if (_setting.iconRect.Y > numericUpDownIconY.Maximum)
                    {
                        numericUpDownIconY.Value = numericUpDownIconY.Maximum;
                    }
                    else if (_setting.iconRect.Y < numericUpDownIconY.Minimum)
                    {
                        numericUpDownIconY.Value = numericUpDownIconY.Minimum;
                    }
                    else
                    {
                        numericUpDownIconY.Value = _setting.iconRect.Y;
                    }

                    if (_setting.iconRect.Width > numericUpDownIconWidth.Maximum)
                    {
                        numericUpDownIconWidth.Value = numericUpDownIconWidth.Maximum;
                    }
                    else if (_setting.iconRect.Width < numericUpDownIconWidth.Minimum)
                    {
                        numericUpDownIconWidth.Value = numericUpDownIconWidth.Minimum;
                    }
                    else
                    {
                        numericUpDownIconWidth.Value = _setting.iconRect.Width;
                    }

                    if (_setting.iconRect.Height > numericUpDownIconHeight.Maximum)
                    {
                        numericUpDownIconHeight.Value = numericUpDownIconHeight.Maximum;
                    }
                    else if (_setting.iconRect.Height < numericUpDownIconHeight.Minimum)
                    {
                        numericUpDownIconHeight.Value = numericUpDownIconHeight.Minimum;
                    }
                    else
                    {
                        numericUpDownIconHeight.Value = _setting.iconRect.Height;
                    }

                    if (_setting.getImageIntervalMs >= 1000)
                    {
                        numericUpDownPreview.Value = _setting.getImageIntervalMs / 1000;
                    }
                    else
                    {
                        numericUpDownPreview.Value = 1;
                    }

                    checkBoxStartUp.Checked = _setting.startUp;
                    checkBoxAutoOff.Checked = _setting.autoOff;
                    checkBoxLastMessage.Checked = _setting.lastMessageOn;
                    textBoxLastMessage.Text = _setting.lastMessage;
                    checkBoxLastSound.Checked = _setting.lastSoundOn;
                    textBoxLastSound.Text = _setting.lastSoundPath;

                    numericUpDownTileWidth.Maximum = Screen.PrimaryScreen.WorkingArea.Width;
                    numericUpDownTileHeight.Maximum = Screen.PrimaryScreen.WorkingArea.Height;

                    if (_setting.tileRect.Width > numericUpDownTileWidth.Maximum)
                    {
                        numericUpDownTileWidth.Value = numericUpDownTileWidth.Maximum;
                    }
                    else if (_setting.tileRect.Width < numericUpDownTileWidth.Minimum)
                    {
                        numericUpDownTileWidth.Value = numericUpDownTileWidth.Minimum;
                    }
                    else
                    {
                        numericUpDownTileWidth.Value = _setting.tileRect.Width;
                    }

                    if (_setting.tileRect.Height > numericUpDownTileHeight.Maximum)
                    {
                        numericUpDownTileHeight.Value = numericUpDownTileHeight.Maximum;
                    }
                    else if (_setting.tileRect.Height < numericUpDownTileHeight.Minimum)
                    {
                        numericUpDownTileHeight.Value = numericUpDownTileHeight.Minimum;
                    }
                    else
                    {
                        numericUpDownTileHeight.Value = _setting.tileRect.Height;
                    }

                    if (_setting.tileDelayMs >= 1000)
                    {
                        numericUpDownTileDelayMs.Value = _setting.tileDelayMs / 1000;
                    }
                    else
                    {
                        numericUpDownTileDelayMs.Value = 1;
                    }

                    this.updateControls();
                }
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timerOnStart.Enabled == false)
            {
                if (this.Visible)
                {
                    this.Activate();
                }
                else
                {
                    timerGetImage.Interval = _setting.getImageIntervalMs + 100;
                    timerGetImage.Start();
                    this.Show();
                }
            }
        }

        private void notifyIconTaskTray_DoubleClick(object sender, EventArgs e)
        {
            this.settingToolStripMenuItem_Click(null, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIconTaskTray.Visible = false;

            if (_setting != null)
            {
                _setting.save();
            }

            Application.Exit();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _okClicked = true;

            _totalMoratoriumMs = 0;

            _setting.lunches = new List<Lunch>(_gridCtrl.lunches);
            _setting.timing = radioButtonDesktop.Checked ? Setting.Timing.Desktop : Setting.Timing.Dropbox;
            _setting.moratoriumDelayMs = (int)numericUpDownMoratoriumMs1.Value * 1000;
            _setting.moratoriumMs = (int)numericUpDownMoratoriumMs2.Value * 1000;
            _setting.iconRect = new Rectangle((int)numericUpDownIconX.Value, (int)numericUpDownIconY.Value, (int)numericUpDownIconWidth.Value, (int)numericUpDownIconHeight.Value);
            _setting.getImageIntervalMs = (int)numericUpDownPreview.Value * 1000;

            this.registStartUp(checkBoxStartUp.Checked);

            _setting.startUp = checkBoxStartUp.Checked;
            _setting.autoOff = checkBoxAutoOff.Checked;
            _setting.lastMessageOn = checkBoxLastMessage.Checked;
            _setting.lastMessage = textBoxLastMessage.Text;
            _setting.lastSoundOn = checkBoxLastSound.Checked;
            _setting.lastSoundPath = textBoxLastSound.Text;

            _setting.tileRect = new Rectangle(0, 0, (int)numericUpDownTileWidth.Value, (int)numericUpDownTileHeight.Value);
            _setting.tileDelayMs = (int)numericUpDownTileDelayMs.Value * 1000;

            _setting.save();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _okClicked = false;

            _totalMoratoriumMs = 0;

            _setting = new Setting();
            if (_setting.load())
            {
                _gridCtrl.lunches = new BindingList<Lunch>(_setting.lunches);
            }

            this.updateControls();
            this.Hide();
        }

        private void timerGetImage_Tick(object sender, EventArgs e)
        {
            if (notifyIconTaskTray == null)
            {
                return;
            }

            if (this.Visible)
            {
                if (radioButtonTimingMenu.Checked && radioButtonDropbox.Checked)
                {
                    Bitmap taskTrayImage = null;
                    taskTrayImage = _imageCtrl.getTaskTrayImage((int)numericUpDownIconX.Value, (int)numericUpDownIconY.Value, (int)numericUpDownIconWidth.Value, (int)numericUpDownIconHeight.Value);

                    if (taskTrayImage != null)
                    {
                        pictureBoxPreview.Image = taskTrayImage;
                    }

                    if (_prevImage != null)
                    {
                        if (_imageCtrl.compareImage(taskTrayImage, _prevImage))
                        {
                            labelPreview3.Text = Lunchbox.Properties.Resources.Stopping;
                        }
                        else
                        {
                            labelPreview3.Text = Lunchbox.Properties.Resources.Moving;
                        }
                    }

                    _prevImage = taskTrayImage;

                    // 
                    if (numericUpDownIconWidth.Value <= 450)
                    {
                        pictureBoxPreview.Width = (int)numericUpDownIconWidth.Value;
                    }

                    if (numericUpDownIconHeight.Value <= 80)
                    {
                        pictureBoxPreview.Height = (int)numericUpDownIconHeight.Value;
                    }
                }
            }
            else
            {
                if (_okClicked)
                {
                    // 
                    if (_setting.timing == Setting.Timing.Desktop)
                    {
                        _okClicked = false;
                        _lunchCtrl.lunch(_setting.lunches);
                    }
                    else
                    {
                        if (_moratoriumDelayEnd == true)
                        {
                            Bitmap taskTrayImage = null;
                            taskTrayImage = _imageCtrl.getTaskTrayImage(_setting.iconRect.X, _setting.iconRect.Y, _setting.iconRect.Width, _setting.iconRect.Height);

                            if (_prevImage != null)
                            {
                                if (_imageCtrl.compareImage(taskTrayImage, _prevImage))
                                {
                                    _totalMoratoriumMs += timerGetImage.Interval;
                                }
                                else
                                {
                                    _totalMoratoriumMs = 0;
                                }
                            }

                            _prevImage = taskTrayImage;

                            if (_totalMoratoriumMs > _setting.moratoriumMs)
                            {
                                _okClicked = false;
                                _totalMoratoriumMs = 0;
                                _lunchCtrl.lunch(_setting.lunches);
                            }
                        }
                    }
                }
            }
        }

        private void radioButtonAppMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAppMenu.Checked)
            {
                this.updateControls();
            }
        }

        private void radioButtonTimingMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTimingMenu.Checked)
            {
                this.updateControls();
            }
        }

        private void radioButtonEtcMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEtcMenu.Checked)
            {
                this.updateControls();
            }
        }

        private void radioButtonDesktop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDesktop.Checked)
            {
                this.updateControls();
            }
        }

        private void radioButtonDropbox_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDropbox.Checked)
            {
                this.updateControls();
            }
        }

        private void buttonIconRectReset_Click(object sender, EventArgs e)
        {
            numericUpDownIconX.Value = Screen.PrimaryScreen.Bounds.Width - 400;
            numericUpDownIconY.Value = Screen.PrimaryScreen.Bounds.Height - 70;
            numericUpDownIconWidth.Value = 400;
            numericUpDownIconHeight.Value = 70;
        }

        private void checkBoxAutoOff_CheckedChanged(object sender, EventArgs e)
        {
            this.updateControls();
        }

        private void checkBoxLastMessage_CheckedChanged(object sender, EventArgs e)
        {
            this.updateControls();
        }

        private void checkBoxLastSound_CheckedChanged(object sender, EventArgs e)
        {
            this.updateControls();
        }

        private void buttonLastSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "WAVE files (*.wav)|*.wav";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                textBoxLastSound.Text = dlg.FileName;
            }
        }

        private void linkLabelUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://jpico.info");
        }

        private void timerAutoOff_Tick(object sender, EventArgs e)
        {
            timerAutoOff.Stop();

            if (_setting.autoOff)
            {
                if (this.Visible == false)
                {
                    notifyIconTaskTray.Visible = false;

                    if (_setting != null)
                    {
                        _setting.save();
                    }

                    Application.Exit();
                }
            }
        }

        private void registStartUp(bool enable)
        {
            // レジストリを開く.
            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

            if (enable)
            {
                // 値に製品名、実行ファイルのパスを書き込む.
                regkey.SetValue(Application.ProductName, Application.ExecutablePath);
            }
            else
            {
                if (regkey.GetValue(Application.ProductName) != null)
                {
                    // 値を削除する.
                    regkey.DeleteValue(Application.ProductName);
                }
            }

            // レジストリを閉じる.
            regkey.Close();
        }

        private void updateControls()
        {
            if (radioButtonAppMenu.Checked == true)
            {
                tabControlMenu.SelectedTab = tabPageAppMenu;

                _gridCtrl.updateControls();
            }

            if (radioButtonTimingMenu.Checked == true)
            {
                tabControlMenu.SelectedTab = tabPageTimingMenu;

                if (_setting.level >= 10)
                {
                    radioButtonDropbox.Show();
                }
                else
                {
                    radioButtonDesktop.Checked = true;
                    radioButtonDropbox.Checked = false;
                    radioButtonDropbox.Hide();
                }

                if (radioButtonDropbox.Checked)
                {
                    labelMoratoriumMs1.Show();
                    numericUpDownMoratoriumMs1.Show();
                    labelMoratoriumMs2.Show();
                    numericUpDownMoratoriumMs2.Show();
                    labelMoratoriumMs3.Show();
                    labelIconRect.Show();
                    labelIconX.Show();
                    numericUpDownIconX.Show();
                    labelIconY.Show();
                    numericUpDownIconY.Show();
                    labelIconWidth.Show();
                    numericUpDownIconWidth.Show();
                    labelIconHeight.Show();
                    numericUpDownIconHeight.Show();
                    buttonIconRectReset.Show();
                    labelPreview1.Show();
                    numericUpDownPreview.Show();
                    labelPreview2.Show();
                    labelPreview3.Show();
                    pictureBoxPreview.Show();
                }
                else
                {
                    labelMoratoriumMs1.Hide();
                    numericUpDownMoratoriumMs1.Hide();
                    labelMoratoriumMs2.Hide();
                    numericUpDownMoratoriumMs2.Hide();
                    labelMoratoriumMs3.Hide();
                    labelIconRect.Hide();
                    labelIconX.Hide();
                    numericUpDownIconX.Hide();
                    labelIconY.Hide();
                    numericUpDownIconY.Hide();
                    labelIconWidth.Hide();
                    numericUpDownIconWidth.Hide();
                    labelIconHeight.Hide();
                    numericUpDownIconHeight.Hide();
                    buttonIconRectReset.Hide();
                    labelPreview1.Hide();
                    numericUpDownPreview.Hide();
                    labelPreview2.Hide();
                    labelPreview3.Hide();
                    pictureBoxPreview.Hide();
                }
            }

            if (radioButtonEtcMenu.Checked == true)
            {
                tabControlMenu.SelectedTab = tabPageEtcMenu;

                if (_setting.level >= 20)
                {
                    checkBoxAutoOff.Show();
                }
                else
                {
                    checkBoxAutoOff.Checked = false;
                    checkBoxAutoOff.Hide();
                }

                if (checkBoxAutoOff.Checked)
                {
                    checkBoxLastMessage.Show();
                    checkBoxLastSound.Show();

                    if (checkBoxLastMessage.Checked)
                    {
                        textBoxLastMessage.Show();
                    }
                    else
                    {
                        textBoxLastMessage.Hide();
                    }


                    if (checkBoxLastSound.Checked)
                    {
                        textBoxLastSound.Show();
                        buttonLastSound.Show();
                    }
                    else
                    {
                        textBoxLastSound.Hide();
                        buttonLastSound.Hide();
                    }
                }
                else
                {
                    checkBoxLastMessage.Hide();
                    textBoxLastMessage.Hide();
                    checkBoxLastSound.Hide();
                    textBoxLastSound.Hide();
                    buttonLastSound.Hide();
                }
            }
        }
    }
}
