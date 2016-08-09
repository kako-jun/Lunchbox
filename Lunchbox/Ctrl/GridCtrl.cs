using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Lunchbox
{
    internal class GridCtrl
    {
        private Setting _setting;
        private MainForm _form;

        private DataGridView _dataGridView;
        private Button _buttonAdd;
        private Button _buttonUp;
        private Button _buttonDown;

        private BindingList<Lunch> _lunches;
        public BindingList<Lunch> lunches { get { return _lunches; } set { _lunches = value; } }
        private BindingSource _bindingSourceLunch;
        private int _curIndex;

        DataGridViewComboBoxEditingControl _curComboBox;

        public GridCtrl(Setting setting, MainForm form, DataGridView dataGridView, Button buttonAdd, Button buttonUp, Button buttonDown)
        {
            _setting = setting;
            _form = form;

            _dataGridView = dataGridView;
            _buttonAdd = buttonAdd;
            _buttonUp = buttonUp;
            _buttonDown = buttonDown;

            _lunches = new BindingList<Lunch>(_setting.lunches);
            _bindingSourceLunch = new BindingSource();
            _curIndex = 0;

            _curComboBox = null;

            // 
            _dataGridView.CellEnter += new DataGridViewCellEventHandler(this.dataGridView_CellEnter);
            _dataGridView.CellEndEdit += new DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            _dataGridView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            _dataGridView.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            _dataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            _dataGridView.SelectionChanged += new EventHandler(this.dataGridView_SelectionChanged);
            _dataGridView.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            _dataGridView.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);

            _buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            _buttonUp.Click += new EventHandler(this.buttonUp_Click);
            _buttonDown.Click += new EventHandler(this.buttonDown_Click);
        }

        public void initControls()
        {
            // 
            _dataGridView.AutoGenerateColumns = false;
            //dataGridView.EnableHeadersVisualStyles = false;
            _dataGridView.Columns.Clear();

            // 
            this.resetId(ref _lunches);
            _bindingSourceLunch.DataSource = _lunches;
            _dataGridView.DataSource = _bindingSourceLunch;

            DataGridViewColumn columnId = new DataGridViewTextBoxColumn();
            columnId.Name = "columnId";
            columnId.DataPropertyName = "id";
            _dataGridView.Columns.Add(columnId);

            DataGridViewComboBoxColumn columnDirOrFile = new DataGridViewComboBoxColumn();
            columnDirOrFile.Name = "columnDirOrFile";
            columnDirOrFile.DataSource = Enum.GetValues(typeof(Lunch.DirOrFile));
            columnDirOrFile.DataPropertyName = "DirOrFile";
            _dataGridView.Columns.Add(columnDirOrFile);

            List<string> dirOrFileJas = new List<string>();
            dirOrFileJas.Add(Lunchbox.Properties.Resources.DirOrFileDir);
            dirOrFileJas.Add(Lunchbox.Properties.Resources.DirOrFileFile);

            DataGridViewComboBoxColumn columnDirOrFileJa = new DataGridViewComboBoxColumn();
            columnDirOrFileJa.Name = "columnDirOrFileJa";
            columnDirOrFileJa.DataSource = dirOrFileJas;
            _dataGridView.Columns.Add(columnDirOrFileJa);

            DataGridViewButtonColumn columnDialog = new DataGridViewButtonColumn();
            columnDialog.Name = "columnDialog";
            columnDialog.Text = "...";
            columnDialog.UseColumnTextForButtonValue = true;
            _dataGridView.Columns.Add(columnDialog);

            DataGridViewColumn columnPath = new DataGridViewTextBoxColumn();
            columnPath.Name = "columnPath";
            columnPath.DataPropertyName = "path";
            _dataGridView.Columns.Add(columnPath);

            DataGridViewComboBoxColumn columnPos = new DataGridViewComboBoxColumn();
            columnPos.Name = "columnPos";
            columnPos.DataSource = Enum.GetValues(typeof(Lunch.Pos));
            columnPos.DataPropertyName = "Pos";
            _dataGridView.Columns.Add(columnPos);

            List<string> posJas = new List<string>();
            posJas.Add(Lunchbox.Properties.Resources.PosDefault);
            posJas.Add(Lunchbox.Properties.Resources.PosTopLeft);
            posJas.Add(Lunchbox.Properties.Resources.PosTopRight);
            posJas.Add(Lunchbox.Properties.Resources.PosBottomLeft);
            posJas.Add(Lunchbox.Properties.Resources.PosBottomRight);

            DataGridViewComboBoxColumn columnPosJa = new DataGridViewComboBoxColumn();
            columnPosJa.Name = "columnPosJa";
            columnPosJa.DataSource = posJas;
            _dataGridView.Columns.Add(columnPosJa);

            DataGridViewButtonColumn columnRemove = new DataGridViewButtonColumn();
            columnRemove.Name = "columnRemove";
            columnRemove.Text = Lunchbox.Properties.Resources.RemoveButton;
            columnRemove.UseColumnTextForButtonValue = true;
            _dataGridView.Columns.Add(columnRemove);

            _dataGridView.Columns[0].HeaderText = Lunchbox.Properties.Resources.ColumnId;
            _dataGridView.Columns[1].HeaderText = "";
            _dataGridView.Columns[2].HeaderText = Lunchbox.Properties.Resources.ColumnDirOrFile;
            _dataGridView.Columns[3].HeaderText = "";
            _dataGridView.Columns[4].HeaderText = Lunchbox.Properties.Resources.ColumnPath;
            _dataGridView.Columns[5].HeaderText = "";
            _dataGridView.Columns[6].HeaderText = Lunchbox.Properties.Resources.ColumnPos;
            _dataGridView.Columns[7].HeaderText = "";

            _dataGridView.Columns[0].Width = 65;
            _dataGridView.Columns[1].Visible = false;
            _dataGridView.Columns[2].Width = 100;
            _dataGridView.Columns[3].Width = 30;
            _dataGridView.Columns[4].Width = 173;
            _dataGridView.Columns[5].Visible = false;
            _dataGridView.Columns[6].Width = 95;
            _dataGridView.Columns[7].Width = 50;

            _dataGridView.Columns[0].ReadOnly = true;

            _dataGridView.DefaultCellStyle.SelectionBackColor = Color.Blue;

            // 奇数行
            _dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            _dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Silver;
        }

        private void resetId(ref BindingList<Lunch> lunches)
        {
            for (int i = 0; i < lunches.Count; i++)
            {
                lunches[i].id = i;
            }
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            switch (dataGridView.Columns[e.ColumnIndex].Name)
            {
                case "columnDirOrFileJa":
                    SendKeys.Send("{F4}");
                    break;

                case "columnPosJa":
                    SendKeys.Send("{F4}");
                    break;

                default:
                    break;
            }
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                if (dataGridView.CurrentCell.OwningColumn.Name == "columnDirOrFileJa")
                {
                    _curComboBox = (DataGridViewComboBoxEditingControl)e.Control;
                    _curComboBox.SelectedIndexChanged += new EventHandler(columnDirOrFileJa_SelectedIndexChanged);
                }
                else if (dataGridView.CurrentCell.OwningColumn.Name == "columnPosJa")
                {
                    _curComboBox = (DataGridViewComboBoxEditingControl)e.Control;
                    _curComboBox.SelectedIndexChanged += new EventHandler(columnPosJa_SelectedIndexChanged);
                }
            }
        }

        private void columnDirOrFileJa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl comboBox = (DataGridViewComboBoxEditingControl)sender;
            _lunches[_curIndex].dirOrFile = (Lunch.DirOrFile)comboBox.SelectedIndex;
        }

        private void columnPosJa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl comboBox = (DataGridViewComboBoxEditingControl)sender;
            _lunches[_curIndex].pos = (Lunch.Pos)comboBox.SelectedIndex;
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            switch (dataGridView.Columns[e.ColumnIndex].Name)
            {
                case "columnDirOrFileJa":
                    if (_curComboBox != null)
                    {
                        _curComboBox.SelectedIndexChanged -= new EventHandler(columnDirOrFileJa_SelectedIndexChanged);
                        _curComboBox = null;
                    }
                    break;

                case "columnPosJa":
                    if (_curComboBox != null)
                    {
                        _curComboBox.SelectedIndexChanged -= new EventHandler(columnPosJa_SelectedIndexChanged);
                        _curComboBox = null;
                    }
                    break;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            switch (dataGridView.Columns[e.ColumnIndex].Name)
            {
                case "columnDialog":
                    if (_lunches[e.RowIndex].dirOrFile == Lunch.DirOrFile.Folder)
                    {
                        FolderBrowserDialog dlg = new FolderBrowserDialog();
                        if (dlg.ShowDialog(_form) == DialogResult.OK)
                        {
                            if (dlg.SelectedPath.IndexOf(" ") >= 0)
                            {
                                _lunches[e.RowIndex].path = "\"" + dlg.SelectedPath + "\"";
                            }
                            else
                            {
                                _lunches[e.RowIndex].path = dlg.SelectedPath;
                            }

                            dataGridView.Invalidate();
                        }
                    }
                    else
                    {
                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.Filter = "All files (*.*)|*.*";
                        if (dlg.ShowDialog(_form) == DialogResult.OK)
                        {
                            if (dlg.FileName.Trim().IndexOf(" ") >= 0)
                            {
                                _lunches[e.RowIndex].path = "\"" + dlg.FileName + "\"";
                            }
                            else
                            {
                                _lunches[e.RowIndex].path = dlg.FileName;
                            }

                            dataGridView.Invalidate();
                        }
                    }
                    break;

                case "columnRemove":
                    _lunches.RemoveAt(e.RowIndex);
                    break;

                default:
                    break;
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            switch (dataGridView.Columns[e.ColumnIndex].Name)
            {
                case "columnDirOrFileJa":
                    Lunch.DirOrFile dirOrFile = (Lunch.DirOrFile)dataGridView[e.ColumnIndex - 1, e.RowIndex].Value;
                    switch (dirOrFile)
                    {
                        case Lunch.DirOrFile.Folder:
                            e.Value = Lunchbox.Properties.Resources.DirOrFileDir;
                            dataGridView[e.ColumnIndex + 4, e.RowIndex].ReadOnly = false;
                            break;
                        case Lunch.DirOrFile.File:
                            e.Value = Lunchbox.Properties.Resources.DirOrFileFile;
                            dataGridView[e.ColumnIndex + 4, e.RowIndex].ReadOnly = true;
                            break;
                        default:
                            break;
                    }
                    break;

                case "columnPosJa":
                    Lunch.Pos pos = (Lunch.Pos)dataGridView[e.ColumnIndex - 1, e.RowIndex].Value;
                    switch (pos)
                    {
                        case Lunch.Pos.Default:
                            e.Value = Lunchbox.Properties.Resources.PosDefault;
                            break;
                        case Lunch.Pos.TopLeft:
                            e.Value = Lunchbox.Properties.Resources.PosTopLeft;
                            break;
                        case Lunch.Pos.TopRight:
                            e.Value = Lunchbox.Properties.Resources.PosTopRight;
                            break;
                        case Lunch.Pos.BottomLeft:
                            e.Value = Lunchbox.Properties.Resources.PosBottomLeft;
                            break;
                        case Lunch.Pos.BottomRight:
                            e.Value = Lunchbox.Properties.Resources.PosBottomRight;
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            if (dataGridView.SelectedRows.Count > 0)
            {
                _curIndex = dataGridView.SelectedRows[0].Index;
            }
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.resetId(ref _lunches);

            this.updateControls();
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.resetId(ref _lunches);

            this.updateControls();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _lunches.Add(new Lunch());
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (_dataGridView.SelectedRows.Count > 0)
            {
                if (_curIndex > 0)
                {
                    Lunch tempLunch = _lunches[_curIndex];
                    _lunches.RemoveAt(_curIndex);
                    _lunches.Insert(_curIndex - 1, tempLunch);
                    _dataGridView.Rows[_curIndex - 1].Selected = true;

                    //_curIndex--;
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (_dataGridView.SelectedRows.Count > 0)
            {
                if (_curIndex < _lunches.Count - 1)
                {
                    Lunch tempLunch = _lunches[_curIndex];
                    _lunches.RemoveAt(_curIndex);
                    _lunches.Insert(_curIndex + 1, tempLunch);
                    _dataGridView.Rows[_curIndex + 1].Selected = true;

                    //_curIndex++;
                }
            }
        }

        public void updateControls()
        {
            if (_lunches.Count >= 2)
            {
                _buttonUp.Show();
                _buttonDown.Show();
            }
            else
            {
                _buttonUp.Hide();
                _buttonDown.Hide();
            }
        }
    }
}
