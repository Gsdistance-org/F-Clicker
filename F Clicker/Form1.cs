using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Clicker
{
    public partial class Form1 : Form
    {
        string[] versionconf = new string[2];
        static int versionint = 102;
        static string ver = "1.0.2";
        string[] master = new string[34];
        double Fs = 0;
        double Fpc = 1;
        double Fps = 0;
        double mousefneed = 5;
        static int upgradenum = 3;
        string fcename = "New";
        string saveloc;
        int mousegetted = 0;
        int fonatorgetted = 0;
        double fonatorfneed = 90;
        int manufabrigetted = 1;
        double manufabrifneed = 50;
        double multiplyer = 1;
        double rebirts = 0;
        double xp = 1;
        double level = 1;
        double ssdss = 404;
        double corrected = 0;
        int timertimemili, timertimesec, timertimedk, timertimehour, timertimeday, timertimeyear = 0;
        string autosave = "Auto-Save (ON)";
        int slavesgetted = 0;
        double slavesfneed = 100;
        bool skillsshow = false;
        double rebirtfneed = 1000000;
        bool rebirtget = false;
        double multskillfneed = 100000;
        int multskilllevel = 0;
        bool multskillisbuyed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fs += Fpc * multiplyer;
        }

        private void repaet_Tick(object sender, EventArgs e)
        {
            if (rebirtget)
            {
                if (Fs > rebirtfneed)
                {
                    rebirts++;
                    rebirtfneed *= 1.5;
                }
                else
                {
                    MessageBox.Show("You Need" + " (" + (rebirtfneed - Fs) + ") " + "More F's To Rebirt");
                    if (MessageBox.Show("Do you want to Go to Shop?", "Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Going to shop...", "Shop");
                    }
                }
            }
            rebirtcycle.Maximum = Convert.ToInt32(rebirtfneed);
            rebirtcycle.Value = Convert.ToInt32(Fs);
            label1.Text = "F's:" + Fs;
            if(Fs > rebirtfneed)
            {
                button1.Text = "Rebirt";
            }
            else
            {
                button1.Text = "Rebirtneeds: " + Fs + "/" + rebirtfneed;
            }
            if (checkBox1.Checked)
            {
                upgrades.Show();
            }
            else
            {
                upgrades.Hide();
            }
            string[] fneeds = new string[1] { "Mouse" };
            File.WriteAllLines(@".\fneeds.mem", fneeds);
            if (skillsshow)
            {
                pictureBox2.Show();
            }
            else
            {
                pictureBox2.Hide();
            }
        }

        private void upgrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (upgrades.Columns[e.ColumnIndex].Name == "Mouse")
            {
                if(Fs > mousefneed)
                {
                    Fpc += 1;
                    mousefneed *= 1.5;
                    Fs -= mousefneed;
                    mousegetted++;
                }
                else
                {
                    MessageBox.Show("You Need" + " (" + (mousefneed - Fs) + ") " + "More F's");
                    if(MessageBox.Show("Do you want to Go to Shop?", "Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Going to shop...", "Shop");
                    }
                }
            }
            if (upgrades.Columns[e.ColumnIndex].Name == "Fonator")
            {
                if (Fs > fonatorfneed)
                {
                    Fps += 1;
                    fonatorfneed *= 1.5;
                    Fs -= fonatorfneed;
                    fonatorgetted++;
                }
                else
                {
                    MessageBox.Show("You Need" + " (" + (fonatorfneed - Fs) + ") " + "More F's");
                    if (MessageBox.Show("Do you want to Go to Shop?", "Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Going to shop...", "Shop");
                    }
                }
            }
            if (upgrades.Columns[e.ColumnIndex].Name == "ManualFabricator")
            {
                if (Fs > manufabrifneed)
                {
                    Fpc += 10;
                    manufabrifneed *= 1.5;
                    Fs -= manufabrifneed;
                    manufabrigetted++;
                }
                else
                {
                    MessageBox.Show("You Need" + " (" + (manufabrifneed - Fs) + ") " + "More F's");
                    if (MessageBox.Show("Do you want to Go to Shop?", "Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Going to shop...", "Shop");
                    }
                }
            }
            if (upgrades.Columns[e.ColumnIndex].Name == "Slaves")
            {
                if (Fs > manufabrifneed)
                {
                    Fpc += 20;
                    slavesfneed *= 1.5;
                    Fs -= slavesfneed;
                    slavesgetted++;
                }
                else
                {
                    MessageBox.Show("You Need" + " (" + (manufabrifneed - Fs) + ") " + "More F's");
                    if (MessageBox.Show("Do you want to Go to Shop?", "Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Going to shop...", "Shop");
                    }
                }
            }
        }

        private void needswrite_Tick(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                master[0] = (fcename);
                master[1] = Convert.ToString(Fs);
                master[2] = Convert.ToString(Fpc);
                master[3] = Convert.ToString(mousefneed);
                master[4] = Convert.ToString(ver);
                master[5] = Convert.ToString(upgradenum);
                master[6] = ("Time Played");
                master[7] = Convert.ToString(mousegetted);
                master[8] = Convert.ToString(Fps);
                master[9] = Convert.ToString(fonatorfneed);
                master[10] = Convert.ToString(fonatorgetted);
                master[11] = Convert.ToString(manufabrifneed);
                master[12] = Convert.ToString(manufabrigetted);
                master[13] = Convert.ToString(multiplyer);
                master[14] = Convert.ToString(rebirts);
                master[15] = Convert.ToString(xp);
                master[16] = Convert.ToString(level);
                master[17] = Convert.ToString(ssdss);
                master[18] = Convert.ToString(corrected);
                master[19] = Convert.ToString(timertimemili);
                master[20] = Convert.ToString(timertimesec);
                master[21] = Convert.ToString(timertimedk);
                master[22] = Convert.ToString(timertimehour);
                master[23] = Convert.ToString(timertimeday);
                master[24] = Convert.ToString(timertimeyear);
                master[25] = (autosave);
                master[26] = Convert.ToString(slavesfneed);
                master[27] = Convert.ToString(slavesgetted);
                master[28] = Convert.ToString(skillsshow);
                master[29] = Convert.ToString(rebirtfneed);
                master[30] = Convert.ToString(rebirtget);
                master[31] = Convert.ToString(multskilllevel);
                master[32] = Convert.ToString(multskillisbuyed);
                master[33] = Convert.ToString(multskillfneed);
                saveFileDialog1.Filter = "F clicker save files (*.fcsave) | *.fcsave";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog1.FileName, master);
                    saveloc = saveFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText(@".\error.error",Convert.ToString(ex));
                MessageBox.Show("Error");
            }
            finally
            {

            }
        }

        private void autoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                master[0] = (fcename);
                master[1] = Convert.ToString(Fs);
                master[2] = Convert.ToString(Fpc);
                master[3] = Convert.ToString(mousefneed);
                master[4] = Convert.ToString(ver);
                master[5] = Convert.ToString(upgradenum);
                master[6] = ("Time Played");
                master[7] = Convert.ToString(mousegetted);
                master[8] = Convert.ToString(Fps);
                master[9] = Convert.ToString(fonatorfneed);
                master[10] = Convert.ToString(fonatorgetted);
                master[11] = Convert.ToString(manufabrifneed);
                master[12] = Convert.ToString(manufabrigetted);
                master[13] = Convert.ToString(multiplyer);
                master[14] = Convert.ToString(rebirts);
                master[15] = Convert.ToString(xp);
                master[16] = Convert.ToString(level);
                master[17] = Convert.ToString(ssdss);
                master[18] = Convert.ToString(corrected);
                master[19] = Convert.ToString(timertimemili);
                master[20] = Convert.ToString(timertimesec);
                master[21] = Convert.ToString(timertimedk);
                master[22] = Convert.ToString(timertimehour);
                master[23] = Convert.ToString(timertimeday);
                master[24] = Convert.ToString(timertimeyear);
                master[25] = (autosave);
                master[26] = Convert.ToString(slavesfneed);
                master[27] = Convert.ToString(slavesgetted);
                master[28] = Convert.ToString(skillsshow);
                master[29] = Convert.ToString(rebirtfneed);
                master[30] = Convert.ToString(rebirtget);
                master[31] = Convert.ToString(multskilllevel);
                master[32] = Convert.ToString(multskillisbuyed);
                master[33] = Convert.ToString(multskillfneed);
                if (string.IsNullOrEmpty(saveloc))
                {
                    MessageBox.Show("You need to save first");
                }
                else
                {
                    File.WriteAllLines(saveloc, master);
                }
            }
            catch(Exception ex)
            {
                File.WriteAllText(@".\error.error", Convert.ToString(ex));
                MessageBox.Show("Error");
            }
            finally
            {

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "F clicker save files (*.fcsave) | *.fcsave";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    master = File.ReadAllLines(openFileDialog1.FileName);
                    Fs = Convert.ToDouble(master[1]);
                    Fpc = Convert.ToDouble(master[2]);
                    mousefneed = Convert.ToDouble(master[3]);
                    mousegetted = Convert.ToInt32(master[7]);
                    Fps = Convert.ToDouble(master[8]);
                    fonatorfneed = Convert.ToDouble(master[9]);
                    fonatorgetted = Convert.ToInt32(master[10]);
                    manufabrifneed = Convert.ToDouble(master[11]);
                    manufabrigetted = Convert.ToInt32(master[12]);
                    multiplyer = Convert.ToDouble(master[13]);
                    rebirts = Convert.ToDouble(master[14]);
                    xp = Convert.ToDouble(master[15]);
                    level = Convert.ToDouble(master[16]);
                    ssdss = Convert.ToDouble(master[17]);
                    corrected = Convert.ToDouble(master[18]);
                    timertimemili = Convert.ToInt32(master[19]);
                    timertimesec = Convert.ToInt32(master[20]);
                    timertimedk = Convert.ToInt32(master[21]);
                    timertimehour = Convert.ToInt32(master[22]);
                    timertimeday = Convert.ToInt32(master[23]);
                    timertimeyear = Convert.ToInt32(master[24]);
                    autosave = (master[25]);
                    slavesfneed = Convert.ToDouble(master[26]);
                    slavesgetted = Convert.ToInt32(master[27]);
                    skillsshow = Convert.ToBoolean(master[28]);
                    rebirtfneed = Convert.ToDouble(master[29]);
                    rebirtget = Convert.ToBoolean(master[30]);
                    multskilllevel = Convert.ToInt32(master[31]);
                    multskillisbuyed = Convert.ToBoolean(master[32]);
                    multskillfneed = Convert.ToDouble(master[33]);
                    saveloc = openFileDialog1.FileName;
                }
            }
            catch(Exception ex)
            {
                File.WriteAllText(@".\error.error", Convert.ToString(ex));
                MessageBox.Show("Error");
            }
            finally
            {
                
            }
        }

        private void playtime_Tick(object sender, EventArgs e)
        {
            if (timertimemili > 99)
            {
                timertimemili = 0;
                timertimesec++;
            }
            if (timertimesec > 59)
            {
                timertimesec = 0;
                timertimedk++;
            }
            if (timertimedk > 59)
            {
                timertimedk = 0;
                timertimehour++;
            }
            if (timertimehour > 23)
            {
                timertimehour = 0;
                timertimeday++;
            }
            if (timertimeday > 364)
            {
                timertimeday = 0;
                timertimeyear++;
            }
            timertimemili++;
        }

        private void masterwriter_Tick(object sender, EventArgs e)
        {
            
        }

        private void savetimertick_Tick(object sender, EventArgs e)
        {
            if (autosave == "Auto-Save (ON)")
            {
                try
                {
                    master[0] = (fcename);
                    master[1] = Convert.ToString(Fs);
                    master[2] = Convert.ToString(Fpc);
                    master[3] = Convert.ToString(mousefneed);
                    master[4] = Convert.ToString(ver);
                    master[5] = Convert.ToString(upgradenum);
                    master[6] = ("Time Played");
                    master[7] = Convert.ToString(mousegetted);
                    master[8] = Convert.ToString(Fps);
                    master[9] = Convert.ToString(fonatorfneed);
                    master[10] = Convert.ToString(fonatorgetted);
                    master[11] = Convert.ToString(manufabrifneed);
                    master[12] = Convert.ToString(manufabrigetted);
                    master[13] = Convert.ToString(multiplyer);
                    master[14] = Convert.ToString(rebirts);
                    master[15] = Convert.ToString(xp);
                    master[16] = Convert.ToString(level);
                    master[17] = Convert.ToString(ssdss);
                    master[18] = Convert.ToString(corrected);
                    master[19] = Convert.ToString(timertimemili);
                    master[20] = Convert.ToString(timertimesec);
                    master[21] = Convert.ToString(timertimedk);
                    master[22] = Convert.ToString(timertimehour);
                    master[23] = Convert.ToString(timertimeday);
                    master[24] = Convert.ToString(timertimeyear);
                    master[25] = (autosave);
                    master[26] = Convert.ToString(slavesfneed);
                    master[27] = Convert.ToString(slavesgetted);
                    master[28] = Convert.ToString(skillsshow);
                    master[29] = Convert.ToString(rebirtfneed);
                    master[30] = Convert.ToString(rebirtget);
                    master[31] = Convert.ToString(multskilllevel);
                    master[32] = Convert.ToString(multskillisbuyed);
                    master[33] = Convert.ToString(multskillfneed);
                    if (string.IsNullOrEmpty(saveloc))
                    {
                        
                    }
                    else
                    {
                        File.WriteAllLines(saveloc, master);
                    }
                }
                catch (Exception ex)
                {
                    File.WriteAllText(@".\error.error", Convert.ToString(ex));
                    MessageBox.Show("Error");
                }
                finally
                {

                }
            }
            else
            {

            }
        }

        private void devToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                skillsshow = true;
            }
            else
            {
                skillsshow = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Rebirt")
            {
                rebirtget = true;
            }
            else
            {
                MessageBox.Show("You need (" + (rebirtfneed - Fs) + ") More Fs To Do That");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("The multiplyer want to buy?", "Skill Tree", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(Fs > multskillfneed)
                {
                    Fs -= multskillfneed;
                    multiplyer += 0.1;
                    multskillisbuyed = true;
                    multskillfneed *= 1.5;
                    multskilllevel++;
                }
                else
                {
                    MessageBox.Show("You need (" + (multskillfneed - Fs) + ") More Fs To Do That");
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void psticker_Tick(object sender, EventArgs e)
        {
            Fs += Fps * multiplyer;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(@".\fneeds.mem");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient webclient = new WebClient();
            var client = new WebClient();
            try
            {
                if (File.Exists(@"updatefile.uconfig"))
                {
                    File.Delete(@"updatefile.uconfig");
                }
                client.DownloadFile(("https://raw.githubusercontent.com/Gsdistance-org/F-Clicker/master/F%20Clicker/updatefile.uconfig"), "updatefile.uconfig");
            }
            catch(Exception ex)
            {
                File.WriteAllText(@".\error.error", Convert.ToString(ex));
            }
            finally
            {

            }
            try
            {
                versionconf = File.ReadAllLines(@".\updatefile.uconfig");
                if (versionint >= Convert.ToInt32(versionconf[1]))
                {
                    client.DownloadFile((versionconf[2]), "F Clicker Updater.exe");
                    System.Threading.Thread.Sleep(10000);
                    Process.Start("F Clicker Updater.exe");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                File.WriteAllText(@".\error.error", Convert.ToString(ex));
            }
            finally
            {

            }
        }

        private void correcter_Tick(object sender, EventArgs e)
        {
            if (Fs < 0)
            {
                Fs = 0;
                corrected++;
            }
        }
    }
}
