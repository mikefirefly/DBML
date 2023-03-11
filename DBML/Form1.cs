using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TinyJson;

namespace DBML
{
    public partial class MainForm : Form
    {
        const string entriesFile = "DBML.json";
        const string tmpBatFile = "(DBML).BAT";
        const string badEntryIndicator = "?";
        const string favouriteEntryIndicator = "♥";
        bool startupError = false;

        //C:\Users\<username>\AppData\Local\DOSBox\
        string defaultCfgFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //Application.StartupPath + @"\DBML-baseline.conf";

        string tmpCfgFile = Application.StartupPath + @"\DBML-running.conf";
        string dosBoxExeFile = Directory.GetCurrentDirectory() + "\\dosbox.exe";
        int previdx = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            defaultCfgFile = defaultCfgFile.Remove(defaultCfgFile.LastIndexOf('\\')) + @"\Local\DOSBox\dosbox-staging.conf";
            if (!File.Exists(defaultCfgFile))
            {
                startupError = true;
                MessageBox.Show($"DBML-baseline.conf file not found in the application folder:\n\n{defaultCfgFile}\n\nThis file must exist to provide the baseline DOSBox configuration. Application will terminate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (!File.Exists(dosBoxExeFile))
            {
                startupError = true;
                MessageBox.Show("DOSBox executable not found in the current folder. Application will terminate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            lbEntryList.DragDrop += lbEntryList_DragDrop;
            lbEntryList.DragEnter += lbEntryList_DragEnter;
            lbEntryList.DisplayMember = "FriendlyName";
            lbEntryList.ValueMember = "FriendlyName";
            if (File.Exists(entriesFile))
            {
                string fileJson = File.ReadAllText(entriesFile);
                List<Entry> Entries = fileJson.FromJson<List<Entry>>();

                foreach (Entry en in Entries)
                {
                    if (!Directory.Exists(en.Path) || !File.Exists($"{en.Path}\\{en.Launch}"))
                        en.FriendlyName = badEntryIndicator + en.FriendlyName;
                    lbEntryList.Items.Add(en);
                }

                if (Entries.Count > 0)
                {
                    lbEntryList.Sorted = true;
                    lbEntryList.SelectedIndex = 0;
                }
            }
        }

        private void lbEntryList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void lbEntryList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string dirToMount = Path.GetDirectoryName(files[0]);
            if (Directory.Exists(files[0])) dirToMount += "\\" + Path.GetFileName(files[0]);
            //Entry en = new Entry(Path.GetFileName(files[0].Remove(files[0].LastIndexOf('.'))), dirToMount, Path.GetFileName(files[0]), new List<string>());
            Entry en = new Entry(dirToMount.Substring(dirToMount.LastIndexOf("\\")+1), dirToMount, Path.GetFileName(files[0]), new List<string>());
            //if (lbEntryList.Items.Cast<Entry>().Any(x => x.FriendlyName == en.FriendlyName))
            if (lbEntryList.Items.Cast<Entry>().Any(x => x.Path == en.Path) && lbEntryList.Items.Cast<Entry>().Any(x => x.Launch == en.Launch))
                MessageBox.Show("This entry already exists on the list!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else lbEntryList.Items.Add(en);
        }

        private void lbEntryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEntryList.SelectedIndex != previdx)
                previdx = lbEntryList.SelectedIndex;
            else return;

            if (lbEntryList.SelectedIndex == -1)
                if (lbEntryList.Items.Count == 0)
                {
                    tbFriendlyName.Clear();
                    tbLaunch.Clear();
                    tbPath.Clear();
                    tbFriendlyName.Enabled = false;
                    tbLaunch.Enabled = false;
                    tbPath.Enabled = false;
                    tbDOSBoxConfig.Enabled = false;
                    btnDelete.Enabled = false;
                    btnStart32.Enabled = false;
                    btnSave.Enabled = false;
                    return;
                }
                else lbEntryList.SelectedIndex = 0;

            tbFriendlyName.Enabled = true;
            tbLaunch.Enabled = true;
            tbPath.Enabled = true;
            tbDOSBoxConfig.Enabled = true;
            btnDelete.Enabled = true;

            Entry en;
            en = (Entry)lbEntryList.SelectedItem;
            tbFriendlyName.Text = en.FriendlyName;
            tbPath.Text = en.Path;
            tbLaunch.Text = en.Launch;
            tbDOSBoxConfig.Lines = en.Config.ToArray();
            btnSave.Enabled = false;
            btnStart32.Enabled = Directory.Exists(tbPath.Text) && File.Exists(dosBoxExeFile);
            btnOpenPathInExplorer.Enabled = Directory.Exists(tbPath.Text);
        }

        private void tTimer_Tick(object sender, EventArgs e)
        {
            File.Delete($"{tbPath.Text}\\{tmpBatFile}");
            File.Delete(tmpCfgFile);
            tTimer.Stop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lbEntryList.SelectedIndex;
            if (lbEntryList.SelectedIndex != -1)
            {
                lbEntryList.Items.Remove(lbEntryList.SelectedItem);
                if (i >= lbEntryList.Items.Count) lbEntryList.SelectedIndex = i - 1; else lbEntryList.SelectedIndex = i;
            }
            if (lbEntryList.Items.Count == 0) File.Delete(entriesFile);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (startupError) return;
            List<Entry> Entries = new List<Entry>();
            foreach (Entry o in lbEntryList.Items)
            {
                Entries.Add(new Entry(o.FriendlyName.Replace(badEntryIndicator, ""), o.Path, o.Launch, o.Config));
            }
            string json = Entries.ToJson();
            File.WriteAllText(entriesFile, json);
            if (lbEntryList.Items.Count == 0)
                File.Delete(entriesFile);
        }

        private void lbEntryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (lbEntryList.SelectedIndex == -1) return;
            if (e.KeyCode == Keys.Delete)
                if (e.Modifiers == Keys.Shift)
                {
                    if (MessageBox.Show($"Are you sure you want to remove this entry and delete the whole {tbPath.Text} folder?", "Confirm entry removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Directory.Delete(tbPath.Text, true);
                        btnDelete_Click(this, null);
                    }
                }
                else btnDelete_Click(this, null);

            if (e.KeyCode == Keys.Enter)
                btnStart32_Click(this, e);

            if (e.KeyCode == Keys.F1)
            {
                if (tbFriendlyName.Text.StartsWith(favouriteEntryIndicator))
                    tbFriendlyName.Text = tbFriendlyName.Text.Remove(0, 1);
                else tbFriendlyName.Text = favouriteEntryIndicator + tbFriendlyName.Text;

                Entry en = (Entry)lbEntryList.SelectedItem;
                en.FriendlyName = tbFriendlyName.Text;
                en.Path = tbPath.Text;
                en.Launch = tbLaunch.Text;
                en.Config = tbDOSBoxConfig.Lines.ToList();
                lbEntryList.DisplayMember = "";
                lbEntryList.DisplayMember = "FriendlyName";

                btnSave.Enabled = false;
            }
        }

        private void tbFriendlyName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            btnOpenPathInExplorer.Enabled = Directory.Exists(tbPath.Text);
            btnSave.Enabled = true;
        }

        private void tbLaunch_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void tbDOSBoxConfig_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Entry en = (Entry)lbEntryList.SelectedItem;
            en.FriendlyName = tbFriendlyName.Text;
            en.Path = tbPath.Text;
            en.Launch = tbLaunch.Text;
            en.Config = tbDOSBoxConfig.Lines.ToList();
            lbEntryList.DisplayMember = "";
            lbEntryList.DisplayMember = "FriendlyName";

            btnSave.Enabled = false;
        }

        private void lbEntryList_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(tbPath.Text) && File.Exists(dosBoxExeFile)) StartTheGame(32);
        }

        private void btnStart32_Click(object sender, EventArgs e)
        {
            StartTheGame(32);
        }

        private void StartTheGame(int bits)
        {
            // parsing new configuration will automatically put parameters into their correct sections
            List<string> notFoundLines = new List<string>();
            List<string> cfglines = File.ReadAllLines(defaultCfgFile).ToList();
            List<string> newCfgLines = new List<string>();
            foreach (string s in tbDOSBoxConfig.Lines)
            {
                // skip user lines that are either comments or not parameters
                if (s.StartsWith("#")) continue; 
                if (!s.Contains("=")) continue;
                
                bool found = false;
                string currentSection = "";
                for (int i = 0; i < cfglines.Count; i++)
                {
                    if (cfglines[i].StartsWith("[")) { currentSection = cfglines[i].Trim(); continue; }
                    // skip processing default config lines that are either comments or not parameters
                    if (!cfglines[i].Contains("=")) continue;
                    if (cfglines[i].StartsWith("#")) continue;
                    if (cfglines[i].Substring(0, cfglines[i].IndexOf("=")).Trim() == s.Substring(0, s.IndexOf("=")).Trim())
                    {
                        found = true;
                        newCfgLines.Add(currentSection);
                        newCfgLines.Add(s);
                        break;
                    }
                    //if (found) break;
                }
                if (!found)
                    notFoundLines.Add(s);
            }

            if (notFoundLines.Count > 0)
                if (MessageBox.Show("Failed to find the following entries in the DOSBox baseline configuration file: \n\n" +
                    string.Join(Environment.NewLine, notFoundLines) + "\n\nDo you want to run " + lbEntryList.Text + " anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            
            //File.WriteAllLines(tmpCfgFile, cfglines);
            File.WriteAllLines(tmpCfgFile, newCfgLines);// tbDOSBoxConfig.Lines);
            
            File.WriteAllText(tbPath.Text + "\\" + tmpBatFile, "@" + tbLaunch.Text);

            string showstatus = "";
            if (!cbStatusWindow.Checked) showstatus = "-noconsole";
            Process p = new Process();
            p.StartInfo.WorkingDirectory = Path.GetDirectoryName(dosBoxExeFile);
            p.StartInfo.FileName = "dosbox.exe";
            p.StartInfo.Arguments = $"{showstatus} -userconf -conf \"{tmpCfgFile}\" \"{tbPath.Text}\\{tmpBatFile}\"";
            //p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p.Start();
            tTimer.Start();
        }

        private void btnOpenPathInExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "\"" + tbPath.Text.Replace('/', '\\') + "\"");
        }

        private void tbDOSBoxConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                if (e.Modifiers == Keys.Control)
                    btnSave_Click(this, e);
        }

        private void btnOpenDefaultConfig_Click(object sender, EventArgs e)
        {
            Process.Start(defaultCfgFile);
        }
    }
}