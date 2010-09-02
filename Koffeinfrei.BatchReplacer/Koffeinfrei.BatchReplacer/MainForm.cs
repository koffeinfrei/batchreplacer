//  Koffeinfrei Batch Replacer
//  Copyright (C) 2010  Alexis Reigel
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Koffeinfrei.BatchReplacer
{
    public partial class MainForm : Form
    {
        private readonly Replacer replacer;

        public MainForm()
        {
            InitializeComponent();
            SetModeDropdown();

            replacer = new Replacer
                           {
                               OutputDirectoryName = textBoxOutputDir.Text, 
                               Rules = new Rules()
                           };
            dataGridRules.DataSource = replacer.Rules;
        }

        private void SetRules(string fileName)
        {
            try
            {
                replacer.Rules = Rules.Load(fileName);
                dataGridRules.DataSource = replacer.Rules;
            }
            catch (InvalidOperationException e)
            {
                SetStatusMessage(e.Message);
            }

            TryEnableReplaceButton();
        }

        private void SetAbsoluteOutputDirLabel()
        {
            if (replacer.InputFiles != null && replacer.InputFiles.Count > 0)
            {
                FileInfo info = new FileInfo(replacer.InputFiles[0]);
                labelAbsoluteOutputDir.Text = info.Directory + "\\" + replacer.OutputDirectoryName;
            }
        }

        private void SetInputFiles(List<string> fileNames)
        {
            replacer.InputFiles = fileNames;

            listBoxInputFiles.DataSource = fileNames;
        }

        private void SetStatusMessage(string message)
        {
            toolStripStatusLabel.Text = message;
        }

        private void SetModeDropdown()
        {
            DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dataGridRules.Columns[2];
            comboBoxColumn.DataSource = Enum.GetValues(typeof(Rule.ModeType));
            comboBoxColumn.DataPropertyName = "Mode";
            comboBoxColumn.Name = "Mode";
        }

        private void TryEnableReplaceButton()
        {
            buttonReplace.Enabled = replacer.IsReady;
        }

        private void buttonSelectFiles_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = selectFilesDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SetInputFiles(selectFilesDialog.FileNames.ToList());
                TryEnableReplaceButton();
                SetAbsoluteOutputDirLabel();
            }
        }

        private void buttonSelectDir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = selectFoldersDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SetInputFiles(Directory.EnumerateFiles(selectFoldersDialog.SelectedPath).ToList());
                TryEnableReplaceButton();
                SetAbsoluteOutputDirLabel();
            }
        }

        private void importRulesMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = importRulesFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SetRules(importRulesFileDialog.FileName);
            }
        }

        private void exportRulesMenuItem_Click(object sender, EventArgs e)
        {
            if (replacer.Rules.IsEmpty())
            {
                SetStatusMessage("No rules are set, no need to export");
            }
            else
            {
                DialogResult dialogResult = exportRulesSaveFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    replacer.Rules.Save(exportRulesSaveFileDialog.FileName);
                    SetStatusMessage("Rules have been exported.");
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.AboutUrl);
        }

        private void textBoxOutputDir_TextChanged(object sender, EventArgs e)
        {
            replacer.OutputDirectoryName = textBoxOutputDir.Text;
            SetAbsoluteOutputDirLabel();
            TryEnableReplaceButton();
        }

        /// <summary>
        /// Allow only characters that are valid for a filename.
        /// <see cref="Path.GetInvalidFileNameChars"/>.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
        private void textBoxOutputDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Path.GetInvalidFileNameChars().Contains(e.KeyChar) && 
                e.KeyChar != (char)Keys.Back; // allow backspace
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void dataGridRules_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            TryEnableReplaceButton();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SetProgressBarValueSafe(progressBar, 0);
            SetStatusMessage("Starting job...");

            foreach (int percentProgress in replacer.StartAndReportProgress())
            {
                backgroundWorker.ReportProgress(percentProgress);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SetProgressBarValueSafe(progressBar, e.ProgressPercentage);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatusMessage("Finished.");
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private delegate void SetProgressBarValueCallback(ProgressBar bar, int percent);

        /// <summary>
        /// Sets the text for asynchronous calls in a thread safe manner.
        /// </summary>
        /// <param name="bar">The progress bar.</param>
        /// <param name="percent">The progress in percent 0-100.</param>
        private void SetProgressBarValueSafe(ProgressBar bar, int percent)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (bar.InvokeRequired)
            {
                SetProgressBarValueCallback d = SetProgressBarValueSafe;
                Invoke(d, new object[] { bar, percent });
            }
            else
            {
                bar.Value = percent;
            }
        }
    }
}
