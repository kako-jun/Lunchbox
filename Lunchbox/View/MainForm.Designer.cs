namespace Lunchbox
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerGetImage = new System.Windows.Forms.Timer(this.components);
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageAppMenu = new System.Windows.Forms.TabPage();
            this.labelLunch = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.dataGridViewLunch = new System.Windows.Forms.DataGridView();
            this.tabPageTimingMenu = new System.Windows.Forms.TabPage();
            this.labelPreview2 = new System.Windows.Forms.Label();
            this.numericUpDownPreview = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMoratoriumMs1 = new System.Windows.Forms.NumericUpDown();
            this.labelMoratoriumMs2 = new System.Windows.Forms.Label();
            this.buttonIconRectReset = new System.Windows.Forms.Button();
            this.labelIconHeight = new System.Windows.Forms.Label();
            this.numericUpDownIconHeight = new System.Windows.Forms.NumericUpDown();
            this.labelIconWidth = new System.Windows.Forms.Label();
            this.numericUpDownIconWidth = new System.Windows.Forms.NumericUpDown();
            this.labelIconY = new System.Windows.Forms.Label();
            this.numericUpDownIconY = new System.Windows.Forms.NumericUpDown();
            this.labelIconX = new System.Windows.Forms.Label();
            this.numericUpDownIconX = new System.Windows.Forms.NumericUpDown();
            this.labelIconRect = new System.Windows.Forms.Label();
            this.labelMoratoriumMs1 = new System.Windows.Forms.Label();
            this.labelMoratoriumMs3 = new System.Windows.Forms.Label();
            this.numericUpDownMoratoriumMs2 = new System.Windows.Forms.NumericUpDown();
            this.radioButtonDropbox = new System.Windows.Forms.RadioButton();
            this.radioButtonDesktop = new System.Windows.Forms.RadioButton();
            this.labelPreview1 = new System.Windows.Forms.Label();
            this.labelPreview3 = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.tabPageEtcMenu = new System.Windows.Forms.TabPage();
            this.labelTileDelayMs2 = new System.Windows.Forms.Label();
            this.labelTileHeight = new System.Windows.Forms.Label();
            this.numericUpDownTileHeight = new System.Windows.Forms.NumericUpDown();
            this.labelTileWidth = new System.Windows.Forms.Label();
            this.numericUpDownTileWidth = new System.Windows.Forms.NumericUpDown();
            this.labelTileRect = new System.Windows.Forms.Label();
            this.labelTileDelayMs1 = new System.Windows.Forms.Label();
            this.numericUpDownTileDelayMs = new System.Windows.Forms.NumericUpDown();
            this.linkLabelUrl = new System.Windows.Forms.LinkLabel();
            this.buttonLastSound = new System.Windows.Forms.Button();
            this.textBoxLastSound = new System.Windows.Forms.TextBox();
            this.textBoxLastMessage = new System.Windows.Forms.TextBox();
            this.checkBoxLastSound = new System.Windows.Forms.CheckBox();
            this.checkBoxLastMessage = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoOff = new System.Windows.Forms.CheckBox();
            this.checkBoxStartUp = new System.Windows.Forms.CheckBox();
            this.notifyIconTaskTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTaskTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAutoOff = new System.Windows.Forms.Timer(this.components);
            this.timerOnStart = new System.Windows.Forms.Timer(this.components);
            this.timerMoratoriumDelay = new System.Windows.Forms.Timer(this.components);
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.radioButtonAppMenu = new System.Windows.Forms.RadioButton();
            this.radioButtonEtcMenu = new System.Windows.Forms.RadioButton();
            this.radioButtonTimingMenu = new System.Windows.Forms.RadioButton();
            this.tabControlMenu.SuspendLayout();
            this.tabPageAppMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLunch)).BeginInit();
            this.tabPageTimingMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoratoriumMs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoratoriumMs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.tabPageEtcMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileDelayMs)).BeginInit();
            this.contextMenuStripTaskTray.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerGetImage
            // 
            this.timerGetImage.Interval = 1100;
            this.timerGetImage.Tick += new System.EventHandler(this.timerGetImage_Tick);
            // 
            // tabControlMenu
            // 
            resources.ApplyResources(this.tabControlMenu, "tabControlMenu");
            this.tabControlMenu.Controls.Add(this.tabPageAppMenu);
            this.tabControlMenu.Controls.Add(this.tabPageTimingMenu);
            this.tabControlMenu.Controls.Add(this.tabPageEtcMenu);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.TabStop = false;
            // 
            // tabPageAppMenu
            // 
            this.tabPageAppMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageAppMenu.Controls.Add(this.labelLunch);
            this.tabPageAppMenu.Controls.Add(this.buttonAdd);
            this.tabPageAppMenu.Controls.Add(this.buttonDown);
            this.tabPageAppMenu.Controls.Add(this.buttonUp);
            this.tabPageAppMenu.Controls.Add(this.dataGridViewLunch);
            resources.ApplyResources(this.tabPageAppMenu, "tabPageAppMenu");
            this.tabPageAppMenu.Name = "tabPageAppMenu";
            // 
            // labelLunch
            // 
            resources.ApplyResources(this.labelLunch, "labelLunch");
            this.labelLunch.ForeColor = System.Drawing.Color.Silver;
            this.labelLunch.Name = "labelLunch";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonDown, "buttonDown");
            this.buttonDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.UseVisualStyleBackColor = false;
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonUp, "buttonUp");
            this.buttonUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.UseVisualStyleBackColor = false;
            // 
            // dataGridViewLunch
            // 
            this.dataGridViewLunch.AllowUserToAddRows = false;
            this.dataGridViewLunch.AllowUserToResizeColumns = false;
            this.dataGridViewLunch.AllowUserToResizeRows = false;
            this.dataGridViewLunch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewLunch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLunch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewLunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewLunch, "dataGridViewLunch");
            this.dataGridViewLunch.MultiSelect = false;
            this.dataGridViewLunch.Name = "dataGridViewLunch";
            this.dataGridViewLunch.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            this.dataGridViewLunch.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLunch.RowTemplate.Height = 21;
            this.dataGridViewLunch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // tabPageTimingMenu
            // 
            this.tabPageTimingMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageTimingMenu.Controls.Add(this.labelPreview2);
            this.tabPageTimingMenu.Controls.Add(this.numericUpDownPreview);
            this.tabPageTimingMenu.Controls.Add(this.numericUpDownMoratoriumMs1);
            this.tabPageTimingMenu.Controls.Add(this.labelMoratoriumMs2);
            this.tabPageTimingMenu.Controls.Add(this.buttonIconRectReset);
            this.tabPageTimingMenu.Controls.Add(this.labelIconHeight);
            this.tabPageTimingMenu.Controls.Add(this.numericUpDownIconHeight);
            this.tabPageTimingMenu.Controls.Add(this.labelIconWidth);
            this.tabPageTimingMenu.Controls.Add(this.numericUpDownIconWidth);
            this.tabPageTimingMenu.Controls.Add(this.labelIconY);
            this.tabPageTimingMenu.Controls.Add(this.numericUpDownIconY);
            this.tabPageTimingMenu.Controls.Add(this.labelIconX);
            this.tabPageTimingMenu.Controls.Add(this.numericUpDownIconX);
            this.tabPageTimingMenu.Controls.Add(this.labelIconRect);
            this.tabPageTimingMenu.Controls.Add(this.labelMoratoriumMs1);
            this.tabPageTimingMenu.Controls.Add(this.labelMoratoriumMs3);
            this.tabPageTimingMenu.Controls.Add(this.numericUpDownMoratoriumMs2);
            this.tabPageTimingMenu.Controls.Add(this.radioButtonDropbox);
            this.tabPageTimingMenu.Controls.Add(this.radioButtonDesktop);
            this.tabPageTimingMenu.Controls.Add(this.labelPreview1);
            this.tabPageTimingMenu.Controls.Add(this.labelPreview3);
            this.tabPageTimingMenu.Controls.Add(this.pictureBoxPreview);
            resources.ApplyResources(this.tabPageTimingMenu, "tabPageTimingMenu");
            this.tabPageTimingMenu.Name = "tabPageTimingMenu";
            // 
            // labelPreview2
            // 
            resources.ApplyResources(this.labelPreview2, "labelPreview2");
            this.labelPreview2.ForeColor = System.Drawing.Color.Silver;
            this.labelPreview2.Name = "labelPreview2";
            // 
            // numericUpDownPreview
            // 
            this.numericUpDownPreview.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownPreview, "numericUpDownPreview");
            this.numericUpDownPreview.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownPreview.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPreview.Name = "numericUpDownPreview";
            this.numericUpDownPreview.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMoratoriumMs1
            // 
            this.numericUpDownMoratoriumMs1.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownMoratoriumMs1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownMoratoriumMs1, "numericUpDownMoratoriumMs1");
            this.numericUpDownMoratoriumMs1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownMoratoriumMs1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMoratoriumMs1.Name = "numericUpDownMoratoriumMs1";
            this.numericUpDownMoratoriumMs1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMoratoriumMs2
            // 
            resources.ApplyResources(this.labelMoratoriumMs2, "labelMoratoriumMs2");
            this.labelMoratoriumMs2.ForeColor = System.Drawing.Color.Silver;
            this.labelMoratoriumMs2.Name = "labelMoratoriumMs2";
            // 
            // buttonIconRectReset
            // 
            this.buttonIconRectReset.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonIconRectReset, "buttonIconRectReset");
            this.buttonIconRectReset.ForeColor = System.Drawing.Color.Gray;
            this.buttonIconRectReset.Name = "buttonIconRectReset";
            this.buttonIconRectReset.UseVisualStyleBackColor = false;
            this.buttonIconRectReset.Click += new System.EventHandler(this.buttonIconRectReset_Click);
            // 
            // labelIconHeight
            // 
            resources.ApplyResources(this.labelIconHeight, "labelIconHeight");
            this.labelIconHeight.ForeColor = System.Drawing.Color.Silver;
            this.labelIconHeight.Name = "labelIconHeight";
            // 
            // numericUpDownIconHeight
            // 
            this.numericUpDownIconHeight.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownIconHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownIconHeight, "numericUpDownIconHeight");
            this.numericUpDownIconHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIconHeight.Name = "numericUpDownIconHeight";
            this.numericUpDownIconHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelIconWidth
            // 
            resources.ApplyResources(this.labelIconWidth, "labelIconWidth");
            this.labelIconWidth.ForeColor = System.Drawing.Color.Silver;
            this.labelIconWidth.Name = "labelIconWidth";
            // 
            // numericUpDownIconWidth
            // 
            this.numericUpDownIconWidth.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownIconWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownIconWidth, "numericUpDownIconWidth");
            this.numericUpDownIconWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIconWidth.Name = "numericUpDownIconWidth";
            this.numericUpDownIconWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelIconY
            // 
            resources.ApplyResources(this.labelIconY, "labelIconY");
            this.labelIconY.ForeColor = System.Drawing.Color.Silver;
            this.labelIconY.Name = "labelIconY";
            // 
            // numericUpDownIconY
            // 
            this.numericUpDownIconY.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownIconY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownIconY, "numericUpDownIconY");
            this.numericUpDownIconY.Name = "numericUpDownIconY";
            // 
            // labelIconX
            // 
            resources.ApplyResources(this.labelIconX, "labelIconX");
            this.labelIconX.ForeColor = System.Drawing.Color.Silver;
            this.labelIconX.Name = "labelIconX";
            // 
            // numericUpDownIconX
            // 
            this.numericUpDownIconX.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownIconX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownIconX, "numericUpDownIconX");
            this.numericUpDownIconX.Name = "numericUpDownIconX";
            // 
            // labelIconRect
            // 
            resources.ApplyResources(this.labelIconRect, "labelIconRect");
            this.labelIconRect.ForeColor = System.Drawing.Color.Silver;
            this.labelIconRect.Name = "labelIconRect";
            // 
            // labelMoratoriumMs1
            // 
            resources.ApplyResources(this.labelMoratoriumMs1, "labelMoratoriumMs1");
            this.labelMoratoriumMs1.ForeColor = System.Drawing.Color.Silver;
            this.labelMoratoriumMs1.Name = "labelMoratoriumMs1";
            // 
            // labelMoratoriumMs3
            // 
            resources.ApplyResources(this.labelMoratoriumMs3, "labelMoratoriumMs3");
            this.labelMoratoriumMs3.ForeColor = System.Drawing.Color.Silver;
            this.labelMoratoriumMs3.Name = "labelMoratoriumMs3";
            // 
            // numericUpDownMoratoriumMs2
            // 
            this.numericUpDownMoratoriumMs2.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownMoratoriumMs2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownMoratoriumMs2, "numericUpDownMoratoriumMs2");
            this.numericUpDownMoratoriumMs2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownMoratoriumMs2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMoratoriumMs2.Name = "numericUpDownMoratoriumMs2";
            this.numericUpDownMoratoriumMs2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButtonDropbox
            // 
            resources.ApplyResources(this.radioButtonDropbox, "radioButtonDropbox");
            this.radioButtonDropbox.ForeColor = System.Drawing.Color.Silver;
            this.radioButtonDropbox.Name = "radioButtonDropbox";
            this.radioButtonDropbox.UseVisualStyleBackColor = true;
            this.radioButtonDropbox.CheckedChanged += new System.EventHandler(this.radioButtonDropbox_CheckedChanged);
            // 
            // radioButtonDesktop
            // 
            resources.ApplyResources(this.radioButtonDesktop, "radioButtonDesktop");
            this.radioButtonDesktop.Checked = true;
            this.radioButtonDesktop.ForeColor = System.Drawing.Color.Silver;
            this.radioButtonDesktop.Name = "radioButtonDesktop";
            this.radioButtonDesktop.TabStop = true;
            this.radioButtonDesktop.UseVisualStyleBackColor = true;
            this.radioButtonDesktop.CheckedChanged += new System.EventHandler(this.radioButtonDesktop_CheckedChanged);
            // 
            // labelPreview1
            // 
            resources.ApplyResources(this.labelPreview1, "labelPreview1");
            this.labelPreview1.ForeColor = System.Drawing.Color.Silver;
            this.labelPreview1.Name = "labelPreview1";
            // 
            // labelPreview3
            // 
            resources.ApplyResources(this.labelPreview3, "labelPreview3");
            this.labelPreview3.ForeColor = System.Drawing.Color.Silver;
            this.labelPreview3.Name = "labelPreview3";
            // 
            // pictureBoxPreview
            // 
            resources.ApplyResources(this.pictureBoxPreview, "pictureBoxPreview");
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.TabStop = false;
            // 
            // tabPageEtcMenu
            // 
            this.tabPageEtcMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageEtcMenu.Controls.Add(this.labelTileDelayMs2);
            this.tabPageEtcMenu.Controls.Add(this.labelTileHeight);
            this.tabPageEtcMenu.Controls.Add(this.numericUpDownTileHeight);
            this.tabPageEtcMenu.Controls.Add(this.labelTileWidth);
            this.tabPageEtcMenu.Controls.Add(this.numericUpDownTileWidth);
            this.tabPageEtcMenu.Controls.Add(this.labelTileRect);
            this.tabPageEtcMenu.Controls.Add(this.labelTileDelayMs1);
            this.tabPageEtcMenu.Controls.Add(this.numericUpDownTileDelayMs);
            this.tabPageEtcMenu.Controls.Add(this.linkLabelUrl);
            this.tabPageEtcMenu.Controls.Add(this.buttonLastSound);
            this.tabPageEtcMenu.Controls.Add(this.textBoxLastSound);
            this.tabPageEtcMenu.Controls.Add(this.textBoxLastMessage);
            this.tabPageEtcMenu.Controls.Add(this.checkBoxLastSound);
            this.tabPageEtcMenu.Controls.Add(this.checkBoxLastMessage);
            this.tabPageEtcMenu.Controls.Add(this.checkBoxAutoOff);
            this.tabPageEtcMenu.Controls.Add(this.checkBoxStartUp);
            resources.ApplyResources(this.tabPageEtcMenu, "tabPageEtcMenu");
            this.tabPageEtcMenu.Name = "tabPageEtcMenu";
            // 
            // labelTileDelayMs2
            // 
            resources.ApplyResources(this.labelTileDelayMs2, "labelTileDelayMs2");
            this.labelTileDelayMs2.ForeColor = System.Drawing.Color.Silver;
            this.labelTileDelayMs2.Name = "labelTileDelayMs2";
            // 
            // labelTileHeight
            // 
            resources.ApplyResources(this.labelTileHeight, "labelTileHeight");
            this.labelTileHeight.ForeColor = System.Drawing.Color.Silver;
            this.labelTileHeight.Name = "labelTileHeight";
            // 
            // numericUpDownTileHeight
            // 
            this.numericUpDownTileHeight.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownTileHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownTileHeight, "numericUpDownTileHeight");
            this.numericUpDownTileHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTileHeight.Name = "numericUpDownTileHeight";
            this.numericUpDownTileHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTileWidth
            // 
            resources.ApplyResources(this.labelTileWidth, "labelTileWidth");
            this.labelTileWidth.ForeColor = System.Drawing.Color.Silver;
            this.labelTileWidth.Name = "labelTileWidth";
            // 
            // numericUpDownTileWidth
            // 
            this.numericUpDownTileWidth.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownTileWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownTileWidth, "numericUpDownTileWidth");
            this.numericUpDownTileWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTileWidth.Name = "numericUpDownTileWidth";
            this.numericUpDownTileWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTileRect
            // 
            resources.ApplyResources(this.labelTileRect, "labelTileRect");
            this.labelTileRect.ForeColor = System.Drawing.Color.Silver;
            this.labelTileRect.Name = "labelTileRect";
            // 
            // labelTileDelayMs1
            // 
            resources.ApplyResources(this.labelTileDelayMs1, "labelTileDelayMs1");
            this.labelTileDelayMs1.ForeColor = System.Drawing.Color.Silver;
            this.labelTileDelayMs1.Name = "labelTileDelayMs1";
            // 
            // numericUpDownTileDelayMs
            // 
            this.numericUpDownTileDelayMs.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownTileDelayMs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numericUpDownTileDelayMs, "numericUpDownTileDelayMs");
            this.numericUpDownTileDelayMs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownTileDelayMs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTileDelayMs.Name = "numericUpDownTileDelayMs";
            this.numericUpDownTileDelayMs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // linkLabelUrl
            // 
            this.linkLabelUrl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.linkLabelUrl, "linkLabelUrl");
            this.linkLabelUrl.LinkColor = System.Drawing.Color.Silver;
            this.linkLabelUrl.Name = "linkLabelUrl";
            this.linkLabelUrl.TabStop = true;
            this.linkLabelUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUrl_LinkClicked);
            // 
            // buttonLastSound
            // 
            this.buttonLastSound.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonLastSound, "buttonLastSound");
            this.buttonLastSound.ForeColor = System.Drawing.Color.Gray;
            this.buttonLastSound.Name = "buttonLastSound";
            this.buttonLastSound.UseVisualStyleBackColor = false;
            this.buttonLastSound.Click += new System.EventHandler(this.buttonLastSound_Click);
            // 
            // textBoxLastSound
            // 
            this.textBoxLastSound.BackColor = System.Drawing.Color.Silver;
            this.textBoxLastSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastSound.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textBoxLastSound, "textBoxLastSound");
            this.textBoxLastSound.Name = "textBoxLastSound";
            // 
            // textBoxLastMessage
            // 
            this.textBoxLastMessage.BackColor = System.Drawing.Color.Silver;
            this.textBoxLastMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastMessage.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textBoxLastMessage, "textBoxLastMessage");
            this.textBoxLastMessage.Name = "textBoxLastMessage";
            // 
            // checkBoxLastSound
            // 
            resources.ApplyResources(this.checkBoxLastSound, "checkBoxLastSound");
            this.checkBoxLastSound.ForeColor = System.Drawing.Color.Silver;
            this.checkBoxLastSound.Name = "checkBoxLastSound";
            this.checkBoxLastSound.UseVisualStyleBackColor = true;
            this.checkBoxLastSound.CheckedChanged += new System.EventHandler(this.checkBoxLastSound_CheckedChanged);
            // 
            // checkBoxLastMessage
            // 
            resources.ApplyResources(this.checkBoxLastMessage, "checkBoxLastMessage");
            this.checkBoxLastMessage.ForeColor = System.Drawing.Color.Silver;
            this.checkBoxLastMessage.Name = "checkBoxLastMessage";
            this.checkBoxLastMessage.UseVisualStyleBackColor = true;
            this.checkBoxLastMessage.CheckedChanged += new System.EventHandler(this.checkBoxLastMessage_CheckedChanged);
            // 
            // checkBoxAutoOff
            // 
            resources.ApplyResources(this.checkBoxAutoOff, "checkBoxAutoOff");
            this.checkBoxAutoOff.ForeColor = System.Drawing.Color.Silver;
            this.checkBoxAutoOff.Name = "checkBoxAutoOff";
            this.checkBoxAutoOff.UseVisualStyleBackColor = true;
            this.checkBoxAutoOff.CheckedChanged += new System.EventHandler(this.checkBoxAutoOff_CheckedChanged);
            // 
            // checkBoxStartUp
            // 
            resources.ApplyResources(this.checkBoxStartUp, "checkBoxStartUp");
            this.checkBoxStartUp.ForeColor = System.Drawing.Color.Silver;
            this.checkBoxStartUp.Name = "checkBoxStartUp";
            this.checkBoxStartUp.UseVisualStyleBackColor = true;
            // 
            // notifyIconTaskTray
            // 
            this.notifyIconTaskTray.ContextMenuStrip = this.contextMenuStripTaskTray;
            resources.ApplyResources(this.notifyIconTaskTray, "notifyIconTaskTray");
            this.notifyIconTaskTray.DoubleClick += new System.EventHandler(this.notifyIconTaskTray_DoubleClick);
            // 
            // contextMenuStripTaskTray
            // 
            this.contextMenuStripTaskTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripTaskTray.Name = "contextMenuStripTaskTray";
            resources.ApplyResources(this.contextMenuStripTaskTray, "contextMenuStripTaskTray");
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            resources.ApplyResources(this.settingToolStripMenuItem, "settingToolStripMenuItem");
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timerAutoOff
            // 
            this.timerAutoOff.Interval = 3000;
            this.timerAutoOff.Tick += new System.EventHandler(this.timerAutoOff_Tick);
            // 
            // timerOnStart
            // 
            this.timerOnStart.Interval = 1000;
            this.timerOnStart.Tick += new System.EventHandler(this.timerOnStart_Tick);
            // 
            // timerMoratoriumDelay
            // 
            this.timerMoratoriumDelay.Tick += new System.EventHandler(this.timerMoratoriumDelay_Tick);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Transparent;
            this.panelFooter.Controls.Add(this.buttonCancel);
            this.panelFooter.Controls.Add(this.buttonOk);
            resources.ApplyResources(this.panelFooter, "panelFooter");
            this.panelFooter.Name = "panelFooter";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.ForeColor = System.Drawing.Color.Gray;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.ForeColor = System.Drawing.Color.Gray;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // radioButtonAppMenu
            // 
            resources.ApplyResources(this.radioButtonAppMenu, "radioButtonAppMenu");
            this.radioButtonAppMenu.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAppMenu.ForeColor = System.Drawing.Color.Gray;
            this.radioButtonAppMenu.Name = "radioButtonAppMenu";
            this.radioButtonAppMenu.TabStop = true;
            this.radioButtonAppMenu.UseVisualStyleBackColor = false;
            this.radioButtonAppMenu.CheckedChanged += new System.EventHandler(this.radioButtonAppMenu_CheckedChanged);
            // 
            // radioButtonEtcMenu
            // 
            resources.ApplyResources(this.radioButtonEtcMenu, "radioButtonEtcMenu");
            this.radioButtonEtcMenu.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonEtcMenu.ForeColor = System.Drawing.Color.Gray;
            this.radioButtonEtcMenu.Name = "radioButtonEtcMenu";
            this.radioButtonEtcMenu.TabStop = true;
            this.radioButtonEtcMenu.UseVisualStyleBackColor = false;
            this.radioButtonEtcMenu.CheckedChanged += new System.EventHandler(this.radioButtonEtcMenu_CheckedChanged);
            // 
            // radioButtonTimingMenu
            // 
            resources.ApplyResources(this.radioButtonTimingMenu, "radioButtonTimingMenu");
            this.radioButtonTimingMenu.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTimingMenu.ForeColor = System.Drawing.Color.Gray;
            this.radioButtonTimingMenu.Name = "radioButtonTimingMenu";
            this.radioButtonTimingMenu.TabStop = true;
            this.radioButtonTimingMenu.UseVisualStyleBackColor = false;
            this.radioButtonTimingMenu.CheckedChanged += new System.EventHandler(this.radioButtonTimingMenu_CheckedChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.radioButtonAppMenu);
            this.Controls.Add(this.radioButtonEtcMenu);
            this.Controls.Add(this.radioButtonTimingMenu);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.tabControlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageAppMenu.ResumeLayout(false);
            this.tabPageAppMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLunch)).EndInit();
            this.tabPageTimingMenu.ResumeLayout(false);
            this.tabPageTimingMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoratoriumMs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoratoriumMs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.tabPageEtcMenu.ResumeLayout(false);
            this.tabPageEtcMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileDelayMs)).EndInit();
            this.contextMenuStripTaskTray.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripTaskTray;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerOnStart;
        private System.Windows.Forms.Timer timerMoratoriumDelay;
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageAppMenu;
        private System.Windows.Forms.TabPage tabPageTimingMenu;
        private System.Windows.Forms.TabPage tabPageEtcMenu;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.RadioButton radioButtonAppMenu;
        private System.Windows.Forms.RadioButton radioButtonEtcMenu;
        private System.Windows.Forms.RadioButton radioButtonTimingMenu;
        internal System.Windows.Forms.Timer timerAutoOff;
        internal System.Windows.Forms.Timer timerGetImage;
        internal System.Windows.Forms.NotifyIcon notifyIconTaskTray;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.DataGridView dataGridViewLunch;
        private System.Windows.Forms.Label labelPreview2;
        private System.Windows.Forms.NumericUpDown numericUpDownPreview;
        private System.Windows.Forms.NumericUpDown numericUpDownMoratoriumMs1;
        private System.Windows.Forms.Label labelMoratoriumMs2;
        private System.Windows.Forms.Button buttonIconRectReset;
        private System.Windows.Forms.Label labelIconHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownIconHeight;
        private System.Windows.Forms.Label labelIconWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownIconWidth;
        private System.Windows.Forms.Label labelIconY;
        private System.Windows.Forms.NumericUpDown numericUpDownIconY;
        private System.Windows.Forms.Label labelIconX;
        private System.Windows.Forms.NumericUpDown numericUpDownIconX;
        private System.Windows.Forms.Label labelIconRect;
        private System.Windows.Forms.Label labelMoratoriumMs1;
        private System.Windows.Forms.Label labelMoratoriumMs3;
        private System.Windows.Forms.NumericUpDown numericUpDownMoratoriumMs2;
        private System.Windows.Forms.RadioButton radioButtonDropbox;
        private System.Windows.Forms.RadioButton radioButtonDesktop;
        private System.Windows.Forms.Label labelPreview1;
        private System.Windows.Forms.Label labelPreview3;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label labelTileDelayMs2;
        private System.Windows.Forms.Label labelTileHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownTileHeight;
        private System.Windows.Forms.Label labelTileWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownTileWidth;
        private System.Windows.Forms.Label labelTileRect;
        private System.Windows.Forms.Label labelTileDelayMs1;
        private System.Windows.Forms.NumericUpDown numericUpDownTileDelayMs;
        private System.Windows.Forms.LinkLabel linkLabelUrl;
        private System.Windows.Forms.Button buttonLastSound;
        private System.Windows.Forms.TextBox textBoxLastSound;
        private System.Windows.Forms.TextBox textBoxLastMessage;
        private System.Windows.Forms.CheckBox checkBoxLastSound;
        private System.Windows.Forms.CheckBox checkBoxLastMessage;
        private System.Windows.Forms.CheckBox checkBoxAutoOff;
        private System.Windows.Forms.CheckBox checkBoxStartUp;
        private System.Windows.Forms.Label labelLunch;
    }
}

